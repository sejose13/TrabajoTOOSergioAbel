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
   
        public partial class FormSeleccionEjemplar : Form
        {
            private LNPersonal _ln;

          
            public Ejemplar EjemplarSeleccionado { get; private set; }

            public FormSeleccionEjemplar(LNPersonal ln)
            {
                InitializeComponent();
                _ln = ln;
            }

            private void FormSeleccionEjemplar_Load(object sender, EventArgs e)
            {
                try
                {
                
                if (!(_ln is LNSala))
                    {
                        MessageBox.Show("Acceso restringido a Personal de Sala.");
                        this.Close();
                        return;
                    }

                   List<Ejemplar> disponibles = ((LNSala)_ln).GetEjemplaresDisponibles();

                    
                    cbEjemplares.DataSource = disponibles;

                    cbEjemplares.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los ejemplares: " + ex.Message);
                    this.Close();
                }
            }

            private void btnAceptar_Click(object sender, EventArgs e)
            {
              
                if (cbEjemplares.SelectedItem == null)
                {
                    MessageBox.Show("Debes seleccionar un ejemplar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                EjemplarSeleccionado = (Ejemplar)cbEjemplares.SelectedItem;

                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }