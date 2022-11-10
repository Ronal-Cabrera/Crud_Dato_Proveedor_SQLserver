using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string contra = this.txtContra.Text;
            bool resultado = false;
         
            ConectarBD varConexion = new ConectarBD();
            varConexion.inicioConec();

            resultado = varConexion.ValidarUsuario(usuario, contra);
            if (resultado == false)
            {
                MessageBox.Show(" ERROR al Iniciar Sesión\n Verifique el USUARIO o la CONTRASEÑA");
            }
            else
            {
                Menu i = new Menu();
                i.Show();
                this.Visible = false;
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
