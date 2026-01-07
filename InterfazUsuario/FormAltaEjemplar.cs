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
    public partial class FormAltaEjemplar : Form
    {
        private LNAdquisiciones ln;

        public FormAltaEjemplar(LNAdquisiciones ln)
        {
            InitializeComponent();
            this.ln = ln;
            this.Text = "Alta de Ejemplar";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtIsbn.Text;
                string codigo = txtCodigo.Text;

                if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(codigo))
                {
                    MessageBox.Show("Introduzca ISBN del documento y Código del ejemplar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Recuperar el documento padre
                Documento doc = ln.GetDocumento(isbn);
                if (doc == null)
                {
                    MessageBox.Show("No existe un documento con ese ISBN. Primero dé de alta el documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Recuperar el usuario logueado (Casteamos porque Ejemplar pide PersonalAdquisiciones)
                // Esto es seguro porque FormAltaEjemplar solo se abre si estamos en modo Adquisiciones
                PersonalAdquisiciones responsable = (PersonalAdquisiciones)ln.UsuarioLogueado;

                // 3. Crear el Ejemplar
                Ejemplar nuevoEjemplar = new Ejemplar(codigo, doc, responsable);

                // 4. Guardar
                ln.DarAltaEjemplar(nuevoEjemplar);

                MessageBox.Show("Ejemplar añadido al documento " + doc.Titulo, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
