using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia
{
    internal class Transformer
    {
        // --- USUARIO ---
        public static UsuarioDato UsuarioAUsuarioDato(Usuario u)
        {
            return new UsuarioDato(u.Nombre, u.Dni);
        }

        public static Usuario UsuarioDatoAUsuario(UsuarioDato d)
        {
            return new Usuario(d.Nombre, d.Id);
        }

        // --- PERSONAL ---
        public static PersonalDato PersonalAPersonalDato(Personal p)
        {
            bool esSala = p is PersonalSala;
            bool esAdq = p is PersonalAdquisiciones;
            return new PersonalDato(p.Nss, p.Nombre, p.Login, p.Password, esSala, esAdq);
        }

        public static Personal PersonalDatoAPersonal(PersonalDato d)
        {
            if (d.EsSala) return new PersonalSala(d.Id, d.Nombre, d.Login, d.Password);
            else return new PersonalAdquisiciones(d.Id, d.Nombre, d.Login, d.Password);
        }

        // --- DOCUMENTO ---
        public static DocumentoDato DocumentoADocumentoDato(Documento d)
        {
            bool esLibro = d is Libro;
            bool esAudio = d is Audiolibro;
            string fmt = null;
            int dur = 0;

            if (esAudio)
            {
                Audiolibro a = (Audiolibro)d;
                fmt = a.Formato;
                dur = a.Duracion;
            }

            return new DocumentoDato(d.Isbn, d.Titulo, d.Autor, d.Editorial, d.AnoEdicion, esLibro, esAudio, fmt, dur);
        }

        public static Documento DocumentoDatoADocumento(DocumentoDato d)
        {
            if (d.EsAudiolibro)
                return new Audiolibro(d.Id, d.Titulo, d.Autor, d.Editorial, d.AnoEdicion, d.Formato, d.Duracion);
            else
                return new Libro(d.Id, d.Titulo, d.Autor, d.Editorial, d.AnoEdicion);
        }

        // --- EJEMPLAR ---
        public static EjemplarDato EjemplarAEjemplarDato(Ejemplar e)
        {
            // Guardamos referencias a Documento y Responsable por sus IDs
            return new EjemplarDato(e.Codigo, e.Documento.Isbn, e.Responsable.Nss, e.Prestado);
        }

        public static Ejemplar EjemplarDatoAEjemplar(EjemplarDato d)
        {
            // Recuperamos objetos completos
            Documento doc = DocumentoDatoADocumento(BD.TablaDocumento[d.IsbnDocumento]);
            PersonalAdquisiciones resp = (PersonalAdquisiciones)PersonalDatoAPersonal(BD.TablaPersonal[d.NssResponsable]);

            Ejemplar e = new Ejemplar(d.Id, doc, resp);
            e.Prestado = d.Prestado;
            return e;
        }

        // --- PRESTAMO ---
        public static PrestamoDato PrestamoAPrestamoDato(Prestamo p)
        {
            PrestamoClave clave = new PrestamoClave(p.Usuario.Dni, p.FechaInicio);

            // 1. Guardar las líneas en la tabla secundaria
            foreach (EjemplarPrestamo linea in p.Lineas)
            {
                EjemplarPrestamoClave claveLinea = new EjemplarPrestamoClave(clave, linea.Ejemplar.Codigo);
                EjemplarPrestamoDato lineaDato = new EjemplarPrestamoDato(claveLinea, linea.FechaPrevista, linea.FechaDevolucion, linea.Devuelto);

                // Si ya existe (actualización), la borramos para reinsertarla
                if (BD.TablaEjemplarPrestamo.Contains(claveLinea))
                    BD.TablaEjemplarPrestamo.Remove(claveLinea);

                BD.TablaEjemplarPrestamo.Add(lineaDato);
            }

            return new PrestamoDato(clave, p.Finalizado, p.Responsable.Nss);
        }

        public static Prestamo PrestamoDatoAPrestamo(PrestamoDato d)
        {
            // Recuperar Usuario y Responsable
            Usuario u = UsuarioDatoAUsuario(BD.TablaUsuario[d.Id.DniUsuario]);
            PersonalSala resp = (PersonalSala)PersonalDatoAPersonal(BD.TablaPersonal[d.NssResponsable]);

            Prestamo p = new Prestamo(u, d.Id.FechaInicio);
            p.Finalizado = d.Finalizado;
            p.Responsable = resp;

            // Recuperar líneas de detalle
            foreach (EjemplarPrestamoDato lineaDato in BD.TablaEjemplarPrestamo)
            {
                // Si la línea pertenece a este préstamo
                if (lineaDato.Id.IdPrestamo.Equals(d.Id))
                {
                    // Reconstruir Ejemplar
                    EjemplarDato ejDato = BD.TablaEjemplar[lineaDato.Id.CodigoEjemplar];
                    Ejemplar ejemplar = EjemplarDatoAEjemplar(ejDato);

                    // Reconstruir EjemplarPrestamo
                    EjemplarPrestamo linea = new EjemplarPrestamo(ejemplar, p, lineaDato.FechaPrevista);
                    linea.FechaDevolucion = lineaDato.FechaDevolucion;
                    linea.Devuelto = lineaDato.Devuelto;

                    p.Lineas.Add(linea);
                }
            }
            return p;
        }
    }
}