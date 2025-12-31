using System;
using System.Collections.ObjectModel;
using System.Linq;
using ModeloDominio;

namespace Persistencia
{
    public class Persistencia
    {
        // --- USUARIOS ---
        public static void CreateUsuario(Usuario usuario)
        {
            if (!BD.TablaUsuario.Contains(usuario.Dni))
                BD.TablaUsuario.Add(Transformer.UsuarioAUsuarioDato(usuario));
        }

        public static Usuario ReadUsuario(string dni)
        {
            if (BD.TablaUsuario.Contains(dni))
                return Transformer.UsuarioDatoAUsuario(BD.TablaUsuario[dni]);
            return null;
        }

        public static void DeleteUsuario(Usuario usuario)
        {
            if (BD.TablaUsuario.Contains(usuario.Dni))
                BD.TablaUsuario.Remove(usuario.Dni);
        }

        // --- PERSONAL ---
        public static void CreatePersonal(Personal personal)
        {
            if (!BD.TablaPersonal.Contains(personal.Nss))
                BD.TablaPersonal.Add(Transformer.PersonalAPersonalDato(personal));
        }

        public static Personal ReadPersonalPorLogin(string login)
        {
            // Búsqueda secuencial porque la clave es NSS, no Login
            foreach (PersonalDato p in BD.TablaPersonal)
            {
                if (p.Login == login)
                    return Transformer.PersonalDatoAPersonal(p);
            }
            return null;
        }

        // --- DOCUMENTOS ---
        public static void CreateDocumento(Documento doc)
        {
            if (!BD.TablaDocumento.Contains(doc.Isbn))
                BD.TablaDocumento.Add(Transformer.DocumentoADocumentoDato(doc));
        }

        public static Documento ReadDocumento(string isbn)
        {
            if (BD.TablaDocumento.Contains(isbn))
                return Transformer.DocumentoDatoADocumento(BD.TablaDocumento[isbn]);
            return null;
        }

        public static Collection<Documento> ReadAllDocumentos()
        {
            Collection<Documento> lista = new Collection<Documento>();
            foreach (var dato in BD.TablaDocumento)
                lista.Add(Transformer.DocumentoDatoADocumento(dato));
            return lista;
        }

        // --- EJEMPLARES ---
        public static void CreateEjemplar(Ejemplar ej)
        {
            if (!BD.TablaEjemplar.Contains(ej.Codigo))
                BD.TablaEjemplar.Add(Transformer.EjemplarAEjemplarDato(ej));
        }

        public static void UpdateEjemplar(Ejemplar ej)
        {
            if (BD.TablaEjemplar.Contains(ej.Codigo))
            {
                BD.TablaEjemplar.Remove(ej.Codigo);
                BD.TablaEjemplar.Add(Transformer.EjemplarAEjemplarDato(ej));
            }
        }

        public static Ejemplar ReadEjemplar(string codigo)
        {
            if (BD.TablaEjemplar.Contains(codigo))
                return Transformer.EjemplarDatoAEjemplar(BD.TablaEjemplar[codigo]);
            return null;
        }

        // --- PRESTAMOS ---
        public static void CreatePrestamo(Prestamo p)
        {
            // Guarda cabecera y líneas (Transformer se encarga)
            BD.TablaPrestamo.Add(Transformer.PrestamoAPrestamoDato(p));

            // Actualizamos el estado de "Prestado" en los ejemplares físicos
            foreach (var linea in p.Lineas)
            {
                linea.Ejemplar.Prestado = true;
                UpdateEjemplar(linea.Ejemplar);
            }
        }

        public static void UpdatePrestamo(Prestamo p)
        {
            PrestamoClave clave = new PrestamoClave(p.Usuario.Dni, p.FechaInicio);
            if (BD.TablaPrestamo.Contains(clave))
            {
                BD.TablaPrestamo.Remove(clave);
                BD.TablaPrestamo.Add(Transformer.PrestamoAPrestamoDato(p));
            }

            // Si el préstamo se finaliza o se devuelven libros, actualizar Ejemplares
            foreach (var linea in p.Lineas)
            {
                if (linea.Devuelto)
                {
                    linea.Ejemplar.Prestado = false;
                    UpdateEjemplar(linea.Ejemplar);
                }
            }
        }

        public static Collection<Prestamo> ReadAllPrestamos()
        {
            Collection<Prestamo> lista = new Collection<Prestamo>();
            foreach (var dato in BD.TablaPrestamo)
                lista.Add(Transformer.PrestamoDatoAPrestamo(dato));
            return lista;
        }
    }
}