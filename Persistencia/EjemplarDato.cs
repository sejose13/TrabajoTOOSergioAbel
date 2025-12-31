using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class EjemplarDato : Entity<String>
    {
        private string isbnDocumento;       // FK a Documento
        private string nssResponsable;      // FK a PersonalAdquisiciones
        private bool prestado;

        // El ID es el Codigo (String)
        public EjemplarDato(string codigo, string isbnDocumento, string nssResponsable, bool prestado)
            : base(codigo)
        {
            this.isbnDocumento = isbnDocumento;
            this.nssResponsable = nssResponsable;
            this.prestado = prestado;
        }

        public string IsbnDocumento
        {
            get { return this.isbnDocumento; }
            set { this.isbnDocumento = value; }
        }

        public string NssResponsable
        {
            get { return this.nssResponsable; }
            set { this.nssResponsable = value; }
        }

        public bool Prestado
        {
            get { return this.prestado; }
            set { this.prestado = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is EjemplarDato other)
            {
                return this.Id.Equals(other.Id);
            }
            return false;
        }
    }
}