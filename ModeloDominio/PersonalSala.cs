using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class PersonalSala : Personal
    {
        public PersonalSala(string nss, string nombre, string login, string password)
            : base(nss, nombre, login, password)
        {
        }
    }
}
