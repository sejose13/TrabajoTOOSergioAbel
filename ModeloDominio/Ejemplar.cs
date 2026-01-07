using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Ejemplar : IEquatable<Ejemplar>
    {
        private string codigo;
        private bool prestado;
        private PersonalAdquisiciones responsable;
        private Documento documento;

        public Ejemplar(string codigo, Documento documento, PersonalAdquisiciones responsable)
        {
            this.codigo = codigo;
            this.documento = documento;
            this.prestado = false;
            this.responsable = responsable;
        }

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public bool Prestado
        {
            get { return this.prestado; }
            set { this.prestado = value; }
        }

        public PersonalAdquisiciones Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        public Documento Documento
        {
            get { return this.documento; }
            set { this.documento = value; }
        }

        public override string ToString()
        {
          
            return $"Codigo: {Codigo} | ISBN: {Documento.Isbn} | Título: {Documento.Titulo}";
        }

        public bool Equals(Ejemplar other)
        {
            if (other == null) return false;
            return this.codigo.Equals(other.Codigo);
        }
        public int ObtenerDiasPrestamo()
        {
            return 15;
        }
    }
}
