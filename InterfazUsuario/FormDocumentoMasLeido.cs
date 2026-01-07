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
        private Documento _doc;

        
        public FormDocumentoMasLeido(Documento doc)
        {
            InitializeComponent();
            _doc = doc;
        }

        private void FormDocumentoMasLeido_Load(object sender, EventArgs e)
        {
            if (_doc != null)
            {
                txtTitulo.Text = _doc.Titulo;
                txtAutor.Text = _doc.Autor;
                txtEditorial.Text = _doc.Editorial;
                txtIsbn.Text = _doc.Isbn;
            }
            else
            {
                
                MessageBox.Show("No hay datos del documento.");
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
