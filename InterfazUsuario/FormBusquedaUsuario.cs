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
    public partial class FormBusquedaUsuario : Form
    {
        private LNPersonal _ln;
        public Usuario UsuarioSeleccionado { get; private set; } // Para devolver el resultado

        public FormBusquedaUsuario(LNPersonal ln)
        {
            InitializeComponent();
            _ln = ln;
        }

        private void FormBusquedaUsuario_Load(object sender, EventArgs e)
        {
            
            List<Usuario> usuarios = _ln.GetUsuarios();

            cbDni.DataSource = usuarios;
            cbDni.DisplayMember = "Dni"; 

    
            if (usuarios.Count > 0) cbDni.SelectedIndex = 0;
        }

        
        private void cbDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Usuario seleccionado = (Usuario)cbDni.SelectedItem;

            if (seleccionado != null)
            {
                
                txtNombre.Text = seleccionado.Nombre;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionado = (Usuario)cbDni.SelectedItem;
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
