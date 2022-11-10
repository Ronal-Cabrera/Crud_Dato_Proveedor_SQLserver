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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        GuardarInformacion Irse = new GuardarInformacion(); 

        public void Ver()
        {
            this.Visible = true;
        }

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Ayuda v = new Ayuda();
            v.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel5.Enabled = false;
            this.papelProductos.Visible = true;
            this.NombreExis.BackColor = Color.Gray;
            this.btnNomExis.BackColor = Color.Gray;
            this.NombreExis.Enabled = false;
            this.btnNomExis.Enabled = false;
            this.Bienvenido.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.check2.Checked)
            {
                this.check1.Checked = false;
            }
            if (this.check2.Checked == false)
            {
                this.NombreExis.BackColor = Color.Gray;
                this.btnNomExis.BackColor = Color.Gray;
                this.NombreExis.Enabled = false;
                this.btnNomExis.Enabled = false;
            }
            else
            {
                this.NombreExis.BackColor = Color.White;
                this.btnNomExis.BackColor = Color.White;
                this.NombreExis.Enabled = true;
                this.btnNomExis.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(this.check1.Checked)
            {
                this.check2.Checked = false;
            }
            if(this.check1.Checked == false)
            {
                this.NombreExis.BackColor = Color.Gray;
                this.btnNomExis.BackColor = Color.Gray;
                this.NombreExis.Enabled = false;
                this.btnNomExis.Enabled = false;
            }
            else
            {
                this.NombreExis.BackColor = Color.White;
                this.btnNomExis.BackColor = Color.White;
                this.NombreExis.Enabled = true;
                this.btnNomExis.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.papel1.Visible = true;
            this.papel2.Visible = true;
            this.papelProductos.Visible = false;
            if (this.check1.Checked)
            {
                this.check1.Checked = false;
            }
            else
            {
                this.check2.Checked = false;
            }
            this.NombreExis.Text = "";
            this.panel5.Enabled = true;
            this.Bienvenido.Visible = true;
        }

        private void btnNomExis_Click(object sender, EventArgs e)
        {
            bool boleano = false;

            string ValidarNombre = this.NombreExis.Text;
            
            if (this.check1.Checked)
            {
                boleano = Irse.Validar01(ValidarNombre);
                if (boleano == false)
                {
                    MessageBox.Show(" ERROR");
                }
                else
                {
                    this.panel3.Enabled = false;
                    this.papelProductos.Enabled = false;
                    this.NombreExis.BackColor = Color.Gray;
                    this.btnNomExis.BackColor = Color.Gray;
                    this.btnRegresarMenu.BackColor = Color.Gray;
                    this.NombreExis.Enabled = false;
                    this.btnNomExis.Enabled = false;

                    Irse.Producto();
                    Irse.Show();
                }
            }
            if (this.check2.Checked)
            {
                
                boleano = Irse.Validar02(ValidarNombre);
                if (boleano == false)
                {
                    MessageBox.Show(" ERROR");
                }
                else
                {
                    this.panel3.Enabled = false;
                    this.papelProductos.Enabled = false;
                    this.NombreExis.BackColor = Color.Gray;
                    this.btnNomExis.BackColor = Color.Gray;
                    this.btnRegresarMenu.BackColor = Color.Gray;
                    this.NombreExis.Enabled = false;
                    this.btnNomExis.Enabled = false;
                    this.Visible = false;

                    Irse.Producto();
                    Irse.Show();
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.panel5.Enabled = false;
            this.Bienvenido.Visible = false;
            this.panelProveedores.Visible = true;
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            this.panel5.Enabled = true;
            this.Bienvenido.Visible = true;
            this.panelProveedores.Visible = false;
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Irse.Show();
            Irse.Individual();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Irse.Show();
            Irse.Empresa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarBuscar formtablas = new ActualizarBuscar();
            formtablas.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Bienvenido.Location = new Point(223, 210);
        }

    }
}
