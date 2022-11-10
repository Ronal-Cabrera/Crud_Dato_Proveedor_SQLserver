
namespace proyecto_final
{
    partial class ActualizarBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarBuscar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.labelInfoBTN = new System.Windows.Forms.Label();
            this.radioBTNProduc = new System.Windows.Forms.RadioButton();
            this.radioBTNProv = new System.Windows.Forms.RadioButton();
            this.radioBTNEmpresa = new System.Windows.Forms.RadioButton();
            this.GrupoBTN = new System.Windows.Forms.Panel();
            this.btnInfoEmpresa = new System.Windows.Forms.Button();
            this.btnInfoProducto = new System.Windows.Forms.Button();
            this.btnInfoProveedor = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.btnRegresarAB = new System.Windows.Forms.Button();
            this.panelActualizaion = new System.Windows.Forms.Panel();
            this.GrupoPreguntar = new System.Windows.Forms.GroupBox();
            this.textNombreXD = new System.Windows.Forms.TextBox();
            this.labelAct = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ModificarInfo = new System.Windows.Forms.GroupBox();
            this.textCambio = new System.Windows.Forms.TextBox();
            this.maskedTelef = new System.Windows.Forms.MaskedTextBox();
            this.maskedFecha = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxProducto = new System.Windows.Forms.ComboBox();
            this.BoxEmpresa = new System.Windows.Forms.ComboBox();
            this.BoxProveedor = new System.Windows.Forms.ComboBox();
            this.Finalizar = new System.Windows.Forms.Button();
            this.labelActualizacion = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GrupoBTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.panelActualizaion.SuspendLayout();
            this.GrupoPreguntar.SuspendLayout();
            this.ModificarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 415);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRecargar);
            this.panel2.Controls.Add(this.labelInfoBTN);
            this.panel2.Controls.Add(this.radioBTNProduc);
            this.panel2.Controls.Add(this.radioBTNProv);
            this.panel2.Controls.Add(this.radioBTNEmpresa);
            this.panel2.Controls.Add(this.GrupoBTN);
            this.panel2.Controls.Add(this.tablaDatos);
            this.panel2.Controls.Add(this.btnRegresarAB);
            this.panel2.Location = new System.Drawing.Point(21, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 369);
            this.panel2.TabIndex = 0;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(18, 323);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(400, 33);
            this.btnRecargar.TabIndex = 22;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Visible = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // labelInfoBTN
            // 
            this.labelInfoBTN.AutoSize = true;
            this.labelInfoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoBTN.Location = new System.Drawing.Point(445, 21);
            this.labelInfoBTN.Name = "labelInfoBTN";
            this.labelInfoBTN.Size = new System.Drawing.Size(34, 24);
            this.labelInfoBTN.TabIndex = 21;
            this.labelInfoBTN.Text = "    ";
            // 
            // radioBTNProduc
            // 
            this.radioBTNProduc.AutoSize = true;
            this.radioBTNProduc.BackColor = System.Drawing.Color.Transparent;
            this.radioBTNProduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBTNProduc.Location = new System.Drawing.Point(1009, 326);
            this.radioBTNProduc.Name = "radioBTNProduc";
            this.radioBTNProduc.Size = new System.Drawing.Size(119, 28);
            this.radioBTNProduc.TabIndex = 20;
            this.radioBTNProduc.Text = "Actualizar";
            this.radioBTNProduc.UseVisualStyleBackColor = false;
            this.radioBTNProduc.Visible = false;
            this.radioBTNProduc.CheckedChanged += new System.EventHandler(this.radioBTNProduc_CheckedChanged);
            // 
            // radioBTNProv
            // 
            this.radioBTNProv.AutoSize = true;
            this.radioBTNProv.BackColor = System.Drawing.Color.Transparent;
            this.radioBTNProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBTNProv.Location = new System.Drawing.Point(1011, 326);
            this.radioBTNProv.Name = "radioBTNProv";
            this.radioBTNProv.Size = new System.Drawing.Size(119, 28);
            this.radioBTNProv.TabIndex = 19;
            this.radioBTNProv.Text = "Actualizar";
            this.radioBTNProv.UseVisualStyleBackColor = false;
            this.radioBTNProv.Visible = false;
            this.radioBTNProv.CheckedChanged += new System.EventHandler(this.radioBTNProv_CheckedChanged);
            // 
            // radioBTNEmpresa
            // 
            this.radioBTNEmpresa.AutoSize = true;
            this.radioBTNEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.radioBTNEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBTNEmpresa.ForeColor = System.Drawing.Color.Black;
            this.radioBTNEmpresa.Location = new System.Drawing.Point(1011, 326);
            this.radioBTNEmpresa.Name = "radioBTNEmpresa";
            this.radioBTNEmpresa.Size = new System.Drawing.Size(119, 28);
            this.radioBTNEmpresa.TabIndex = 18;
            this.radioBTNEmpresa.Text = "Actualizar";
            this.radioBTNEmpresa.UseVisualStyleBackColor = false;
            this.radioBTNEmpresa.Visible = false;
            this.radioBTNEmpresa.CheckedChanged += new System.EventHandler(this.radioBTNEmpresa_CheckedChanged);
            // 
            // GrupoBTN
            // 
            this.GrupoBTN.BackColor = System.Drawing.Color.Gray;
            this.GrupoBTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrupoBTN.Controls.Add(this.btnInfoEmpresa);
            this.GrupoBTN.Controls.Add(this.btnInfoProducto);
            this.GrupoBTN.Controls.Add(this.btnInfoProveedor);
            this.GrupoBTN.Location = new System.Drawing.Point(18, 21);
            this.GrupoBTN.Name = "GrupoBTN";
            this.GrupoBTN.Size = new System.Drawing.Size(400, 332);
            this.GrupoBTN.TabIndex = 7;
            // 
            // btnInfoEmpresa
            // 
            this.btnInfoEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInfoEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInfoEmpresa.Location = new System.Drawing.Point(18, 36);
            this.btnInfoEmpresa.Name = "btnInfoEmpresa";
            this.btnInfoEmpresa.Size = new System.Drawing.Size(365, 80);
            this.btnInfoEmpresa.TabIndex = 2;
            this.btnInfoEmpresa.Text = "Información Empresa";
            this.btnInfoEmpresa.UseVisualStyleBackColor = false;
            this.btnInfoEmpresa.Click += new System.EventHandler(this.btnInfoEmpresa_Click);
            // 
            // btnInfoProducto
            // 
            this.btnInfoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInfoProducto.Location = new System.Drawing.Point(18, 213);
            this.btnInfoProducto.Name = "btnInfoProducto";
            this.btnInfoProducto.Size = new System.Drawing.Size(365, 80);
            this.btnInfoProducto.TabIndex = 4;
            this.btnInfoProducto.Text = "Información Producto";
            this.btnInfoProducto.UseVisualStyleBackColor = false;
            this.btnInfoProducto.Click += new System.EventHandler(this.btnInfoProducto_Click);
            // 
            // btnInfoProveedor
            // 
            this.btnInfoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInfoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInfoProveedor.Location = new System.Drawing.Point(18, 124);
            this.btnInfoProveedor.Name = "btnInfoProveedor";
            this.btnInfoProveedor.Size = new System.Drawing.Size(365, 80);
            this.btnInfoProveedor.TabIndex = 3;
            this.btnInfoProveedor.Text = "Información Proveedor";
            this.btnInfoProveedor.UseVisualStyleBackColor = false;
            this.btnInfoProveedor.Click += new System.EventHandler(this.btnInfoProveedor_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.AllowUserToAddRows = false;
            this.tablaDatos.AllowUserToDeleteRows = false;
            this.tablaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.White;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Location = new System.Drawing.Point(450, 48);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.ReadOnly = true;
            this.tablaDatos.Size = new System.Drawing.Size(680, 272);
            this.tablaDatos.TabIndex = 1;
            // 
            // btnRegresarAB
            // 
            this.btnRegresarAB.BackColor = System.Drawing.Color.Gray;
            this.btnRegresarAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarAB.Location = new System.Drawing.Point(449, 326);
            this.btnRegresarAB.Name = "btnRegresarAB";
            this.btnRegresarAB.Size = new System.Drawing.Size(119, 28);
            this.btnRegresarAB.TabIndex = 4;
            this.btnRegresarAB.Text = "Regresar";
            this.btnRegresarAB.UseVisualStyleBackColor = false;
            this.btnRegresarAB.Visible = false;
            this.btnRegresarAB.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelActualizaion
            // 
            this.panelActualizaion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActualizaion.Controls.Add(this.GrupoPreguntar);
            this.panelActualizaion.Controls.Add(this.ModificarInfo);
            this.panelActualizaion.Controls.Add(this.Finalizar);
            this.panelActualizaion.Controls.Add(this.labelActualizacion);
            this.panelActualizaion.Controls.Add(this.Guardar);
            this.panelActualizaion.Controls.Add(this.Eliminar);
            this.panelActualizaion.Controls.Add(this.Modificar);
            this.panelActualizaion.Location = new System.Drawing.Point(494, 12);
            this.panelActualizaion.Name = "panelActualizaion";
            this.panelActualizaion.Size = new System.Drawing.Size(725, 415);
            this.panelActualizaion.TabIndex = 1;
            this.panelActualizaion.Visible = false;
            // 
            // GrupoPreguntar
            // 
            this.GrupoPreguntar.Controls.Add(this.textNombreXD);
            this.GrupoPreguntar.Controls.Add(this.labelAct);
            this.GrupoPreguntar.Controls.Add(this.button3);
            this.GrupoPreguntar.Location = new System.Drawing.Point(34, 29);
            this.GrupoPreguntar.Name = "GrupoPreguntar";
            this.GrupoPreguntar.Size = new System.Drawing.Size(657, 100);
            this.GrupoPreguntar.TabIndex = 21;
            this.GrupoPreguntar.TabStop = false;
            // 
            // textNombreXD
            // 
            this.textNombreXD.BackColor = System.Drawing.Color.White;
            this.textNombreXD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreXD.ForeColor = System.Drawing.Color.Black;
            this.textNombreXD.Location = new System.Drawing.Point(124, 44);
            this.textNombreXD.Name = "textNombreXD";
            this.textNombreXD.Size = new System.Drawing.Size(296, 26);
            this.textNombreXD.TabIndex = 7;
            // 
            // labelAct
            // 
            this.labelAct.BackColor = System.Drawing.Color.White;
            this.labelAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAct.ForeColor = System.Drawing.Color.Black;
            this.labelAct.Location = new System.Drawing.Point(34, 44);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(85, 26);
            this.labelAct.TabIndex = 6;
            this.labelAct.Text = "Codigo";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(425, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ModificarInfo
            // 
            this.ModificarInfo.Controls.Add(this.textCambio);
            this.ModificarInfo.Controls.Add(this.maskedTelef);
            this.ModificarInfo.Controls.Add(this.maskedFecha);
            this.ModificarInfo.Controls.Add(this.button2);
            this.ModificarInfo.Controls.Add(this.label2);
            this.ModificarInfo.Controls.Add(this.label3);
            this.ModificarInfo.Controls.Add(this.BoxProducto);
            this.ModificarInfo.Controls.Add(this.BoxEmpresa);
            this.ModificarInfo.Controls.Add(this.BoxProveedor);
            this.ModificarInfo.Location = new System.Drawing.Point(34, 141);
            this.ModificarInfo.Name = "ModificarInfo";
            this.ModificarInfo.Size = new System.Drawing.Size(657, 199);
            this.ModificarInfo.TabIndex = 20;
            this.ModificarInfo.TabStop = false;
            // 
            // textCambio
            // 
            this.textCambio.BackColor = System.Drawing.Color.Gray;
            this.textCambio.Enabled = false;
            this.textCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCambio.Location = new System.Drawing.Point(123, 142);
            this.textCambio.Name = "textCambio";
            this.textCambio.Size = new System.Drawing.Size(295, 26);
            this.textCambio.TabIndex = 19;
            // 
            // maskedTelef
            // 
            this.maskedTelef.BackColor = System.Drawing.Color.White;
            this.maskedTelef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTelef.Location = new System.Drawing.Point(123, 142);
            this.maskedTelef.Mask = "#(999) 0000 - 0000";
            this.maskedTelef.Name = "maskedTelef";
            this.maskedTelef.PromptChar = '-';
            this.maskedTelef.Size = new System.Drawing.Size(295, 26);
            this.maskedTelef.TabIndex = 18;
            this.maskedTelef.Text = "+502";
            this.maskedTelef.Visible = false;
            // 
            // maskedFecha
            // 
            this.maskedFecha.BackColor = System.Drawing.Color.White;
            this.maskedFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedFecha.Location = new System.Drawing.Point(123, 142);
            this.maskedFecha.Mask = " 00 / 00 / 0000";
            this.maskedFecha.Name = "maskedFecha";
            this.maskedFecha.Size = new System.Drawing.Size(295, 26);
            this.maskedFecha.TabIndex = 17;
            this.maskedFecha.ValidatingType = typeof(System.DateTime);
            this.maskedFecha.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(425, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Informacion a modificar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresar Cambio:";
            // 
            // BoxProducto
            // 
            this.BoxProducto.BackColor = System.Drawing.Color.White;
            this.BoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxProducto.Enabled = false;
            this.BoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxProducto.ForeColor = System.Drawing.Color.Black;
            this.BoxProducto.FormattingEnabled = true;
            this.BoxProducto.Items.AddRange(new object[] {
            "",
            "NombreProducto",
            "Cantidad",
            "Marca",
            "Precentacion",
            "Ubicacion",
            "Area ",
            "Tipo",
            "FechaEntrega",
            "Costo",
            "Id"});
            this.BoxProducto.Location = new System.Drawing.Point(123, 64);
            this.BoxProducto.Name = "BoxProducto";
            this.BoxProducto.Size = new System.Drawing.Size(295, 28);
            this.BoxProducto.TabIndex = 15;
            this.BoxProducto.Visible = false;
            // 
            // BoxEmpresa
            // 
            this.BoxEmpresa.BackColor = System.Drawing.Color.White;
            this.BoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxEmpresa.Enabled = false;
            this.BoxEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmpresa.ForeColor = System.Drawing.Color.Black;
            this.BoxEmpresa.FormattingEnabled = true;
            this.BoxEmpresa.Items.AddRange(new object[] {
            "",
            "Nombre",
            "Direccion",
            "Correo",
            "NIT",
            "Categoria",
            "FechaRegistro",
            "Telefono"});
            this.BoxEmpresa.Location = new System.Drawing.Point(124, 64);
            this.BoxEmpresa.Name = "BoxEmpresa";
            this.BoxEmpresa.Size = new System.Drawing.Size(294, 28);
            this.BoxEmpresa.TabIndex = 14;
            this.BoxEmpresa.Visible = false;
            // 
            // BoxProveedor
            // 
            this.BoxProveedor.BackColor = System.Drawing.Color.White;
            this.BoxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxProveedor.Enabled = false;
            this.BoxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxProveedor.ForeColor = System.Drawing.Color.Black;
            this.BoxProveedor.FormattingEnabled = true;
            this.BoxProveedor.Items.AddRange(new object[] {
            "",
            "Nombre",
            "Apellido",
            "Direccion",
            "FechaRegistro",
            "NIT",
            "Correo",
            "Telefono"});
            this.BoxProveedor.Location = new System.Drawing.Point(123, 64);
            this.BoxProveedor.Name = "BoxProveedor";
            this.BoxProveedor.Size = new System.Drawing.Size(295, 28);
            this.BoxProveedor.TabIndex = 10;
            this.BoxProveedor.Visible = false;
            // 
            // Finalizar
            // 
            this.Finalizar.BackColor = System.Drawing.Color.White;
            this.Finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finalizar.ForeColor = System.Drawing.Color.Black;
            this.Finalizar.Location = new System.Drawing.Point(587, 366);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(104, 36);
            this.Finalizar.TabIndex = 19;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = false;
            this.Finalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelActualizacion
            // 
            this.labelActualizacion.AutoSize = true;
            this.labelActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizacion.Location = new System.Drawing.Point(34, 7);
            this.labelActualizacion.Name = "labelActualizacion";
            this.labelActualizacion.Size = new System.Drawing.Size(28, 24);
            this.labelActualizacion.TabIndex = 18;
            this.labelActualizacion.Text = "   ";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.Gray;
            this.Guardar.Enabled = false;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.Color.Silver;
            this.Guardar.Location = new System.Drawing.Point(317, 366);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(135, 36);
            this.Guardar.TabIndex = 16;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Gray;
            this.Eliminar.Enabled = false;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.Silver;
            this.Eliminar.Location = new System.Drawing.Point(173, 366);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(127, 36);
            this.Eliminar.TabIndex = 15;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.Gray;
            this.Modificar.Enabled = false;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.Color.Silver;
            this.Modificar.Location = new System.Drawing.Point(34, 366);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(123, 36);
            this.Modificar.TabIndex = 8;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // ActualizarBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1233, 439);
            this.Controls.Add(this.panelActualizaion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActualizarBuscar";
            this.Text = "Buscar y Actualizar Informacion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GrupoBTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.panelActualizaion.ResumeLayout(false);
            this.panelActualizaion.PerformLayout();
            this.GrupoPreguntar.ResumeLayout(false);
            this.GrupoPreguntar.PerformLayout();
            this.ModificarInfo.ResumeLayout(false);
            this.ModificarInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInfoProducto;
        private System.Windows.Forms.Button btnInfoProveedor;
        private System.Windows.Forms.Button btnInfoEmpresa;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnRegresarAB;
        private System.Windows.Forms.Panel GrupoBTN;
        private System.Windows.Forms.Panel panelActualizaion;
        private System.Windows.Forms.TextBox textNombreXD;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BoxProveedor;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.ComboBox BoxProducto;
        private System.Windows.Forms.ComboBox BoxEmpresa;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.RadioButton radioBTNProduc;
        private System.Windows.Forms.RadioButton radioBTNProv;
        private System.Windows.Forms.RadioButton radioBTNEmpresa;
        private System.Windows.Forms.Label labelActualizacion;
        private System.Windows.Forms.Label labelInfoBTN;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.GroupBox ModificarInfo;
        private System.Windows.Forms.GroupBox GrupoPreguntar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedFecha;
        private System.Windows.Forms.MaskedTextBox maskedTelef;
        private System.Windows.Forms.TextBox textCambio;
    }
}