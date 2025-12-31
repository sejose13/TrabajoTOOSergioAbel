using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    internal class UsuarioDato : Entity<String>
    {
        private String nombre;

        // Pasamos el DNI al constructor base porque es el ID (Entity<String>)
        public UsuarioDato(String nombre, String dni) : base(dni)
        {
            this.nombre = nombre;
        }

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is UsuarioDato other)
            {
                return this.Id.Equals(other.Id);
            }
            return false;
        }
    }
}
