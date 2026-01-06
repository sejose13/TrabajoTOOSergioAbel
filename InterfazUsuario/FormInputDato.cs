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
    public partial class FormInputDato : Form
    {
      
        private void FormInputDato_Load(object sender, EventArgs e)
        {

        }
          public string ValorIntroducido
        {
            get { return txtDato.Text; }
        }

        public FormInputDato(string tituloVentana, string etiqueta)
        {
            InitializeComponent();
            this.Text = tituloVentana;
            this.lblEtiqueta.Text = etiqueta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDato.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

