using ModeloDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface ILNSala : ILNPersonal
    {

        void DarAltaPrestamo(Prestamo pres);
        void DarBajaPrestamo(Prestamo pres);
        bool GetEstadoPrestamo(Prestamo pres);
        Prestamo GetPrestamo(string dni, DateTime fecha);

        List<Prestamo> GetPrestamosConDocumentoPrestado(Documento doc);
        void DevolverEjemplarPrestado(Ejemplar ejem);

        List<Prestamo> GetPrestamosFueraDePlazo();
        List<Ejemplar> GetEjemplaresFueraDePlazo();

        string GetUsuarioPrestamo(Prestamo pres);

        List<Documento> GetDocumentosConEjemplaresSinDevolver();
        List<Documento> GetDocumentosPrestamoSinDevolver(Prestamo prestamo);
    }
}
