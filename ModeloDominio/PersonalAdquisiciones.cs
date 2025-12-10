using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class PersonalAdquisiciones : Personal
    {
        public PersonalAdquisiciones(string nss, string nombre, string login, string password)
            : base(nss, nombre, login, password)
        {
        }
    }
}
