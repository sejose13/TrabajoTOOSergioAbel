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
    public partial class FormDocumentoMasLeido : Form
    {
        private LNPersonal _ln;

        
        public FormDocumentoMasLeido(LNPersonal ln)
        {
            InitializeComponent();
            _ln = ln;
        }

        private void FormDocumentoMasLeido_Load(object sender, EventArgs e)
        {
            try
            {
               LNAdquisiciones logicaAdq = _ln as LNAdquisiciones;

                if (logicaAdq == null)
                {
                    MessageBox.Show("Error: Se requiere acceso de Adquisiciones para ver esta estadística.");
                    this.Close();
                    return;
                }

                 Documento ganador = logicaAdq.GetDocumentoMasPrestadoUltimoMes();

                if (ganador != null)
                {
                    
                    txtTitulo.Text = ganador.Titulo;
                    txtAutor.Text = ganador.Autor;
                    txtEditorial.Text = ganador.Editorial;
                    txtIsbn.Text = ganador.Isbn;
                }
                else
                {
                     MessageBox.Show("No se han realizado préstamos en el último mes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular estadísticas: " + ex.Message);
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
