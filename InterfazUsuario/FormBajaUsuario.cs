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
    public partial class FormBajaUsuario : Form
    {
        private LNPersonal ln;

        public FormBajaUsuario(LNPersonal ln)
        {
            InitializeComponent();
            this.ln = ln;
            this.Text = "Baja de Usuario";
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Introduzca el DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Primero buscamos el objeto para pasarlo al método de borrado
                Usuario u = ln.GetUsuario(txtDni.Text);

                if (u == null)
                {
                    MessageBox.Show("No existe ningún usuario con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmación opcional (si quieres quitarla, borra el if)
                if (MessageBox.Show("¿Seguro que desea eliminar a " + u.Nombre + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ln.DarBajaUsuario(u);
                    MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
