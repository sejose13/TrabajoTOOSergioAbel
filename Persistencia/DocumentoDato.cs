using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class DocumentoDato : Entity<String>
    {
        // Campos comunes
        private String titulo;
        private String autor;
        private String editorial;
        private DateTime anoEdicion;

        // Banderas de tipo (Igual que en PersonalDato / EmpleadoDato)
        private bool esLibro;
        private bool esAudiolibro;

        // Campos específicos de Audiolibro
        private String formato;
        private int duracion;

        // Constructor con TODAS las variables
        public DocumentoDato(String isbn, String titulo, String autor, String editorial, DateTime anoEdicion,
                             bool esLibro, bool esAudiolibro,
                             String formato, int duracion)
            : base(isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.anoEdicion = anoEdicion;
            this.esLibro = esLibro;
            this.esAudiolibro = esAudiolibro;
            this.formato = formato;
            this.duracion = duracion;
        }

        public String Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public String Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public String Editorial
        {
            get { return this.editorial; }
            set { this.editorial = value; }
        }

        public DateTime AnoEdicion
        {
            get { return this.anoEdicion; }
            set { this.anoEdicion = value; }
        }

        public bool EsLibro
        {
            get { return this.esLibro; }
          
        }

        public bool EsAudiolibro
        {
            get { return this.esAudiolibro; }
        }

        public String Formato
        {
            get { return this.formato; }
            set { this.formato = value; }
        }

        public int Duracion
        {
            get { return this.duracion; }
            set { this.duracion = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is DocumentoDato other)
            {
                return this.Id.Equals(other.Id);
            }
            return false;
        }
    }
}