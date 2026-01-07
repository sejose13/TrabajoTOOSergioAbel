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
    public partial class FormBajaDocumento : Form
    {
        private LNAdquisiciones ln;

        public FormBajaDocumento(LNAdquisiciones ln)
        {
            InitializeComponent();
            this.ln = ln;
            this.Text = "Baja de Documento";
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtIsbn.Text;
                if (string.IsNullOrWhiteSpace(isbn)) return;

                // Usamos el método nuevo GetDocumento
                Documento doc = ln.GetDocumento(isbn);

                if (doc == null)
                {
                    MessageBox.Show("Documento no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("¿Eliminar documento: " + doc.Titulo + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ln.DarBajaDocumento(doc);
                    MessageBox.Show("Documento eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
