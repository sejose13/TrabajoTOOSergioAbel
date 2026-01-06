using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class FormMenu : Form
    {
        private Personal personal;

        public FormMenu(Personal p)
        {
            InitializeComponent();
            personal = p;
            configurarMenu();
        }

        public void configurarMenu()
        {
            if (personal is PersonalSala)
            {
                menuItemDocumentos.Visible = false;
                menuItemEjemplares.Visible = false;
            }
            else if (personal is PersonalAdquisiciones)
            {
                menuItemPrestamos.Visible = false;
            }
        }
    }
}
