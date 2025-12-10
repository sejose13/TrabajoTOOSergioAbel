using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Usuario : IEquatable<Usuario>
    {
        private string nombre;
        private string dni;

        public Usuario(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            
        }

        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override string ToString()
        {
            return this.nombre + " | " + this.dni;
        }
        
        public bool Equals(Usuario other)
        {
            if (other == null) return false;
            return this.dni.Equals(other.Dni);
        }
    }

}
