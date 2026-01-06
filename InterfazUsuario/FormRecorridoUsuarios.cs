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
    public partial class FormRecorridoUsuarios : Form
    {

    
        private LNPersonal _ln;
        private BindingSource _bindingSource; 
        public FormRecorridoUsuarios(LNPersonal ln)
        {
            InitializeComponent();
            _ln = ln;
            _bindingSource = new BindingSource();
        }

        private void FormRecorridoUsuarios_Load(object sender, EventArgs e)
        {
        
            List<Usuario> lista = _ln.GetUsuarios();

            
            _bindingSource.DataSource = lista;

            bindingNavigator1.BindingSource = _bindingSource;

            txtDni.DataBindings.Add("Text", _bindingSource, "Dni");
            txtNombre.DataBindings.Add("Text", _bindingSource, "Nombre");
        }
    }
}