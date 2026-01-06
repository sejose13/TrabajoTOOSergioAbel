using LogicaNegocio;
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
        private LNPersonal personal;

        public FormMenu(LNPersonal p)
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

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form alta = new FormDetalleUsuario
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoUsuarios frm = new FormListadoUsuarios(personal);
            frm.MdiParent = this; // Que se abra dentro
            frm.Show();

        }

        private void documentosPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuario1a1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecorridoUsuarios frm = new FormRecorridoUsuarios(personal);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
