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
    public partial class FormListadoEjemplares : Form
    {
        private LNPersonal _ln;

        // Constructor genérico (Recibe LNPersonal)
        public FormListadoEjemplares(LNPersonal ln)
        {
            InitializeComponent();
            _ln = ln;
        }

        private void FormListadoEjemplares_Load(object sender, EventArgs e)
        {
            try
            {
                
                LNAdquisiciones logicaAdq = _ln as LNAdquisiciones;

                if (logicaAdq == null)
                {
                    MessageBox.Show("Acceso denegado. Solo personal de Adquisiciones puede ver el listado completo.");
                    this.Close();
                    return;
                }

                
                List<Ejemplar> lista = logicaAdq.GetEjemplaress();

                if (lista.Count > 0)
                {
                    // 3. Proyección para la tabla (para que salga bonita)
                    var listaParaMostrar = lista.Select(ej => new
                    {
                        Código = ej.Codigo,
                        Título = ej.Documento.Titulo,
                        ISBN = ej.Documento.Isbn,
                        // Usamos un ternario para mostrar texto en vez de true/false
                        Estado = ej.Prestado ? "PRESTADO" : "DISPONIBLE"
                    }).ToList();

                    dgvEjemplares.DataSource = listaParaMostrar;
                }
                else
                {
                    MessageBox.Show("No hay ejemplares registrados en la biblioteca.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar ejemplares: " + ex.Message);
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
