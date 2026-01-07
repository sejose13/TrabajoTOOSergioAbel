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
    public partial class FormBajaEjemplar : Form
    {
        private LNAdquisiciones ln;

        public FormBajaEjemplar(LNAdquisiciones ln)
        {
            InitializeComponent();
            this.ln = ln;
            this.Text = "Baja de Ejemplar";
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtIsbn.Text;
                string codigo = txtCodigo.Text;

                // 1. Validar campos vacíos
                if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(codigo))
                {
                    MessageBox.Show("Debe introducir tanto el ISBN como el Código del ejemplar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Buscar el ejemplar por su código único
                Ejemplar ej = ln.GetEjemplar(codigo);

                if (ej == null)
                {
                    MessageBox.Show("No existe ningún ejemplar con el código: " + codigo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. VERIFICACIÓN EXTRA: Comprobar si el ISBN coincide
                // Comparamos el ISBN que escribió el usuario con el ISBN real del documento al que pertenece el ejemplar
                if (ej.Documento.Isbn != isbn)
                {
                    MessageBox.Show("El ejemplar " + codigo + " existe, pero NO pertenece al documento con ISBN " + isbn + ".\nPertenece a: " + ej.Documento.Titulo,
                                    "Error de Coincidencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Confirmación y Borrado
                if (MessageBox.Show("¿Está seguro de eliminar el ejemplar " + codigo + " del documento '" + ej.Documento.Titulo + "'?",
                                    "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ln.DarBajaEjemplar(ej);
                    MessageBox.Show("Ejemplar eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Captura excepciones de la lógica (ej: "Ejemplar prestado, no se puede borrar")
                MessageBox.Show("Error al dar de baja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
