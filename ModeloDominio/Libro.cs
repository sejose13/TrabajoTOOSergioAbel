using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Libro : Documento
    {
        public Libro(string isbn, string titulo, string autor, string editorial, DateTime anoEdicion)
            : base(isbn, titulo, autor, editorial, anoEdicion)
        {
        }

        public override int ObtenerDiasPrestamo()
        {
            return 15;
        }
    }
}
