using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    internal class PersonalDato : Entity<String>
    {
        private String nombre;
        private String login;
        private String password;
        private bool esSala;
        private bool esAdquisiciones;

        // El ID será el NSS
        public PersonalDato(String nss, String nombre, String login, String password, bool esSala, bool esAdquisiciones) : base(nss)
        {
            this.nombre = nombre;
            this.login = login;
            this.password = password;
            this.esSala = esSala;
            this.esAdquisiciones = esAdquisiciones;
        }

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public String Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public String Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public bool EsSala
        {
            get { return this.esSala; }
        }

        public bool EsAdquisiciones
        {
            get { return this.esAdquisiciones; }
        }

        public override bool Equals(object obj)
        {
            if (obj is PersonalDato other)
            {
                return this.Id.Equals(other.Id);
            }
            return false;
        }
    }
}
