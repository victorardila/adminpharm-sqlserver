
namespace Presentacion
{
    partial class FormFacturaDeProducto
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
            this.menuTop = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.dataGridFacturaProductos = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenciaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirFactura = new FontAwesome.Sharp.IconButton();
            this.labelTitleFactura = new System.Windows.Forms.Label();
            this.labelPago = new System.Windows.Forms.Label();
            this.labelVueltos = new System.Windows.Forms.Label();
            this.labelVueltosGenerado = new System.Windows.Forms.Label();
            this.labelTotalFactura = new System.Windows.Forms.Label();
            this.labelTotalFacturaGenerada = new System.Windows.Forms.Label();
            this.labelTextFondo = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.iconCash = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTotalesFactura = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFormaDePago = new System.Windows.Forms.ComboBox();
            this.textPago = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdvertenciaCliente = new System.Windows.Forms.Label();
            this.btnCloseCliente = new FontAwesome.Sharp.IconPictureBox();
            this.textSearchCliente = new System.Windows.Forms.TextBox();
            this.btnSearchCliente = new FontAwesome.Sharp.IconPictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textIdentificacionEmpleado = new System.Windows.Forms.TextBox();
            this.labelIdentificacionEmpleado = new System.Windows.Forms.Label();
            this.textApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.labelApellidoEmpleado = new System.Windows.Forms.Label();
            this.textNombreEmpleado = new System.Windows.Forms.TextBox();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelAdvertenciaEmpleado = new System.Windows.Forms.Label();
            this.btnCloseEmpleado = new FontAwesome.Sharp.IconPictureBox();
            this.textSearchEmpleado = new System.Windows.Forms.TextBox();
            this.btnSearchEmpleado = new FontAwesome.Sharp.IconPictureBox();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelIdFactura = new System.Windows.Forms.Label();
            this.labelIdGeneradoDeFactura = new System.Windows.Forms.Label();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.labelIdentificacionCliente = new System.Windows.Forms.Label();
            this.labelApellidoCliente = new System.Windows.Forms.Label();
            this.textApellidoCliente = new System.Windows.Forms.TextBox();
            this.labelTipoDeId = new System.Windows.Forms.Label();
            this.comboTipoDeId = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.dateTimeFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.panelFactura = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).BeginInit();
            this.panelTotalesFactura.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCliente)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEmpleado)).BeginInit();
            this.panelFactura.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.menuTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuTop.Controls.Add(this.btnCerrar);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(643, 26);
            this.menuTop.TabIndex = 5;
            this.menuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuTop_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(615, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridFacturaProductos
            // 
            this.dataGridFacturaProductos.AllowUserToAddRows = false;
            this.dataGridFacturaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFacturaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.ReferenciaP,
            this.Nombre,
            this.Detalle,
            this.Precio});
            this.dataGridFacturaProductos.Location = new System.Drawing.Point(2, 231);
            this.dataGridFacturaProductos.Name = "dataGridFacturaProductos";
            this.dataGridFacturaProductos.RowHeadersVisible = false;
            this.dataGridFacturaProductos.Size = new System.Drawing.Size(617, 140);
            this.dataGridFacturaProductos.TabIndex = 6;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 60;
            // 
            // ReferenciaP
            // 
            this.ReferenciaP.HeaderText = "Referencia";
            this.ReferenciaP.Name = "ReferenciaP";
            this.ReferenciaP.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 140;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 190;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 118;
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnImprimirFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimirFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimirFactura.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirFactura.IconColor = System.Drawing.Color.Black;
            this.btnImprimirFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirFactura.IconSize = 30;
            this.btnImprimirFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFactura.Location = new System.Drawing.Point(238, 481);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(151, 35);
            this.btnImprimirFactura.TabIndex = 60;
            this.btnImprimirFactura.Text = "   Imprimir Factura";
            this.btnImprimirFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // labelTitleFactura
            // 
            this.labelTitleFactura.AutoSize = true;
            this.labelTitleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.labelTitleFactura.Location = new System.Drawing.Point(22, 36);
            this.labelTitleFactura.Name = "labelTitleFactura";
            this.labelTitleFactura.Size = new System.Drawing.Size(260, 29);
            this.labelTitleFactura.TabIndex = 61;
            this.labelTitleFactura.Text = "Factura de productos";
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPago.Location = new System.Drawing.Point(161, 2);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(65, 20);
            this.labelPago.TabIndex = 62;
            this.labelPago.Text = "Pago $";
            // 
            // labelVueltos
            // 
            this.labelVueltos.AutoSize = true;
            this.labelVueltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVueltos.ForeColor = System.Drawing.Color.DarkRed;
            this.labelVueltos.Location = new System.Drawing.Point(326, 1);
            this.labelVueltos.Name = "labelVueltos";
            this.labelVueltos.Size = new System.Drawing.Size(85, 20);
            this.labelVueltos.TabIndex = 63;
            this.labelVueltos.Text = "Vueltos $";
            // 
            // labelVueltosGenerado
            // 
            this.labelVueltosGenerado.AutoSize = true;
            this.labelVueltosGenerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVueltosGenerado.ForeColor = System.Drawing.Color.DarkRed;
            this.labelVueltosGenerado.Location = new System.Drawing.Point(408, 2);
            this.labelVueltosGenerado.Name = "labelVueltosGenerado";
            this.labelVueltosGenerado.Size = new System.Drawing.Size(40, 18);
            this.labelVueltosGenerado.TabIndex = 65;
            this.labelVueltosGenerado.Text = "0.00";
            // 
            // labelTotalFactura
            // 
            this.labelTotalFactura.AutoSize = true;
            this.labelTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFactura.ForeColor = System.Drawing.Color.White;
            this.labelTotalFactura.Location = new System.Drawing.Point(-4, 2);
            this.labelTotalFactura.Name = "labelTotalFactura";
            this.labelTotalFactura.Size = new System.Drawing.Size(126, 20);
            this.labelTotalFactura.TabIndex = 66;
            this.labelTotalFactura.Text = "Total factura $";
            // 
            // labelTotalFacturaGenerada
            // 
            this.labelTotalFacturaGenerada.AutoSize = true;
            this.labelTotalFacturaGenerada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFacturaGenerada.ForeColor = System.Drawing.Color.White;
            this.labelTotalFacturaGenerada.Location = new System.Drawing.Point(118, 2);
            this.labelTotalFacturaGenerada.Name = "labelTotalFacturaGenerada";
            this.labelTotalFacturaGenerada.Size = new System.Drawing.Size(40, 18);
            this.labelTotalFacturaGenerada.TabIndex = 67;
            this.labelTotalFacturaGenerada.Text = "0.00";
            // 
            // labelTextFondo
            // 
            this.labelTextFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextFondo.AutoSize = true;
            this.labelTextFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFondo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTextFondo.Location = new System.Drawing.Point(559, 30);
            this.labelTextFondo.Name = "labelTextFondo";
            this.labelTextFondo.Size = new System.Drawing.Size(45, 12);
            this.labelTextFondo.TabIndex = 70;
            this.labelTextFondo.Text = "MONTO";
            // 
            // labelCash
            // 
            this.labelCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCash.Location = new System.Drawing.Point(559, 46);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(36, 16);
            this.labelCash.TabIndex = 69;
            this.labelCash.Text = "0.00";
            // 
            // iconCash
            // 
            this.iconCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCash.BackColor = System.Drawing.SystemColors.Control;
            this.iconCash.ForeColor = System.Drawing.Color.Olive;
            this.iconCash.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconCash.IconColor = System.Drawing.Color.Olive;
            this.iconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCash.Location = new System.Drawing.Point(525, 33);
            this.iconCash.Name = "iconCash";
            this.iconCash.Size = new System.Drawing.Size(32, 32);
            this.iconCash.TabIndex = 68;
            this.iconCash.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Lista de Productos";
            // 
            // panelTotalesFactura
            // 
            this.panelTotalesFactura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTotalesFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalesFactura.Controls.Add(this.label1);
            this.panelTotalesFactura.Controls.Add(this.comboFormaDePago);
            this.panelTotalesFactura.Controls.Add(this.textPago);
            this.panelTotalesFactura.Controls.Add(this.labelTotalFactura);
            this.panelTotalesFactura.Controls.Add(this.labelTotalFacturaGenerada);
            this.panelTotalesFactura.Controls.Add(this.labelPago);
            this.panelTotalesFactura.Controls.Add(this.labelVueltos);
            this.panelTotalesFactura.Controls.Add(this.labelVueltosGenerado);
            this.panelTotalesFactura.Location = new System.Drawing.Point(2, 371);
            this.panelTotalesFactura.Name = "panelTotalesFactura";
            this.panelTotalesFactura.Size = new System.Drawing.Size(617, 25);
            this.panelTotalesFactura.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(449, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "Forma de pago;";
            // 
            // comboFormaDePago
            // 
            this.comboFormaDePago.FormattingEnabled = true;
            this.comboFormaDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.comboFormaDePago.Location = new System.Drawing.Point(557, 2);
            this.comboFormaDePago.Name = "comboFormaDePago";
            this.comboFormaDePago.Size = new System.Drawing.Size(58, 21);
            this.comboFormaDePago.TabIndex = 86;
            this.comboFormaDePago.Text = "Efectivo";
            // 
            // textPago
            // 
            this.textPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPago.ForeColor = System.Drawing.Color.Green;
            this.textPago.Location = new System.Drawing.Point(226, 1);
            this.textPago.Name = "textPago";
            this.textPago.Size = new System.Drawing.Size(100, 22);
            this.textPago.TabIndex = 74;
            this.textPago.Text = "0.00";
            this.textPago.TextChanged += new System.EventHandler(this.textPago_TextChanged_1);
            this.textPago.Enter += new System.EventHandler(this.textPago_Enter);
            this.textPago.Leave += new System.EventHandler(this.textPago_Leave);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(3, 3);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(56, 16);
            this.labelCliente.TabIndex = 74;
            this.labelCliente.Text = "Cliente";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.labelAdvertenciaCliente);
            this.panel4.Controls.Add(this.btnCloseCliente);
            this.panel4.Controls.Add(this.textSearchCliente);
            this.panel4.Controls.Add(this.btnSearchCliente);
            this.panel4.Controls.Add(this.labelCliente);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 21);
            this.panel4.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(65, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Opcional";
            // 
            // labelAdvertenciaCliente
            // 
            this.labelAdvertenciaCliente.AutoSize = true;
            this.labelAdvertenciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertenciaCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertenciaCliente.Location = new System.Drawing.Point(241, 2);
            this.labelAdvertenciaCliente.Name = "labelAdvertenciaCliente";
            this.labelAdvertenciaCliente.Size = new System.Drawing.Size(157, 16);
            this.labelAdvertenciaCliente.TabIndex = 78;
            this.labelAdvertenciaCliente.Text = "No hay coincidencias";
            this.labelAdvertenciaCliente.Visible = false;
            // 
            // btnCloseCliente
            // 
            this.btnCloseCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseCliente.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseCliente.IconColor = System.Drawing.Color.DarkRed;
            this.btnCloseCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseCliente.IconSize = 18;
            this.btnCloseCliente.Location = new System.Drawing.Point(540, 1);
            this.btnCloseCliente.Name = "btnCloseCliente";
            this.btnCloseCliente.Size = new System.Drawing.Size(18, 18);
            this.btnCloseCliente.TabIndex = 77;
            this.btnCloseCliente.TabStop = false;
            this.btnCloseCliente.Visible = false;
            this.btnCloseCliente.Click += new System.EventHandler(this.btnCloseCliente_Click);
            // 
            // textSearchCliente
            // 
            this.textSearchCliente.Location = new System.Drawing.Point(413, 0);
            this.textSearchCliente.Name = "textSearchCliente";
            this.textSearchCliente.Size = new System.Drawing.Size(127, 20);
            this.textSearchCliente.TabIndex = 75;
            this.textSearchCliente.Text = "Buscar identificacion";
            this.textSearchCliente.Visible = false;
            this.textSearchCliente.TextChanged += new System.EventHandler(this.textSearchCliente_TextChanged);
            this.textSearchCliente.Enter += new System.EventHandler(this.textSearchCliente_Enter);
            // 
            // btnSearchCliente
            // 
            this.btnSearchCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCliente.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCliente.IconSize = 20;
            this.btnSearchCliente.Location = new System.Drawing.Point(559, 0);
            this.btnSearchCliente.Name = "btnSearchCliente";
            this.btnSearchCliente.Size = new System.Drawing.Size(20, 20);
            this.btnSearchCliente.TabIndex = 76;
            this.btnSearchCliente.TabStop = false;
            this.btnSearchCliente.Click += new System.EventHandler(this.btnSearchCliente_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textIdentificacionEmpleado);
            this.panel5.Controls.Add(this.labelIdentificacionEmpleado);
            this.panel5.Controls.Add(this.textApellidoEmpleado);
            this.panel5.Controls.Add(this.labelApellidoEmpleado);
            this.panel5.Controls.Add(this.textNombreEmpleado);
            this.panel5.Controls.Add(this.labelNombreEmpleado);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(619, 73);
            this.panel5.TabIndex = 76;
            // 
            // textIdentificacionEmpleado
            // 
            this.textIdentificacionEmpleado.Location = new System.Drawing.Point(74, 47);
            this.textIdentificacionEmpleado.Name = "textIdentificacionEmpleado";
            this.textIdentificacionEmpleado.Size = new System.Drawing.Size(143, 20);
            this.textIdentificacionEmpleado.TabIndex = 91;
            // 
            // labelIdentificacionEmpleado
            // 
            this.labelIdentificacionEmpleado.AutoSize = true;
            this.labelIdentificacionEmpleado.Location = new System.Drawing.Point(3, 51);
            this.labelIdentificacionEmpleado.Name = "labelIdentificacionEmpleado";
            this.labelIdentificacionEmpleado.Size = new System.Drawing.Size(73, 13);
            this.labelIdentificacionEmpleado.TabIndex = 90;
            this.labelIdentificacionEmpleado.Text = "Identificacion:";
            // 
            // textApellidoEmpleado
            // 
            this.textApellidoEmpleado.Location = new System.Drawing.Point(366, 24);
            this.textApellidoEmpleado.Name = "textApellidoEmpleado";
            this.textApellidoEmpleado.Size = new System.Drawing.Size(143, 20);
            this.textApellidoEmpleado.TabIndex = 91;
            // 
            // labelApellidoEmpleado
            // 
            this.labelApellidoEmpleado.AutoSize = true;
            this.labelApellidoEmpleado.Location = new System.Drawing.Point(256, 28);
            this.labelApellidoEmpleado.Name = "labelApellidoEmpleado";
            this.labelApellidoEmpleado.Size = new System.Drawing.Size(110, 13);
            this.labelApellidoEmpleado.TabIndex = 90;
            this.labelApellidoEmpleado.Text = "Apellido de vendedor:";
            // 
            // textNombreEmpleado
            // 
            this.textNombreEmpleado.Location = new System.Drawing.Point(111, 24);
            this.textNombreEmpleado.Name = "textNombreEmpleado";
            this.textNombreEmpleado.Size = new System.Drawing.Size(143, 20);
            this.textNombreEmpleado.TabIndex = 77;
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(4, 27);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(110, 13);
            this.labelNombreEmpleado.TabIndex = 76;
            this.labelNombreEmpleado.Text = "Nombre de vendedor:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelAdvertenciaEmpleado);
            this.panel6.Controls.Add(this.btnCloseEmpleado);
            this.panel6.Controls.Add(this.textSearchEmpleado);
            this.panel6.Controls.Add(this.btnSearchEmpleado);
            this.panel6.Controls.Add(this.labelVendedor);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(619, 21);
            this.panel6.TabIndex = 75;
            // 
            // labelAdvertenciaEmpleado
            // 
            this.labelAdvertenciaEmpleado.AutoSize = true;
            this.labelAdvertenciaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertenciaEmpleado.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertenciaEmpleado.Location = new System.Drawing.Point(241, 2);
            this.labelAdvertenciaEmpleado.Name = "labelAdvertenciaEmpleado";
            this.labelAdvertenciaEmpleado.Size = new System.Drawing.Size(157, 16);
            this.labelAdvertenciaEmpleado.TabIndex = 78;
            this.labelAdvertenciaEmpleado.Text = "No hay coincidencias";
            this.labelAdvertenciaEmpleado.Visible = false;
            // 
            // btnCloseEmpleado
            // 
            this.btnCloseEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseEmpleado.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseEmpleado.IconColor = System.Drawing.Color.DarkRed;
            this.btnCloseEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseEmpleado.IconSize = 18;
            this.btnCloseEmpleado.Location = new System.Drawing.Point(540, 1);
            this.btnCloseEmpleado.Name = "btnCloseEmpleado";
            this.btnCloseEmpleado.Size = new System.Drawing.Size(18, 18);
            this.btnCloseEmpleado.TabIndex = 77;
            this.btnCloseEmpleado.TabStop = false;
            this.btnCloseEmpleado.Visible = false;
            this.btnCloseEmpleado.Click += new System.EventHandler(this.btnCloseEmpleado_Click);
            // 
            // textSearchEmpleado
            // 
            this.textSearchEmpleado.Location = new System.Drawing.Point(413, 0);
            this.textSearchEmpleado.Name = "textSearchEmpleado";
            this.textSearchEmpleado.Size = new System.Drawing.Size(127, 20);
            this.textSearchEmpleado.TabIndex = 75;
            this.textSearchEmpleado.Text = "Buscar identificacion";
            this.textSearchEmpleado.Visible = false;
            this.textSearchEmpleado.TextChanged += new System.EventHandler(this.textSearchEmpleado_TextChanged);
            this.textSearchEmpleado.Enter += new System.EventHandler(this.textSearchEmpleado_Enter);
            // 
            // btnSearchEmpleado
            // 
            this.btnSearchEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchEmpleado.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchEmpleado.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchEmpleado.IconSize = 20;
            this.btnSearchEmpleado.Location = new System.Drawing.Point(559, 0);
            this.btnSearchEmpleado.Name = "btnSearchEmpleado";
            this.btnSearchEmpleado.Size = new System.Drawing.Size(20, 20);
            this.btnSearchEmpleado.TabIndex = 76;
            this.btnSearchEmpleado.TabStop = false;
            this.btnSearchEmpleado.Click += new System.EventHandler(this.btnSearchEmpleado_Click);
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(3, 3);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(76, 16);
            this.labelVendedor.TabIndex = 74;
            this.labelVendedor.Text = "Vendedor";
            // 
            // labelIdFactura
            // 
            this.labelIdFactura.AutoSize = true;
            this.labelIdFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIdFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFactura.ForeColor = System.Drawing.Color.Black;
            this.labelIdFactura.Location = new System.Drawing.Point(0, 0);
            this.labelIdFactura.Name = "labelIdFactura";
            this.labelIdFactura.Size = new System.Drawing.Size(100, 16);
            this.labelIdFactura.TabIndex = 77;
            this.labelIdFactura.Text = "ID de factura:";
            // 
            // labelIdGeneradoDeFactura
            // 
            this.labelIdGeneradoDeFactura.AutoSize = true;
            this.labelIdGeneradoDeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdGeneradoDeFactura.ForeColor = System.Drawing.Color.Black;
            this.labelIdGeneradoDeFactura.Location = new System.Drawing.Point(99, 0);
            this.labelIdGeneradoDeFactura.Name = "labelIdGeneradoDeFactura";
            this.labelIdGeneradoDeFactura.Size = new System.Drawing.Size(16, 16);
            this.labelIdGeneradoDeFactura.TabIndex = 78;
            this.labelIdGeneradoDeFactura.Text = "#";
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.Location = new System.Drawing.Point(101, 24);
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(143, 20);
            this.textNombreCliente.TabIndex = 79;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(5, 27);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(96, 13);
            this.labelNombreCliente.TabIndex = 78;
            this.labelNombreCliente.Text = "Nombre de cliente:";
            // 
            // textIdentificacionCliente
            // 
            this.textIdentificacionCliente.Location = new System.Drawing.Point(79, 47);
            this.textIdentificacionCliente.Name = "textIdentificacionCliente";
            this.textIdentificacionCliente.Size = new System.Drawing.Size(143, 20);
            this.textIdentificacionCliente.TabIndex = 81;
            // 
            // labelIdentificacionCliente
            // 
            this.labelIdentificacionCliente.AutoSize = true;
            this.labelIdentificacionCliente.Location = new System.Drawing.Point(6, 51);
            this.labelIdentificacionCliente.Name = "labelIdentificacionCliente";
            this.labelIdentificacionCliente.Size = new System.Drawing.Size(73, 13);
            this.labelIdentificacionCliente.TabIndex = 80;
            this.labelIdentificacionCliente.Text = "Identificacion:";
            // 
            // labelApellidoCliente
            // 
            this.labelApellidoCliente.AutoSize = true;
            this.labelApellidoCliente.Location = new System.Drawing.Point(246, 28);
            this.labelApellidoCliente.Name = "labelApellidoCliente";
            this.labelApellidoCliente.Size = new System.Drawing.Size(96, 13);
            this.labelApellidoCliente.TabIndex = 82;
            this.labelApellidoCliente.Text = "Apellido de cliente:";
            // 
            // textApellidoCliente
            // 
            this.textApellidoCliente.Location = new System.Drawing.Point(342, 24);
            this.textApellidoCliente.Name = "textApellidoCliente";
            this.textApellidoCliente.Size = new System.Drawing.Size(143, 20);
            this.textApellidoCliente.TabIndex = 83;
            // 
            // labelTipoDeId
            // 
            this.labelTipoDeId.AutoSize = true;
            this.labelTipoDeId.Location = new System.Drawing.Point(226, 51);
            this.labelTipoDeId.Name = "labelTipoDeId";
            this.labelTipoDeId.Size = new System.Drawing.Size(58, 13);
            this.labelTipoDeId.TabIndex = 84;
            this.labelTipoDeId.Text = "Tipo de Id:";
            // 
            // comboTipoDeId
            // 
            this.comboTipoDeId.FormattingEnabled = true;
            this.comboTipoDeId.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.comboTipoDeId.Location = new System.Drawing.Point(284, 47);
            this.comboTipoDeId.Name = "comboTipoDeId";
            this.comboTipoDeId.Size = new System.Drawing.Size(58, 21);
            this.comboTipoDeId.TabIndex = 85;
            this.comboTipoDeId.Text = "CC";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(346, 50);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 86;
            this.labelSexo.Text = "Sexo:";
            // 
            // dateTimeFechaDeNacimiento
            // 
            this.dateTimeFechaDeNacimiento.Location = new System.Drawing.Point(115, 70);
            this.dateTimeFechaDeNacimiento.Name = "dateTimeFechaDeNacimiento";
            this.dateTimeFechaDeNacimiento.Size = new System.Drawing.Size(202, 20);
            this.dateTimeFechaDeNacimiento.TabIndex = 87;
            // 
            // labelFechaDeNacimiento
            // 
            this.labelFechaDeNacimiento.AutoSize = true;
            this.labelFechaDeNacimiento.Location = new System.Drawing.Point(6, 73);
            this.labelFechaDeNacimiento.Name = "labelFechaDeNacimiento";
            this.labelFechaDeNacimiento.Size = new System.Drawing.Size(109, 13);
            this.labelFechaDeNacimiento.TabIndex = 88;
            this.labelFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(382, 46);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(58, 21);
            this.comboSexo.TabIndex = 89;
            this.comboSexo.Text = "M";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(8, 96);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 90;
            this.labelTelefono.Text = "Telefono:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(58, 93);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(108, 20);
            this.textTelefono.TabIndex = 91;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(168, 97);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 92;
            this.labelCorreo.Text = "Correo:";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(208, 93);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(222, 20);
            this.textCorreo.TabIndex = 93;
            // 
            // panelFactura
            // 
            this.panelFactura.Controls.Add(this.labelIdGeneradoDeFactura);
            this.panelFactura.Controls.Add(this.panel3);
            this.panelFactura.Controls.Add(this.panel8);
            this.panelFactura.Controls.Add(this.panel5);
            this.panelFactura.Controls.Add(this.labelIdFactura);
            this.panelFactura.Controls.Add(this.panelTotalesFactura);
            this.panelFactura.Controls.Add(this.dataGridFacturaProductos);
            this.panelFactura.Location = new System.Drawing.Point(12, 72);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Size = new System.Drawing.Size(619, 403);
            this.panelFactura.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 22);
            this.panel3.TabIndex = 79;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labelDireccion);
            this.panel8.Controls.Add(this.textDireccion);
            this.panel8.Controls.Add(this.textCorreo);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.labelCorreo);
            this.panel8.Controls.Add(this.textNombreCliente);
            this.panel8.Controls.Add(this.textTelefono);
            this.panel8.Controls.Add(this.labelNombreCliente);
            this.panel8.Controls.Add(this.labelTelefono);
            this.panel8.Controls.Add(this.labelIdentificacionCliente);
            this.panel8.Controls.Add(this.comboSexo);
            this.panel8.Controls.Add(this.textIdentificacionCliente);
            this.panel8.Controls.Add(this.labelFechaDeNacimiento);
            this.panel8.Controls.Add(this.labelApellidoCliente);
            this.panel8.Controls.Add(this.dateTimeFechaDeNacimiento);
            this.panel8.Controls.Add(this.textApellidoCliente);
            this.panel8.Controls.Add(this.labelSexo);
            this.panel8.Controls.Add(this.labelTipoDeId);
            this.panel8.Controls.Add(this.comboTipoDeId);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 89);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(619, 120);
            this.panel8.TabIndex = 78;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(319, 74);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 94;
            this.labelDireccion.Text = "Direccion:";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(375, 70);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(143, 20);
            this.textDireccion.TabIndex = 95;
            // 
            // ImprimirDocumento
            // 
            this.ImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // FormFacturaDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 525);
            this.Controls.Add(this.labelTextFondo);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.iconCash);
            this.Controls.Add(this.labelTitleFactura);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.menuTop);
            this.Controls.Add(this.panelFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacturaDeProducto";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFacturaDeProducto";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormFacturaDeProducto_MouseDown);
            this.menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).EndInit();
            this.panelTotalesFactura.ResumeLayout(false);
            this.panelTotalesFactura.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCliente)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEmpleado)).EndInit();
            this.panelFactura.ResumeLayout(false);
            this.panelFactura.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.DataGridView dataGridFacturaProductos;
        private FontAwesome.Sharp.IconButton btnImprimirFactura;
        private System.Windows.Forms.Label labelTitleFactura;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Label labelVueltos;
        private System.Windows.Forms.Label labelVueltosGenerado;
        private System.Windows.Forms.Label labelTotalFactura;
        private System.Windows.Forms.Label labelTotalFacturaGenerada;
        private System.Windows.Forms.Label labelTextFondo;
        private System.Windows.Forms.Label labelCash;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTotalesFactura;
        private System.Windows.Forms.TextBox textPago;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelIdFactura;
        private System.Windows.Forms.Label labelIdGeneradoDeFactura;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textNombreEmpleado;
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.TextBox textIdentificacionCliente;
        private System.Windows.Forms.Label labelIdentificacionCliente;
        private System.Windows.Forms.TextBox textApellidoCliente;
        private System.Windows.Forms.Label labelApellidoCliente;
        private System.Windows.Forms.ComboBox comboTipoDeId;
        private System.Windows.Forms.Label labelTipoDeId;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeNacimiento;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelFechaDeNacimiento;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textIdentificacionEmpleado;
        private System.Windows.Forms.Label labelIdentificacionEmpleado;
        private System.Windows.Forms.TextBox textApellidoEmpleado;
        private System.Windows.Forms.Label labelApellidoEmpleado;
        private System.Windows.Forms.Panel panelFactura;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconPictureBox btnCloseCliente;
        private System.Windows.Forms.TextBox textSearchCliente;
        private FontAwesome.Sharp.IconPictureBox btnSearchCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseEmpleado;
        private System.Windows.Forms.TextBox textSearchEmpleado;
        private FontAwesome.Sharp.IconPictureBox btnSearchEmpleado;
        private System.Windows.Forms.Label labelAdvertenciaCliente;
        private System.Windows.Forms.Label labelAdvertenciaEmpleado;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenciaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFormaDePago;
        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private System.Windows.Forms.Label label2;
    }
}