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
            FormBusquedaUsuario frm = new FormBusquedaUsuario(personal);
            frm.MdiParent = this; // Que se abra dentro
            frm.Show();
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

        private void altaDocumentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bajaDocumentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listadoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoDocumentos frm = new FormListadoDocumentos(personal);
            frm.MdiParent = this; // Que se abra dentro
            frm.Show();
        }

        private void másLeidoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaEjemplarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void bajaEjemplarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void buscarEjemplarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listadoEjemplarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void disponibilidadEjemplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaPrestamoToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void devolverPrestamoEjemplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarPrestamoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void listadoPrestamoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void listadoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentosPrestamoSinDevolverToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fueraDePlazoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarios1a1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecorridoUsuarios frm = new FormRecorridoUsuarios(personal);
            frm.MdiParent = this; // Que se abra dentro
            frm.Show();
        }
    }
}
