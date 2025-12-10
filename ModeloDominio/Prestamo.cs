using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Prestamo : IEquatable<Prestamo>
    {
        private Usuario usuario;
        private DateTime fechaInicio;
        private bool finalizado;
        private PersonalSala responsable;
        private List<EjemplarPrestamo> ejemplaresPrestados;

        public Prestamo(Usuario usuario, DateTime fechaInicio)
        {
            this.usuario = usuario;
            this.fechaInicio = fechaInicio;
            this.finalizado = false; // Por defecto está en proceso (no finalizado)
            this.ejemplaresPrestados = new List<EjemplarPrestamo>();
        }

        public Usuario Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
            set { this.fechaInicio = value; }
        }

        public bool Finalizado
        {
            get { return this.finalizado; }
            set { this.finalizado = value; }
        }

        public List<EjemplarPrestamo> Lineas
        {
            get { return this.ejemplaresPrestados; }
            set { this.ejemplaresPrestados = value; }
        }

        public PersonalSala Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        public override string ToString()
        {
            return "Préstamo: " + this.usuario.Nombre + " - " + this.fechaInicio.ToShortDateString();
        }


        public bool Equals(Prestamo other)
        {
            if (other == null) return false;

            // Consideramos que dos préstamos son el mismo si:
            // 1. Son del mismo Usuario (usamos el Equals de Usuario que compara DNIs)
            // 2. Se hicieron en la misma fecha y hora exacta.
            return this.usuario.Equals(other.Usuario) && this.fechaInicio.Equals(other.FechaInicio);
        }
    }
}
