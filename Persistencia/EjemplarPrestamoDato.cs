using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class EjemplarPrestamoDato : Entity<EjemplarPrestamoClave>
    {
        private DateTime fechaPrevista;
        private DateTime fechaDevolucion;
        private bool devuelto;

        public EjemplarPrestamoDato(EjemplarPrestamoClave clave, DateTime fechaPrevista, DateTime fechaDevolucion, bool devuelto)
            : base(clave)
        {
            this.fechaPrevista = fechaPrevista;
            this.fechaDevolucion = fechaDevolucion;
            this.devuelto = devuelto;
        }

        public DateTime FechaPrevista
        {
            get { return this.fechaPrevista; }
            set { this.fechaPrevista = value; }
        }

        public DateTime FechaDevolucion
        {
            get { return this.fechaDevolucion; }
            set { this.fechaDevolucion = value; }
        }

        public bool Devuelto
        {
            get { return this.devuelto; }
            set { this.devuelto = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is EjemplarPrestamoDato other)
            {
                return this.Id.Equals(other.Id);
            }
            return false;
        }
    }
}