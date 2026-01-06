using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace LogicaNegocio
{
    public interface ILNPersonal
    {
        //bool IniciarSesion(string nss, string pswd);
        void DarAltaUsuario(Usuario usr);
        void DarBajaUsuario(Usuario usr);
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(string dni);
        List<Documento> GetDocumentosPrestados(Usuario usr);
        List<Documento> GetDocumentosFueraDePlazo(Usuario usr);
    }
}
