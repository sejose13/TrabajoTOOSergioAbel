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
    public partial class FormListadoDocumentos : Form
    {

        private LNPersonal _ln;

        public FormListadoDocumentos(LNPersonal ln)
        {
            InitializeComponent();
            _ln = ln;
        }

        private void FormListadoDocumentos_Load(object sender, EventArgs e)
        {
          

            List<Documento> docs = null;

            if (_ln is LNAdquisiciones)
            {
                docs = ((LNAdquisiciones)_ln).GetDocumentos();
            }
            else if (_ln is LNSala)
            {
              
                MessageBox.Show("Tu rol no tiene permisos para listar documentos completos.");
                this.Close();
                return;
            }

          
            dataGridView1.DataSource = docs;

        
            if (dataGridView1.Columns["Isbn"] != null)
                dataGridView1.Columns["Isbn"].HeaderText = "ISBN (Código)";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}