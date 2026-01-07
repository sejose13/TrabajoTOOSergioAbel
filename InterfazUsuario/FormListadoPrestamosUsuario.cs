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
 
    public partial class FormListadoPrestamosUsuario : Form
    {
        private LNPersonal _ln;
        private Usuario _usuarioConsultado;

        
        public FormListadoPrestamosUsuario(LNPersonal ln, Usuario usuario)
        {
            InitializeComponent();
            _ln = ln;
            _usuarioConsultado = usuario;
        }

        private void FormListadoPrestamosUsuario_Load(object sender, EventArgs e)
        {
           
            lblUsuario.Text = "Usuario: " + _usuarioConsultado.Nombre + " (" + _usuarioConsultado.Dni + ")";

        
            List<Documento> prestados = _ln.GetDocumentosPrestados(_usuarioConsultado);

            if (prestados.Count > 0)
            {
                
                dgvPrestamos.DataSource = prestados;

                
            }
            else
            {
                MessageBox.Show("Este usuario no tiene ningún préstamo activo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}