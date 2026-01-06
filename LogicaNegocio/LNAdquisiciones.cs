using LogicaNegocio;
using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using ModeloDominio;
using Persistencia;

namespace LogicaNegocio
{
    public class LNAdquisiciones : LNPersonal, ILNAdquisiciones
    {
        public LNAdquisiciones(PersonalAdquisiciones personal) : base(personal)
        {
        }
        public void DarAltaDocumento(Documento doc)
        {
            if (Persistencia.Persistencia.ReadDocumento(doc.Isbn) != null)
                throw new Exception("Documento ya existe.");
            Persistencia.Persistencia.CreateDocumento(doc);
        }

        public void DarBajaDocumento(Documento doc)
        {
            // Validar ejemplares antes de borrar
            if (GetEjemplares(doc).Count > 0) throw new Exception("Tiene ejemplares asociados.");
            Persistencia.Persistencia.DeleteDocumento(doc);
        }

        public void DarAltaEjemplar(Ejemplar ejem)
        {
            if (Persistencia.Persistencia.ReadEjemplar(ejem.Codigo) != null)
                throw new Exception("Código de ejemplar repetido.");
            Persistencia.Persistencia.CreateEjemplar(ejem);
        }

        public void DarBajaEjemplar(Ejemplar ejem)
        {
            if (ejem.Prestado) throw new Exception("Ejemplar prestado, no se puede borrar.");
            Persistencia.Persistencia.DeleteEjemplar(ejem);
        }

        public Ejemplar GetEjemplar(string codigo)
        {
            return Persistencia.Persistencia.ReadEjemplar(codigo);
        }

        public Documento GetDocumentoMasPrestadoUltimoMes()
        {
            var dic = new Dictionary<string, int>();
            DateTime limite = DateTime.Today.AddDays(-30);

            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (p.FechaInicio >= limite)
                {
                    foreach (var l in p.Lineas)
                    {
                        string isbn = l.Ejemplar.Documento.Isbn;
                        if (!dic.ContainsKey(isbn)) dic[isbn] = 0;
                        dic[isbn]++;
                    }
                }
            }
            if (dic.Count == 0) return null;
            string topIsbn = dic.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            return Persistencia.Persistencia.ReadDocumento(topIsbn);
        }

        public List<Documento> GetDocumentos()
        {
            return new List<Documento>(Persistencia.Persistencia.ReadAllDocumentos());
        }

        public List<Ejemplar> GetEjemplares(Documento doc)
        {
            return Persistencia.Persistencia.ReadAllEjemplares()
                   .Where(e => e.Documento.Isbn == doc.Isbn).ToList();
        }

        public List<Ejemplar> GetEjemplaresSinPrestar(Documento doc)
        {
            return GetEjemplares(doc).Where(e => !e.Prestado).ToList();
        }

        public DateTime? GetFechaDisponible(Ejemplar ejemplar)
        {
            if (!ejemplar.Prestado) return DateTime.Today;

            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (!p.Finalizado)
                {
                    foreach (var l in p.Lineas)
                    {
                        if (l.Ejemplar.Codigo == ejemplar.Codigo && !l.Devuelto)
                            return l.FechaPrevista;
                    }
                }
            }
            return null;
        }
    }
}