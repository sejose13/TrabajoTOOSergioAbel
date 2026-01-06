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
    public partial class FormListadoUsuarios : Form
    {

    
        private LNPersonal _ln;
        private List<Usuario> _listaUsuarios; 
        public FormListadoUsuarios(LNPersonal ln)
        {
            InitializeComponent();
            _ln = ln;
        }

        private void FormListadoUsuarios_Load(object sender, EventArgs e)
        {
            _listaUsuarios = _ln.GetUsuarios();

            ActualizarListas();
        }

        
        private void ActualizarListas()
        {
            lbDnis.Items.Clear();
            lbNombres.Items.Clear();

            foreach (Usuario u in _listaUsuarios)
            {
                lbDnis.Items.Add(u.Dni);
                lbNombres.Items.Add(u.Nombre);
            }
        }

      
        private void btnOrdenDni_Click(object sender, EventArgs e)
        {
          
            _listaUsuarios = _listaUsuarios.OrderBy(u => u.Dni).ToList();

    
            ActualizarListas();
        }

     
        private void btnOrdenNombre_Click(object sender, EventArgs e)
        {
        
            _listaUsuarios = _listaUsuarios.OrderBy(u => u.Nombre).ToList();

           
            ActualizarListas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDnis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDnis.SelectedIndex != -1)
                lbNombres.SelectedIndex = lbDnis.SelectedIndex;
        }

        private void lbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNombres.SelectedIndex != -1)
                lbDnis.SelectedIndex = lbNombres.SelectedIndex;
        }
    }
}