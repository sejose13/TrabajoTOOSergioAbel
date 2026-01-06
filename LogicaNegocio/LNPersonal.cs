using LogicaNegocio;
using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq; // Necesario para lógica de listas
using ModeloDominio;
using Persistencia;

namespace LogicaNegocio
{
    public abstract class LNPersonal : ILNPersonal
    {
        public bool IniciarSesion(string login, string pswd)
        {
            Personal p = Persistencia.Persistencia.ReadPersonalPorLogin(login);

            if (p == null) return false;

            if (p.Password == pswd.GetHashCode().ToString())
            {
                return true; 
            }

            return false; 
        }

        public void DarAltaUsuario(Usuario usr)
        {
            if (Persistencia.Persistencia.ReadUsuario(usr.Dni) != null)
                throw new Exception("El usuario ya existe.");
            Persistencia.Persistencia.CreateUsuario(usr);
        }

        public void DarBajaUsuario(Usuario usr)
        {
      
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (p.Usuario.Dni == usr.Dni && !p.Finalizado)
                    throw new Exception("Usuario con préstamos activos.");
            }
            Persistencia.Persistencia.DeleteUsuario(usr);
        }

        public List<Usuario> GetUsuarios()
        {
            return new List<Usuario>(Persistencia.Persistencia.ReadAllUsuarios());
        }

        public Usuario GetUsuario(string dni)
        {
            return Persistencia.Persistencia.ReadUsuario(dni);
        }

        public List<Documento> GetDocumentosPrestados(Usuario usr)
        {
            List<Documento> docs = new List<Documento>();
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (p.Usuario.Dni == usr.Dni && !p.Finalizado)
                {
                    foreach (var l in p.Lineas)
                        if (!l.Devuelto) docs.Add(l.Ejemplar.Documento);
                }
            }
            return docs;
        }

        public List<Documento> GetDocumentosFueraDePlazo(Usuario usr)
        {
            List<Documento> docs = new List<Documento>();
            DateTime hoy = DateTime.Today;
            foreach (var p in Persistencia.Persistencia.ReadAllPrestamos())
            {
                if (p.Usuario.Dni == usr.Dni && !p.Finalizado)
                {
                    foreach (var l in p.Lineas)
                        if (!l.Devuelto && l.FechaPrevista < hoy) docs.Add(l.Ejemplar.Documento);
                }
            }
            return docs;
        }
    }
}