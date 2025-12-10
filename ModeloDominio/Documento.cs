using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Documento : IEquatable<Documento>
    {
        private string isbn;
        private string titulo;
        private string autor;
        private string editorial;
        private DateTime anoEdicion;

        public Documento(string isbn, string titulo, string autor, string editorial, DateTime anoEdicion)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.anoEdicion = anoEdicion;
        }

        public string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public string Editorial
        {
            get { return this.editorial; }
            set { this.editorial = value; }
        }

        public DateTime AnoEdicion
        {
            get { return this.anoEdicion; }
            set { this.anoEdicion = value; }
        }

        public abstract int ObtenerDiasPrestamo();

        public override string ToString()
        {
            return this.titulo + " [" + this.isbn + "]";
        }

        public bool Equals(Documento other)
        {
            if (other == null) return false;
            return this.isbn.Equals(other.Isbn);
        }
    }
}
