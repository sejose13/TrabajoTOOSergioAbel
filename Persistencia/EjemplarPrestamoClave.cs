using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class EjemplarPrestamoClave : IEquatable<EjemplarPrestamoClave>
    {
        private PrestamoClave idPrestamo; // Clave foránea al Préstamo padre
        private string codigoEjemplar;    // Clave foránea al Ejemplar

        public EjemplarPrestamoClave(PrestamoClave idPrestamo, string codigoEjemplar)
        {
            this.idPrestamo = idPrestamo;
            this.codigoEjemplar = codigoEjemplar;
        }

        public PrestamoClave IdPrestamo
        {
            get { return this.idPrestamo; }
        }

        public string CodigoEjemplar
        {
            get { return this.codigoEjemplar; }
        }

        public bool Equals(EjemplarPrestamoClave other)
        {
            if (other == null) return false;
            // Coincide si es el mismo préstamo Y el mismo libro
            return this.idPrestamo.Equals(other.IdPrestamo) && this.codigoEjemplar.Equals(other.CodigoEjemplar);
        }

       /* public override int GetHashCode()
        {
            return idPrestamo.GetHashCode() ^ codigoEjemplar.GetHashCode();
        }*/
    }
}