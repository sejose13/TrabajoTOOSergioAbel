using LogicaNegocio;
using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using ModeloDominio;
using Persistencia;

namespace LogicaNegocio
{

    public class LNSala : LNPersonal, ILNSala
    {
        public LNSala(PersonalSala personal) : base(personal)
        {
        }
        public void DarAltaPrestamo(Prestamo pres)
        {
            foreach (var l in pres.Lineas)
            {
                if (l.Ejemplar.Prestado) throw new Exception("El ejemplar " + l.Ejemplar.Codigo + " ya está prestado.");
            }
            Persistencia.Persistencia.CreatePrestamo(pres);
        }

        public void DarBajaPrestamo(Prestamo pres)
        {
            Persistencia.Persistencia.DeletePrestamo(pres);
        }

        public bool GetEstadoPrestamo(Prestamo pres)
        {
            return pres.Finalizado;
        }

        public Prestamo GetPrestamo(string dni, DateTime fecha)
        {
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (p.Usuario.Dni == dni && p.FechaInicio == fecha) return p;
            }
            return null;
        }

        public List<Prestamo> GetPrestamosConDocumentoPrestado(Documento doc)
        {
            List<Prestamo> res = new List<Prestamo>();
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (!p.Finalizado && p.Lineas.Any(l => l.Ejemplar.Documento.Isbn == doc.Isbn && !l.Devuelto))
                    res.Add(p);
            }
            return res;
        }

        public void DevolverEjemplarPrestado(Ejemplar ejem)
        {
            bool encontrado = false;
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (!p.Finalizado)
                {
                    foreach (var l in p.Lineas)
                    {
                        if (l.Ejemplar.Codigo == ejem.Codigo && !l.Devuelto)
                        {
                            l.Devuelto = true;
                            l.FechaDevolucion = DateTime.Today;
                            encontrado = true;
                            // Comprobar si cerramos préstamo
                            if (p.Lineas.All(linea => linea.Devuelto)) p.Finalizado = true;

                            Persistencia.Persistencia.UpdatePrestamo(p);
                            break;
                        }
                    }
                }
                if (encontrado) break;
            }
            if (!encontrado) throw new Exception("No hay préstamo activo para este ejemplar.");
        }

        public List<Prestamo> GetPrestamosFueraDePlazo()
        {
            return Persistencia.Persistencia.ReadAllPrestamos()
                   .Where(p => !p.Finalizado && p.Lineas.Any(l => !l.Devuelto && l.FechaPrevista < DateTime.Today))
                   .ToList();
        }

        public List<Ejemplar> GetEjemplaresFueraDePlazo()
        {
            List<Ejemplar> ejems = new List<Ejemplar>();
            DateTime hoy = DateTime.Today;
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (!p.Finalizado)
                {
                    foreach (var l in p.Lineas)
                        if (!l.Devuelto && l.FechaPrevista < hoy) ejems.Add(l.Ejemplar);
                }
            }
            return ejems;
        }

        public string GetUsuarioPrestamo(Prestamo pres)
        {
            return pres.Usuario.Nombre;
        }

        public List<Documento> GetDocumentosConEjemplaresSinDevolver()
        {
            HashSet<Documento> docs = new HashSet<Documento>();
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (!p.Finalizado)
                {
                    foreach (var l in p.Lineas)
                        if (!l.Devuelto) docs.Add(l.Ejemplar.Documento);
                }
            }
            return docs.ToList();
        }

        public List<Documento> GetDocumentosPrestamoSinDevolver(Prestamo prestamo)
        {
            return prestamo.Lineas.Where(l => !l.Devuelto).Select(l => l.Ejemplar.Documento).ToList();
        }

        public List<Ejemplar> GetEjemplaresDisponibles()
        {
            List<Ejemplar> todos = new List<Ejemplar>(Persistencia.Persistencia.ReadAllEjemplares());
            return todos.Where(e => !e.Prestado).ToList();
        }
    }
}