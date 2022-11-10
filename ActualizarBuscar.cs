using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto_final
{
    public partial class ActualizarBuscar : Form
    {
        public ActualizarBuscar()
        {
            InitializeComponent();
        }

        ConectarBD pedirPE = new ConectarBD();
        ActualizarDatos Actualiza = new ActualizarDatos();
        string query = " ";

        void Empresaa()
        {
            pedirPE.inicioConec();

            query = "Select * from DatosEmpresaProveedora";
            SqlCommand comando = new SqlCommand(query, pedirPE.conectar);
            SqlDataAdapter informacionPE = new SqlDataAdapter();
            informacionPE.SelectCommand = comando;

            DataTable tablaPE = new DataTable();
            informacionPE.Fill(tablaPE);

            tablaDatos.DataSource = tablaPE;
            pedirPE.inicioDeconec();
        }
        private void btnInfoEmpresa_Click(object sender, EventArgs e)
        {
            Empresaa();
      
            this.radioBTNEmpresa.Visible = true;
            this.btnRegresarAB.Visible = true;
            this.btnInfoEmpresa.Enabled = false;
            this.btnInfoProducto.Enabled = false;
            this.btnInfoProveedor.Enabled = false;
            this.labelInfoBTN.Text = "Informacion de Empresas Proveedoras";
        }

        void Productoo()
        {
            pedirPE.inicioConec();

            query = "Select * from DatosProducto";
            SqlCommand comando3 = new SqlCommand(query, pedirPE.conectar);
            SqlDataAdapter informacionPT = new SqlDataAdapter();
            informacionPT.SelectCommand = comando3;

            DataTable tablaPT = new DataTable();
            informacionPT.Fill(tablaPT);

            tablaDatos.DataSource = tablaPT;
            pedirPE.inicioDeconec();
        }
        private void btnInfoProducto_Click(object sender, EventArgs e)
        {
            Productoo();

            this.radioBTNProduc.Visible = true;
            this.btnRegresarAB.Visible = true;
            this.btnInfoEmpresa.Enabled = false;
            this.btnInfoProducto.Enabled = false;
            this.btnInfoProveedor.Enabled = false;
        }

        void Proveedorr()
        {
            pedirPE.inicioConec();

            query = "Select * from DatosProveedor";
            SqlCommand comando2 = new SqlCommand(query, pedirPE.conectar);
            SqlDataAdapter informacionP = new SqlDataAdapter();
            informacionP.SelectCommand = comando2;

            DataTable tablaP = new DataTable();
            informacionP.Fill(tablaP);

            tablaDatos.DataSource = tablaP;
            pedirPE.inicioDeconec();
        }
        private void btnInfoProveedor_Click(object sender, EventArgs e)
        {
            Proveedorr();
            
            this.radioBTNProv.Visible = true;
            this.btnRegresarAB.Visible = true;
            this.btnInfoEmpresa.Enabled = false;
            this.btnInfoProducto.Enabled = false;
            this.btnInfoProveedor.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.tablaDatos.DataSource = "";
            this.labelInfoBTN.Text = "";

            if (this.radioBTNEmpresa.Visible == true)
            {
                this.radioBTNEmpresa.Visible = false;
            }
            if (this.radioBTNProv.Visible == true)
            {
                this.radioBTNProv.Visible = false;
            }
            if (this.radioBTNProduc.Visible == true)
            {
                this.radioBTNProduc.Visible = false;
            }
            this.btnRegresarAB.Visible = false;
            this.btnInfoEmpresa.Enabled = true;
            this.btnInfoProducto.Enabled = true;
            this.btnInfoProveedor.Enabled = true;
        }

        private void radioBTNProduc_CheckedChanged(object sender, EventArgs e)
        {
            this.GrupoBTN.Visible = false;
            this.tablaDatos.Location = new Point(18, 21);
            this.tablaDatos.Size = new Size(400, 292);
            this.panel2.Size = new Size(438, 369);
            this.btnRecargar.Visible = true;
            this.btnRegresarAB.Visible = false;
            this.ControlBox = false;
            this.panelActualizaion.Visible = true;
            this.BoxEmpresa.Visible = false;
            this.BoxProveedor.Visible = false;
            this.BoxProducto.Visible = true;
            this.labelActualizacion.Text = "Informacion de Productos";
        }

        private void radioBTNEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            this.GrupoBTN.Visible = false;
            this.tablaDatos.Location = new Point(18, 21);
            this.tablaDatos.Size = new Size(400, 292);
            this.panel2.Size = new Size(438, 369);
            this.btnRecargar.Visible = true;
            this.btnRegresarAB.Visible = false;
            this.ControlBox = false;
            this.panelActualizaion.Visible = true;
            this.BoxProducto.Visible = false;
            this.BoxProveedor.Visible = false;
            this.BoxEmpresa.Visible = true;
            this.labelActualizacion.Text = "Informacion de Empresa Proveedora";
        }

        private void radioBTNProv_CheckedChanged(object sender, EventArgs e)
        {
            this.GrupoBTN.Visible = false;
            this.tablaDatos.Location = new Point(18, 21);
            this.tablaDatos.Size = new Size(400, 292);
            this.panel2.Size = new Size(438, 369);
            this.btnRecargar.Visible = true;
            this.btnRegresarAB.Visible = false;
            this.ControlBox = false;
            this.panelActualizaion.Visible = true;
            this.BoxEmpresa.Visible = false;
            this.BoxProducto.Visible = false;
            this.BoxProveedor.Visible = true;
            this.labelActualizacion.Text = "Informacion de Proveedor Individual";
        }

        void AbYDes()
        {
            this.Finalizar.Enabled = false;
            this.Finalizar.BackColor = Color.Gray;
            this.Finalizar.ForeColor = Color.Silver;

            this.GrupoPreguntar.Enabled = false;
            this.labelAct.BackColor = Color.Gray;
            this.labelAct.ForeColor = Color.Silver;
            this.textNombreXD.BackColor = Color.Gray;
            this.textNombreXD.ForeColor = Color.Black;
            this.button3.BackColor = Color.Gray;
            this.button3.ForeColor = Color.Silver;

            this.Modificar.Enabled = true;
            this.Modificar.BackColor = Color.White;
            this.Modificar.ForeColor = Color.Black;
            this.Eliminar.Enabled = true;
            this.Eliminar.BackColor = Color.White;
            this.Eliminar.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.radioBTNEmpresa.Checked)
            {
                pedirPE.inicioConec();
                string queryEmpresa = "Select * from DatosEmpresaProveedora where Codigo = '" + this.textNombreXD.Text + "'";
                SqlCommand cmdNomEmpre = new SqlCommand(queryEmpresa, pedirPE.conectar);
                SqlDataReader rsNomEmpre = cmdNomEmpre.ExecuteReader();
                if (rsNomEmpre.HasRows == false)
                {
                    MessageBox.Show("Error");
                    this.textNombreXD.Text = "";
                }
                else
                {
                    AbYDes();
                }
                pedirPE.inicioDeconec();
            }
            if (this.radioBTNProv.Checked)
            {
                pedirPE.inicioConec();
                string queryProveedor = "Select * from DatosProveedor where Codigo = '" + this.textNombreXD.Text + "'";

                SqlCommand cmdNomProv = new SqlCommand(queryProveedor, pedirPE.conectar);
                SqlDataReader rsNomProv = cmdNomProv.ExecuteReader();
                if (rsNomProv.HasRows == false)
                {
                    MessageBox.Show("Error");
                    this.textNombreXD.Text = "";
                }
                else
                {
                    AbYDes();
                }
                pedirPE.inicioDeconec();
            }
            if (this.radioBTNProduc.Checked)
            {
                pedirPE.inicioConec();
                string queryProveedor = "Select * from DatosProducto where Codigo = '" + this.textNombreXD.Text + "'";

                SqlCommand cmdNomProc = new SqlCommand(queryProveedor, pedirPE.conectar);
                SqlDataReader rsNomProc = cmdNomProc.ExecuteReader();
                if (rsNomProc.HasRows == false)
                {
                    MessageBox.Show("Error");
                    this.textNombreXD.Text = "";
                }
                else
                {
                    AbYDes();
                }
                pedirPE.inicioDeconec();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.radioBTNProv.Checked = false;
            this.radioBTNProduc.Checked = false;
            this.radioBTNEmpresa.Checked = false;

            this.panelActualizaion.Visible = false;

            this.ControlBox = true;

            this.panel2.Size = new Size(1161, 369);
            this.tablaDatos.Location = new Point(450, 48);
            this.tablaDatos.Size = new Size(680, 272);
            this.tablaDatos.DataSource = "";
            this.labelInfoBTN.Text = "";
            this.radioBTNEmpresa.Location = new Point(1009, 326);
            this.radioBTNProv.Location = new Point(1009, 326);
            this.radioBTNProduc.Location = new Point(1009, 326);
            this.radioBTNEmpresa.Visible = false;
            this.radioBTNProv.Visible = false;
            this.radioBTNProduc.Visible = false;
            this.GrupoBTN.Visible = true;
            this.btnInfoEmpresa.Enabled = true;
            this.btnInfoProducto.Enabled = true;
            this.btnInfoProveedor.Enabled = true;
            this.btnRecargar.Visible = false;

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (this.radioBTNEmpresa.Checked)
            {
                this.tablaDatos.DataSource = "";
                Empresaa();
            }
            if (this.radioBTNProv.Checked)
            {
                this.tablaDatos.DataSource = "";
                Proveedorr();
            }
            if (this.radioBTNProduc.Checked)
            {
                this.tablaDatos.DataSource = "";
                Productoo();
            }
        }

        void CambiosMod()
        {
            this.label2.ForeColor = Color.White;
            this.button2.Enabled = true;
            this.button2.ForeColor = Color.Black;
            this.button2.BackColor = Color.White;

            this.Modificar.Enabled = false;
            this.Modificar.BackColor = Color.Gray;
            this.Modificar.ForeColor = Color.Silver;
            this.Eliminar.Enabled = false;
            this.Eliminar.BackColor = Color.Gray;
            this.Eliminar.ForeColor = Color.Silver;
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (this.radioBTNEmpresa.Checked)
            {
                this.BoxEmpresa.Enabled = true;
                CambiosMod();
            }
            if (this.radioBTNProv.Checked)
            {
                this.BoxProveedor.Enabled = true;
                CambiosMod();
            }
            if (this.radioBTNProduc.Checked)
            {
                this.BoxProducto.Enabled = true;
                CambiosMod();
            }
            
        }

        void verificarBox()
        {
            this.button2.Enabled = false;
            this.button2.BackColor = Color.Gray;
            this.button2.ForeColor = Color.Silver;
            this.label2.ForeColor = Color.Gray;
            if (this.BoxEmpresa.Text == "FechaRegistro" || this.BoxProveedor.Text == "FechaRegistro" || this.BoxProducto.Text == "FechaEntrega")
            {
                this.textCambio.Visible = false;
                this.maskedFecha.Visible = true;
            }
            if (this.BoxEmpresa.Text == "Telefono" || this.BoxProveedor.Text == "Telefono")
            {
                this.textCambio.Visible = false;
                this.maskedTelef.Visible = true;
            }

            this.Guardar.Enabled = true;
            this.Guardar.ForeColor = Color.Black;
            this.Guardar.BackColor = Color.White;

            this.label3.ForeColor = Color.White;
            this.textCambio.Enabled = true;
            this.textCambio.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.radioBTNEmpresa.Checked)
            {
                if (this.BoxEmpresa.Text != "")
                {
                    this.BoxEmpresa.Enabled = false;
                    verificarBox();
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion");
                }
            }
            if (this.radioBTNProv.Checked)
            {
                if (this.BoxProveedor.Text != "")
                {
                    this.BoxProveedor.Enabled = false;
                    verificarBox();
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion");
                }
            }
            if (this.radioBTNProduc.Checked)
            {
                if (this.BoxProducto.Text != "")
                {
                    this.BoxProducto.Enabled = false;
                    verificarBox();
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion");
                }
            }
        }

        void CambiosGuardar()
        {
            if (this.textCambio.Visible == true)
            {
                this.textCambio.Text = "";
            } else if (this.maskedFecha.Visible == true)
            {
                this.maskedFecha.Text = "";
                this.maskedFecha.Visible = false;
                this.textCambio.Visible = true;
            } else if (this.maskedTelef.Visible == true)
            {
                this.maskedTelef.Text = "";
                this.maskedTelef.Visible = false;
                this.textCambio.Visible = true;
            }

            this.Guardar.Enabled = false;
            this.Guardar.ForeColor = Color.Silver;
            this.Guardar.BackColor = Color.Gray;

            this.Finalizar.Enabled = true;
            this.Finalizar.BackColor = Color.White;
            this.Finalizar.ForeColor = Color.Black;
            this.label3.ForeColor = Color.Gray;
            this.textCambio.BackColor = Color.Gray;
            this.textCambio.Enabled = false;

            this.GrupoPreguntar.Enabled = true;
            this.labelAct.BackColor = Color.White;
            this.labelAct.ForeColor = Color.Black;
            this.textNombreXD.BackColor = Color.White;
            this.textNombreXD.ForeColor = Color.Black;
            this.textNombreXD.Text = "";
            this.button3.BackColor = Color.White;
            this.button3.ForeColor = Color.Black;
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (this.radioBTNEmpresa.Checked)
            {
                try
                {
                    pedirPE.inicioConec();
                    if(this.textCambio.Visible == true)
                    {
                        query = "UPDATE DatosEmpresaProveedora SET " + this.BoxEmpresa.Text + " = '" + this.textCambio.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }else if(this.maskedFecha.Visible == true)
                    {
                        query = "UPDATE DatosEmpresaProveedora SET " + this.BoxEmpresa.Text + " = '" + this.maskedFecha.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }else if(this.maskedTelef.Visible == true)
                    {
                        query = "UPDATE DatosEmpresaProveedora SET " + this.BoxEmpresa.Text + " = '" + this.maskedTelef.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }
                    
                    SqlCommand cmdNomEmpre = new SqlCommand(query, pedirPE.conectar);
                    cmdNomEmpre.ExecuteNonQuery();
                    pedirPE.inicioDeconec();

                    MessageBox.Show("Datos Guardados Con Exito");
                    this.BoxEmpresa.SelectedIndex = 0;

                    CambiosGuardar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            if (this.radioBTNProv.Checked)
            {
                try
                {
                    pedirPE.inicioConec();
                    if (this.textCambio.Visible == true)
                    {
                        query = "UPDATE DatosProveedor SET " + this.BoxProveedor.Text + " = '" + this.textCambio.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }
                    else if (this.maskedFecha.Visible == true)
                    {
                        query = "UPDATE DatosProveedor SET " + this.BoxProveedor.Text + " = '" + this.maskedFecha.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }
                    else if (this.maskedTelef.Visible == true)
                    {
                        query = "UPDATE DatosProveedor SET " + this.BoxProveedor.Text + " = '" + this.maskedTelef.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }

                    SqlCommand cmdNomEmpre = new SqlCommand(query, pedirPE.conectar);
                    cmdNomEmpre.ExecuteNonQuery();
                    pedirPE.inicioDeconec();

                    MessageBox.Show("Datos Guardados Con Exito");

                    BoxProveedor.SelectedIndex = 0;

                    CambiosGuardar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            if (this.radioBTNProduc.Checked)
            {
                try
                {
                    pedirPE.inicioConec();
                    if (this.textCambio.Visible == true)
                    {
                        query = "UPDATE DatosProducto SET " + this.BoxProducto.Text + " = '" + this.textCambio.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }
                    else if (this.maskedFecha.Visible == true)
                    {
                        query = "UPDATE DatosProducto SET " + this.BoxProducto.Text + " = '" + this.maskedFecha.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }
                    else if (this.maskedTelef.Visible == true)
                    {
                        query = "UPDATE DatosProducto SET " + this.BoxProducto.Text + " = '" + this.maskedTelef.Text + "' where Codigo = '" + this.textNombreXD.Text + "'";
                    }

                    SqlCommand cmdNomEmpre = new SqlCommand(query, pedirPE.conectar);
                    cmdNomEmpre.ExecuteNonQuery();
                    pedirPE.inicioDeconec();

                    MessageBox.Show("Datos Guardados Con Exito");

                    BoxProducto.SelectedIndex = 0;

                    CambiosGuardar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        void CambiosEliminar()
        {
            this.Eliminar.Enabled = false;
            this.Eliminar.ForeColor = Color.Silver;
            this.Eliminar.BackColor = Color.Gray;

            this.Modificar.Enabled = false;
            this.Modificar.ForeColor = Color.Silver;
            this.Modificar.BackColor = Color.Gray;

            this.Finalizar.Enabled = true;
            this.Finalizar.BackColor = Color.White;
            this.Finalizar.ForeColor = Color.Black;

            this.GrupoPreguntar.Enabled = true;
            this.labelAct.BackColor = Color.White;
            this.labelAct.ForeColor = Color.Black;
            this.textNombreXD.BackColor = Color.White;
            this.textNombreXD.ForeColor = Color.Black;
            this.textNombreXD.Text = "";
            this.button3.BackColor = Color.White;
            this.button3.ForeColor = Color.Black;
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (this.radioBTNEmpresa.Checked)
            {
                bool validar1 = false;
                string nombre = this.textNombreXD.Text;

                validar1 = Actualiza.EliminarEmpresa(nombre);
                if(validar1 == true)
                {
                    MessageBox.Show("Se a eliminado con exito");
                    CambiosEliminar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                } 
            }
            if (this.radioBTNProv.Checked)
            {
                bool validar1 = false;
                string nombre = this.textNombreXD.Text;

                validar1 = Actualiza.EliminarProveedor(nombre);
                if (validar1 == true)
                {
                    MessageBox.Show("Se a eliminado con exito");
                    CambiosEliminar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            if (this.radioBTNProduc.Checked)
            {
                bool validar1 = false;
                string nombre = this.textNombreXD.Text;

                validar1 = Actualiza.EliminarProducto(nombre);
                if (validar1 == true)
                {
                    MessageBox.Show("Se a eliminado con exito");
                    CambiosEliminar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
        }
    }
}
