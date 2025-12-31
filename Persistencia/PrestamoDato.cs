using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class PrestamoDato : Entity<PrestamoClave>
    {
        private bool finalizado;
        private string nssResponsable;

        public PrestamoDato(PrestamoClave clave, bool finalizado, string nssResponsable) : base(clave)
        {
            this.finalizado = finalizado;
            this.nssResponsable = nssResponsable;
        }

        public bool Finalizado
        {
            get { return this.finalizado; }
            set { this.finalizado = value; }
        }

        public string NssResponsable
        {
            get { return this.nssResponsable; }
            set { this.nssResponsable = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is PrestamoDato other)
            {
                return this.Id.Equals(other.Id);
            }
            return false;
        }
    }
}