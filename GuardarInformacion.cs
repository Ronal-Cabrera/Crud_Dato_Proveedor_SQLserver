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
    public partial class GuardarInformacion : Form
    {
        public GuardarInformacion()
        {
            InitializeComponent();
        }

        GuardarDataProveedor Validar1 = new GuardarDataProveedor();
        GuardarDataEmpresa Validar2 = new GuardarDataEmpresa();
        GuardarDataProductos Validar3 = new GuardarDataProductos();

        void GenerarCodigo()
        {
            //Variables
            String CodigoF = "";
            string CodigoAle = "";
            bool CodigoValido = false;
            bool CodigoValidoSig = false;

            try
            {
                //Ciclo
                do
                {
                    Random NumR = new Random();
                    CodigoAle = NumR.Next(1000, 5000).ToString();

                    CodigoValido = Validar1.ValidandoCodigo(CodigoAle);
                    CodigoValidoSig = Validar2.ValidandoSigCodigo(CodigoAle);

                    if (CodigoValido == false && CodigoValidoSig == false)
                    {
                        CodigoF = CodigoAle;
                    }

                } while (CodigoValido == true || CodigoValidoSig == true);
                //
            }
            catch (Exception)
            {
                CodigoF = "0";
            }
            if(this.panelFom2.Visible == true)
            {
                this.textCodigoEmpresa1.Text = CodigoF;
            }
            if(this.panelFom1.Visible == true)
            {
                this.textCodigoP2.Text = CodigoF;
            }
            //return CodigoF;
        }
        void RegresarXD()
        {
            Menu Regresar = new Menu();
            this.Close();
            Regresar.Ver();
        }

        void Limpiar2()
        {
            this.textApellido2.Text = "";
            this.textCodigoP2.Text = "";
            this.textDirec2.Text = "";
            this.textNIT2.Text = "";
            this.textNom2.Text = "";
            this.textcorreo2.Text = "";
            this.maskedTel2.Text = "+(502)";
            this.maskedFecha2.Text = "";
            this.texto.Text = " ";
        }

        void Limpiar1()
        {
            this.textCategoria1.Text = "";
            this.textCodigoEmpresa1.Text = "";
            this.textCorreoEmpre1.Text = "";
            this.maskedFecha1.Text = "";
            this.textDirec1.Text = "";
            this.textNITempr1.Text = "";
            this.maskedTel1.Text = "+502";
            this.textNomEmpre1.Text = "";
            this.texto.Text = " ";
        }
        void Limpiar3()
        {
            this.textTipo3.Text = "";
            this.textArea3.Text = "";
            this.textCantidad3.Text = "";
            this.textCodigoP3.Text = "";
            this.textCosto3.Text = "";
            this.maskedFecha3.Text = "";
            this.textMarca3.Text = "";
            this.textNom3.Text = "";
            this.textPresen3.Text = "";
            this.textUbic3.Text = "";
            this.textID3.Text = "";
            this.texto.Text = " ";
            this.labelProveedor.Text = " ";
            this.Proveedor.Text = " ";
        }

        private void btnDatProv_Click(object sender, EventArgs e)
        {
            //Boton Registrar panelFom1 = Proveedor
            string Codigo2 = this.textCodigoP2.Text;
            string Nombre2 = this.textNom2.Text;
            string Apellido2 = this.textApellido2.Text;
            string Direccion2 = this.textDirec2.Text;
            string Nit2 = this.textNIT2.Text;
            string Correo2 = this.textcorreo2.Text;
            string Telefono2 = this.maskedTel2.Text;
            string Fecha2 = this.maskedFecha2.Text;
            bool resultado2 = false;

            if (this.textApellido2.Text != "" &&
            this.textCodigoP2.Text != "" &&
            this.textDirec2.Text != "" &&
            this.textNIT2.Text != "" &&
            this.textNom2.Text != "" &&
            this.textcorreo2.Text != "" &&
            this.maskedTel2.Text != "+(502)" &&
            this.maskedFecha2.Text != "")
            {
            resultado2 = Validar1.GuardarDataProveedor1(Codigo2, Nombre2, Apellido2, Direccion2, Nit2, Correo2, Telefono2, Fecha2);
                if (resultado2 == false)
                {
                    MessageBox.Show(" ERROR");
                }
                else
                {
                    MessageBox.Show("Datos Ingresados con exito.");
                    this.textCodigoP3.Text = Codigo2;
                    Limpiar2();
                    this.panelFom1.Visible = false;
                    this.panelFom3.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los Datos.");
            }
        }

        private void btnnRegresar2_Click(object sender, EventArgs e)
        {
            Limpiar2();
            this.panelFom1.Visible = false;
            RegresarXD();
        }

        public void Ver2()
        {
            this.Visible = true;
        }
   
        public void Empresa()
        {
            this.panelFom2.Visible = true;
            GenerarCodigo();
            this.texto.Text = "Datos de Empresa Proveedora";
        }

        public void Individual()
        {
            this.panelFom1.Visible = true;
            GenerarCodigo();
            this.texto.Text = "Datos de Proveedor Individual";
        }

        public void Producto()
        {
            this.panelFom3.Visible = true;
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            Limpiar1();
            this.panelFom2.Visible = false;
            RegresarXD();
        }

        private void btnDatEmp_Click(object sender, EventArgs e)
        {
            //Boton registrar panelFom1 = EmpresaProveedora
            string Codigo1 = this.textCodigoEmpresa1.Text;
            string Nombre1 = this.textNomEmpre1.Text;
            string Direccion1 = this.textDirec1.Text;
            string Correo1 = this.textCorreoEmpre1.Text;
            string Nit1 = this.textNITempr1.Text;
            string Categoria1 = this.textCategoria1.Text;
            string Telefono1 = this.maskedTel1.Text;
            string Fecha1 = this.maskedFecha1.Text;
            bool resultado3 = false;

            if (this.textCategoria1.Text != "" &&
            this.textCodigoEmpresa1.Text != "" &&
            this.textCorreoEmpre1.Text != "" &&
            this.maskedFecha1.Text != "" &&
            this.textDirec1.Text != "" &&
            this.textNITempr1.Text != "" &&
            this.maskedTel1.Text != "+502" &&
            this.textNomEmpre1.Text != "")
            {
                resultado3 = Validar2.GuardarDataProvEmpresa(Codigo1, Nombre1, Direccion1, Correo1, Nit1, Categoria1, Telefono1, Fecha1);
                if (resultado3 == false)
                {
                    MessageBox.Show(" ERROR");
                }
                else
                {
                    MessageBox.Show("Datos Ingresados con exito.");
                    this.textCodigoP3.Text = Codigo1;
                    Limpiar1();
                    this.panelFom2.Visible = false;
                    this.panelFom3.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los Datos.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Limpiar3();
            this.panelFom3.Visible = false;
            RegresarXD();
        }

        private void btnRegistrar3_Click(object sender, EventArgs e)
        {
            //boton registrar panelFom3 = Productos
            string Tipo3 = this.textTipo3.Text;
            string Area3 = this.textArea3.Text;
            string Cantidad3 = this.textCantidad3.Text;
            string Codigo3 = this.textCodigoP3.Text;
            string Costo3 = this.textCosto3.Text;
            string Fecha3 = this.maskedFecha3.Text;
            string Marca3 = this.textMarca3.Text;
            string Nombre3 = this.textNom3.Text;
            string Presentacion3 = this.textPresen3.Text;
            string Ubicacion3 = this.textUbic3.Text;
            string Id3 = this.textID3.Text;
            bool resultado1 = false;

            if (this.textTipo3.Text != "" &&
            this.textArea3.Text != "" &&
            this.textCantidad3.Text != "" &&
            this.textCodigoP3.Text != "" &&
            this.textCosto3.Text != "" &&
            this.maskedFecha3.Text != "" &&
            this.textMarca3.Text != "" &&
            this.textNom3.Text != "" &&
            this.textPresen3.Text != "" &&
            this.textUbic3.Text != "" &&
            this.textID3.Text != "")
            {
                resultado1 = Validar3.GuardarDataProducto(Tipo3, Area3, Cantidad3, Codigo3, Costo3, Fecha3, Marca3, Nombre3, Presentacion3, Id3, Ubicacion3);
                if (resultado1 == false)
                {
                    MessageBox.Show(" ERROR");
                }
                else
                {
                    MessageBox.Show("Datos Ingresados con exito.");
                    Limpiar3();
                    this.panelFom3.Visible = false;
                    RegresarXD();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los Datos.");
            }
        }

        public bool Validar01(string ValidarNombre)
        {
            bool boleano = false;
            string resNomProv = "";
            resNomProv = Validar1.ValidarNomProveedor(ValidarNombre);
            if (resNomProv != "error")
            {
                boleano = true;
                this.texto.Text = "Datos del Producto";
                this.labelProveedor.Text = "Proveedor:";
                this.Proveedor.Text = ValidarNombre;
                this.textCodigoP3.Text = resNomProv;
            }
            else
            {
                boleano = false;
            }
            return boleano;
        }

        public bool Validar02(string ValidarNombre)
        {
            bool boleano = false;
            string  resNomEmpresa = "";
            resNomEmpresa = Validar2.ValidarNomEmpresaPP(ValidarNombre);
            if (resNomEmpresa != "error")
            {
                boleano = true;
                this.texto.Text = "Datos del Producto";
                this.labelProveedor.Text = "Proveedor:";
                this.Proveedor.Text = ValidarNombre;
                this.textCodigoP3.Text = resNomEmpresa;
            }
            else
            {
                boleano = false;
            }
            return boleano;
        }
    }
}
