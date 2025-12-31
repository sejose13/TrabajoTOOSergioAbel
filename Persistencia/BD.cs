using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class BD
    {
        private static Tabla<String, UsuarioDato> tablaUsuario;
        private static Tabla<String, PersonalDato> tablaPersonal;
        private static Tabla<String, DocumentoDato> tablaDocumento;
        private static Tabla<String, EjemplarDato> tablaEjemplar;

        private static Tabla<PrestamoClave, PrestamoDato> tablaPrestamo;
        private static Tabla<EjemplarPrestamoClave, EjemplarPrestamoDato> tablaEjemplarPrestamo;

        private BD() { }

        public static Tabla<String, UsuarioDato> TablaUsuario
        {
            get
            {
                if (tablaUsuario == null) tablaUsuario = new Tabla<string, UsuarioDato>();
                return tablaUsuario;
            }
        }

        public static Tabla<String, PersonalDato> TablaPersonal
        {
            get
            {
                if (tablaPersonal == null) tablaPersonal = new Tabla<string, PersonalDato>();
                return tablaPersonal;
            }
        }

        public static Tabla<String, DocumentoDato> TablaDocumento
        {
            get
            {
                if (tablaDocumento == null) tablaDocumento = new Tabla<string, DocumentoDato>();
                return tablaDocumento;
            }
        }

        public static Tabla<String, EjemplarDato> TablaEjemplar
        {
            get
            {
                if (tablaEjemplar == null) tablaEjemplar = new Tabla<string, EjemplarDato>();
                return tablaEjemplar;
            }
        }

        public static Tabla<PrestamoClave, PrestamoDato> TablaPrestamo
        {
            get
            {
                if (tablaPrestamo == null)
                {
                  
                    tablaPrestamo = new Tabla<PrestamoClave, PrestamoDato>();
                }
                return tablaPrestamo;
            }
        }

        public static Tabla<EjemplarPrestamoClave, EjemplarPrestamoDato> TablaEjemplarPrestamo
        {
            get
            {
                if (tablaEjemplarPrestamo == null)
                {
                   
                    tablaEjemplarPrestamo = new Tabla<EjemplarPrestamoClave, EjemplarPrestamoDato>();
                }
                return tablaEjemplarPrestamo;
            }
        }
    }
}