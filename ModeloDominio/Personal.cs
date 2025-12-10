using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public abstract class Personal : IEquatable<Personal>
    {
        private string nss;
        private string nombre;
        private string login;
        private string password; 
       
        public Personal(string nss, string nombre, string login, string password)
        {
            this.nss = nss;
            this.nombre = nombre;
            this.login = login;
            this.password = password.GetHashCode().ToString();
        }

        public string Nss
        {
            get { return this.nss; }
            set { this.nss = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public string Password
        {
            get
            {
                 return this.password;
            }
            set
            {
                this.password = value.GetHashCode().ToString();
            }
        }

        public override string ToString()
        {
            return this.nombre + " (" + this.login + ")";
        }

        public bool Equals(Personal other)
        {
            if (other == null) return false;
            return this.nss.Equals(other.Nss);
        }
    }
}
