using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio;
using ModeloDominio;


using System.Windows.Forms;

namespace InterfazUsuario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtNombre.Text;
            string pass = txtPassword.Text;

            LNPersonal logicaNegocio = LNPersonal.IniciarSesion(login, pass);

            if (logicaNegocio != null)
            {
                

                FormMenu formPrincipal = new FormMenu(logicaNegocio);
                this.Hide();
                formPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
               
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}