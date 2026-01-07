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
    public partial class FormAltaPrestamo : Form
    {
        public FormAltaPrestamo()
        {
            InitializeComponent();
        }
        
            private LNPersonal _ln;

           
            private List<Ejemplar> _ejemplaresCarrito = new List<Ejemplar>();

            public FormAltaPrestamo(LNPersonal ln)
            {
                InitializeComponent();
                _ln = ln;
            }

            private void FormAltaPrestamo_Load(object sender, EventArgs e)
            {
               
                txtFecha.Text = DateTime.Today.ToShortDateString();

               
                cbUsuarios.DataSource = _ln.GetUsuarios();
                cbUsuarios.DisplayMember = "Dni"; 
            }

            private void btnAnadirEjemplar_Click(object sender, EventArgs e)
            {
                
                FormSeleccionEjemplar frm = new FormSeleccionEjemplar(_ln);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Ejemplar nuevo = frm.EjemplarSeleccionado;

              
                    foreach (Ejemplar yaEnLista in _ejemplaresCarrito)
                    {
                        if (yaEnLista.Codigo == nuevo.Codigo)
                        {
                            MessageBox.Show("Este ejemplar ya está añadido a la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                   
                    _ejemplaresCarrito.Add(nuevo);

                    
                    lbEjemplares.Items.Add(nuevo.Codigo + " - " + nuevo.Documento.Titulo);
                }
            }

            private void btnAceptar_Click(object sender, EventArgs e)
            {
                try
                {
                    
                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        MessageBox.Show("Debes introducir un ID para el préstamo.", "Falta ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cbUsuarios.SelectedItem == null)
                    {
                        MessageBox.Show("Debes seleccionar un usuario.", "Falta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (_ejemplaresCarrito.Count == 0)
                    {
                        MessageBox.Show("El préstamo debe tener al menos un ejemplar.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    Usuario usuarioSeleccionado = (Usuario)cbUsuarios.SelectedItem;

                    Prestamo nuevoPrestamo = new Prestamo(usuarioSeleccionado, DateTime.Today);

                   
                    foreach (Ejemplar ej in _ejemplaresCarrito)
                    {
                        
                        DateTime fechaPrevista = DateTime.Today.AddDays(ej.ObtenerDiasPrestamo());

               
                        EjemplarPrestamo linea = new EjemplarPrestamo( ej,nuevoPrestamo, fechaPrevista);

                        
                        nuevoPrestamo.Lineas.Add(linea);
                    }

                  
                    if (_ln is LNSala)
                    {
                        
                        ((LNSala)_ln).DarAltaPrestamo(nuevoPrestamo);

                        MessageBox.Show("Préstamo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        
                        MessageBox.Show("Solo el personal de Sala puede realizar préstamos.", "Error de Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error al guardar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        
    }
}

