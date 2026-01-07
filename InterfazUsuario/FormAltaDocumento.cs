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
    public partial class FormAltaDocumento : Form
    {
        private LNAdquisiciones ln;

        public FormAltaDocumento(LNAdquisiciones ln)
        {
            InitializeComponent();
            this.ln = ln;
            this.Text = "Alta de Documento";

            cmbTipo.Items.Add("Libro");
            cmbTipo.Items.Add("Audiolibro");
            cmbTipo.SelectedIndex = 0;
            panelAudio.Visible = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si selecciona Audiolibro, mostramos sus campos
            panelAudio.Visible = (cmbTipo.SelectedItem.ToString() == "Audiolibro");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Recoger datos comunes
                string isbn = txtIsbn.Text;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string editorial = txtEditorial.Text;

                // Validación básica de campos vacíos
                if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(titulo))
                {
                    MessageBox.Show("ISBN y Título son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir año a DateTime (1 de Enero del año indicado)
                if (!int.TryParse(txtAno.Text, out int anoNum))
                {
                    MessageBox.Show("El año debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fechaEdicion = new DateTime(anoNum, 1, 1);

                Documento nuevoDoc = null;

                // 2. Instanciar según el tipo
                if (cmbTipo.SelectedItem.ToString() == "Libro")
                {
                    nuevoDoc = new Libro(isbn, titulo, autor, editorial, fechaEdicion);
                }
                else // Audiolibro
                {
                    string formato = txtFormato.Text;
                    if (!int.TryParse(txtDuracion.Text, out int duracion))
                    {
                        MessageBox.Show("La duración debe ser un número (minutos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    nuevoDoc = new Audiolibro(isbn, titulo, autor, editorial, fechaEdicion, formato, duracion);
                }

                // 3. Llamar a lógica
                ln.DarAltaDocumento(nuevoDoc);
                MessageBox.Show("Documento dado de alta correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) { this.Close(); }
    }
}
