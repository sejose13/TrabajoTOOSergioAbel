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
    public partial class FormDetalleUsuario : Form
    {
    
 
        private LNPersonal _ln;
        private Usuario _usuario;
        private bool _modoAlta; // true = Alta, false = Baja o Consulta

        
        public FormDetalleUsuario(LNPersonal ln, Usuario usuario, bool modoAlta)
        {
            InitializeComponent();
            _ln = ln;
            _usuario = usuario;
            _modoAlta = modoAlta;
        }

        private void FormDetalleUsuario_Load(object sender, EventArgs e)
        {
            // Rellenamos los campos
            txtDni.Text = _usuario.Dni;
            txtDni.Enabled = false; // El DNI no se toca, viene de la búsqueda anterior

            if (_modoAlta)
            {
                // MODO ALTA: Campos vacíos y habilitados para escribir
                this.Text = "Alta de usuario";
                txtNombre.Text = "";
                txtNombre.Enabled = true;
            }
            else
            {
                // MODO BAJA/CONSULTA: Campos rellenos y deshabilitados
                this.Text = "Datos de usuario"; // o "Baja de usuario"
                txtNombre.Text = _usuario.Nombre;
                txtNombre.Enabled = false; // Solo lectura
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_modoAlta)
                {
                    // --- LÓGICA DE ALTA ---
                    if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        MessageBox.Show("Debes introducir un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
       
                    _usuario.Nombre = txtNombre.Text;

                     _ln.DarAltaUsuario(_usuario);

                    MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // --- LÓGICA DE BAJA ---
                    // Si no es alta, asumimos que es Baja (o podríamos bloquear el botón si es consulta)
                    DialogResult res = MessageBox.Show("¿Está seguro que desea dar de baja al usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        _ln.DarBajaUsuario(_usuario);
                        MessageBox.Show("Usuario eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return; // Si dice que no, no cerramos la ventana
                    }
                }

                this.Close(); // Cerramos al terminar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}