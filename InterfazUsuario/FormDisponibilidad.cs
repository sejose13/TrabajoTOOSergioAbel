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

    public partial class FormDisponibilidad : Form
    {
        private LNPersonal _ln;

        public FormDisponibilidad(LNPersonal ln)
        {
            InitializeComponent();
            _ln = ln;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor, escribe un código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
              

                LNAdquisiciones logicaAdq = _ln as LNAdquisiciones;

                if (logicaAdq == null)
                {
                    
                    MessageBox.Show("No tienes permisos para buscar ejemplares (Solo Adquisiciones).",
                                    "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                Ejemplar ej = logicaAdq.GetEjemplar(codigo);

                if (ej != null)
                {
                  
                    if (ej.Prestado)
                    {
                        MessageBox.Show($"El ejemplar '{ej.Documento.Titulo}' (Cod: {ej.Codigo}) está PRESTADO.",
                                        "No disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"El ejemplar '{ej.Documento.Titulo}' (Cod: {ej.Codigo}) está DISPONIBLE.",
                                        "Disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No existe ningún ejemplar con ese código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al comprobar disponibilidad: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}