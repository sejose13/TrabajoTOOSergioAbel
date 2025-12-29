using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class EjemplarPrestamo : IEquatable<EjemplarPrestamo>
    {
        private Ejemplar ejemplar;
        private Prestamo prestamo;
        private DateTime fechaDevolucion;
        private DateTime fechaPrevista;
        private bool devuelto;

        public EjemplarPrestamo(Ejemplar e, Prestamo p, DateTime fechaPrevista)
        {
            this.ejemplar = e;
            this.prestamo = p;
            this.fechaPrevista = fechaPrevista;
            this.devuelto = false;
        }

        public Ejemplar Ejemplar
        {
            get { return ejemplar; }
        }

        public Prestamo Prestamo
        {
            get { return prestamo; }
        }

        public DateTime FechaDevolucion
        {
            get { return fechaDevolucion; }
            set { fechaDevolucion = value; }
        }

        public bool Devuelto
        {
            get { return devuelto; }
            set { devuelto = value; }
        }

        public bool Equals(EjemplarPrestamo other)
        {
            if (other == null) return false;

            // La igualdad depende del Ejemplar y prestamo.
            // (Usamos el Equals de Ejemplar que compara los códigos de barras)
            return this.ejemplar.Equals(other.Ejemplar) && this.prestamo.Equals(other.prestamo);
        }
        //anormal
    }
}
