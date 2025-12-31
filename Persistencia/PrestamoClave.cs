using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Persistencia
{
    
    internal class PrestamoClave : IEquatable<PrestamoClave>
    {
        private string dniUsuario;
        private DateTime fechaInicio;

        public PrestamoClave(string dniUsuario, DateTime fechaInicio)
        {
            this.dniUsuario = dniUsuario;
            this.fechaInicio = fechaInicio;
        }

        public string DniUsuario
        {
            get { return this.dniUsuario; }
        }

        public DateTime FechaInicio
        {
            get { return this.fechaInicio; }
        }

        public bool Equals(PrestamoClave other)
        {
            if (other == null) return false;
            return this.dniUsuario == other.dniUsuario && this.fechaInicio.Equals(other.fechaInicio);
        }

       /* public override int GetHashCode()
        {
            // Combinamos los hash para que funcione rápido en la Tabla
            return this.dniUsuario.GetHashCode() ^ this.fechaInicio.GetHashCode();
        }*/
        public override bool Equals(object obj)
        {
            if (obj is PrestamoClave other)
            {
                return Equals(other);
            }
            return false;
        }
    }
}
