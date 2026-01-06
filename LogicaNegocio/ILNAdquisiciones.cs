using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface ILNAdquisiciones : ILNPersonal
    {
        // Métodos de la caja "Adquisiciones"
        void DarAltaDocumento(Documento doc);
        void DarBajaDocumento(Documento doc);

        void DarAltaEjemplar(Ejemplar ejem);
        void DarBajaEjemplar(Ejemplar ejem);

        Ejemplar GetEjemplar(string codigo);
        Documento GetDocumentoMasPrestadoUltimoMes();

        List<Documento> GetDocumentos();
        List<Ejemplar> GetEjemplares(Documento doc);
        List<Ejemplar> GetEjemplaresSinPrestar(Documento doc);

        DateTime? GetFechaDisponible(Ejemplar ejemplar);
    }
}
