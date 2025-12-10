using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Audiolibro : Documento
    {
        private string formato;
        private int duracion;

        public Audiolibro(string isbn, string titulo, string autor, string editorial, DateTime anoEdicion, string formato, int duracion)
            : base(isbn, titulo, autor, editorial, anoEdicion)
        {
            this.formato = formato;
            this.duracion = duracion;
        }

        public string Formato
        {
            get { return this.formato; }
            set { this.formato = value; }
        }

        public int Duracion
        {
            get { return this.duracion; }
            set { this.duracion = value; }
        }

        public override int ObtenerDiasPrestamo()
        {
            return 10;
        }
    }
}
