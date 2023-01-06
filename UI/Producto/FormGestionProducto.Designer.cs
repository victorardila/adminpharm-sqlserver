
namespace Presentacion
{
    partial class FormGestionProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.dataGridFarmacos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cash = new System.Windows.Forms.DataGridViewImageColumn();
            this.CantidadVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.comboFiltroTipo = new System.Windows.Forms.ComboBox();
            this.labelFiltroTipo = new System.Windows.Forms.Label();
            this.comboFiltroVia = new System.Windows.Forms.ComboBox();
            this.labelFiltroVia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textCuarentena = new System.Windows.Forms.TextBox();
            this.labelCuarentena = new System.Windows.Forms.Label();
            this.textVigentes = new System.Windows.Forms.TextBox();
            this.labelVigentes = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.panelContenedorGestionProductos = new System.Windows.Forms.Panel();
            this.btnProductosVendidos = new FontAwesome.Sharp.IconButton();
            this.btnVenderProducto = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevoProducto = new FontAwesome.Sharp.IconButton();
            this.btnModificarProducto = new FontAwesome.Sharp.IconButton();
            this.btnFarmacosVencidos = new FontAwesome.Sharp.IconButton();
            this.labelTextFondo = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iconCash = new FontAwesome.Sharp.IconPictureBox();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.labelMedicamentosAgotados = new System.Windows.Forms.Label();
            this.panelConsultaDeProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panelSubDataGridFarmacos.SuspendLayout();
            this.panelContenedorGestionProductos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Productos";
            // 
            // panelBarraVolver
            // 
            this.panelBarraVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelBarraVolver.Location = new System.Drawing.Point(10, 12);
            this.panelBarraVolver.Name = "panelBarraVolver";
            this.panelBarraVolver.Size = new System.Drawing.Size(7, 35);
            this.panelBarraVolver.TabIndex = 30;
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Controls.Add(this.dataGridFarmacos);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(3, 3);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(786, 446);
            this.panelConsultaDeProductos.TabIndex = 49;
            // 
            // dataGridFarmacos
            // 
            this.dataGridFarmacos.AllowUserToAddRows = false;
            this.dataGridFarmacos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFarmacos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Eliminar,
            this.Cash,
            this.CantidadVenta});
            this.dataGridFarmacos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridFarmacos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridFarmacos.Location = new System.Drawing.Point(0, 24);
            this.dataGridFarmacos.Name = "dataGridFarmacos";
            this.dataGridFarmacos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridFarmacos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridFarmacos.RowHeadersVisible = false;
            this.dataGridFarmacos.Size = new System.Drawing.Size(786, 419);
            this.dataGridFarmacos.TabIndex = 50;
            this.dataGridFarmacos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFarmacos_CellClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Seleccionar";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Eliminar
            // 
            this.Eliminar.Description = "Seleccionar";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 30;
            // 
            // Cash
            // 
            this.Cash.HeaderText = "Vender";
            this.Cash.Image = global::Presentacion.Properties.Resources.cash;
            this.Cash.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Cash.Name = "Cash";
            this.Cash.Width = 30;
            // 
            // CantidadVenta
            // 
            this.CantidadVenta.HeaderText = "CantidadVenta";
            this.CantidadVenta.Name = "CantidadVenta";
            this.CantidadVenta.Width = 80;
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnClose);
            this.panelTituloDataGridFarmacos.Controls.Add(this.textSearch);
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnSearch);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboFiltroTipo);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltroTipo);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboFiltroVia);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltroVia);
            this.panelTituloDataGridFarmacos.Controls.Add(this.label4);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(786, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.DarkRed;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(743, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 56;
            this.btnClose.TabStop = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(616, 1);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(127, 20);
            this.textSearch.TabIndex = 54;
            this.textSearch.Text = "Buscar nombre";
            this.textSearch.Visible = false;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.Location = new System.Drawing.Point(762, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboFiltroTipo
            // 
            this.comboFiltroTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Orales",
            "Intravenoso"});
            this.comboFiltroTipo.FormattingEnabled = true;
            this.comboFiltroTipo.Items.AddRange(new object[] {
            "Todos",
            "Analgésico",
            "Anestésico",
            "Ansiolítico",
            "Antibiótico",
            "Anti-inflamatorio",
            "Anticolinérgico",
            "Anticonceptivo",
            "Anticonvulsivo",
            "Antidepresivo",
            "Antidiabético",
            "Antiemético",
            "Anti-helmíntico",
            "Anti-hipertensivo",
            "Anti-histamínico",
            "Antipirético",
            "Relajante muscular"});
            this.comboFiltroTipo.Location = new System.Drawing.Point(437, 1);
            this.comboFiltroTipo.Name = "comboFiltroTipo";
            this.comboFiltroTipo.Size = new System.Drawing.Size(102, 21);
            this.comboFiltroTipo.TabIndex = 54;
            this.comboFiltroTipo.Text = "Todos";
            this.comboFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.comboFiltroTipo_SelectedIndexChanged);
            // 
            // labelFiltroTipo
            // 
            this.labelFiltroTipo.AutoSize = true;
            this.labelFiltroTipo.Location = new System.Drawing.Point(366, 5);
            this.labelFiltroTipo.Name = "labelFiltroTipo";
            this.labelFiltroTipo.Size = new System.Drawing.Size(73, 13);
            this.labelFiltroTipo.TabIndex = 53;
            this.labelFiltroTipo.Text = "Filtrar por tipo:";
            // 
            // comboFiltroVia
            // 
            this.comboFiltroVia.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Jarabe",
            "Comprimido",
            "Capsula",
            "Intramusculares",
            "Intradermicos"});
            this.comboFiltroVia.FormattingEnabled = true;
            this.comboFiltroVia.Items.AddRange(new object[] {
            "Todos",
            "Oral",
            "Inyectable",
            "Rectal",
            "Vaginal",
            "Ocular",
            "Ótica",
            "Nasal",
            "Inhalatoria",
            "Nebulizantes",
            "Cutanea",
            "Transdérmica"});
            this.comboFiltroVia.Location = new System.Drawing.Point(273, 1);
            this.comboFiltroVia.Name = "comboFiltroVia";
            this.comboFiltroVia.Size = new System.Drawing.Size(86, 21);
            this.comboFiltroVia.TabIndex = 52;
            this.comboFiltroVia.Text = "Todos";
            this.comboFiltroVia.SelectedIndexChanged += new System.EventHandler(this.comboFiltroVia_SelectedIndexChanged);
            // 
            // labelFiltroVia
            // 
            this.labelFiltroVia.AutoSize = true;
            this.labelFiltroVia.Location = new System.Drawing.Point(203, 5);
            this.labelFiltroVia.Name = "labelFiltroVia";
            this.labelFiltroVia.Size = new System.Drawing.Size(70, 13);
            this.labelFiltroVia.TabIndex = 50;
            this.labelFiltroVia.Text = "Filtrar por via:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Consultar Productos";
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridFarmacos.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridFarmacos.Controls.Add(this.textCuarentena);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelCuarentena);
            this.panelSubDataGridFarmacos.Controls.Add(this.textVigentes);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelVigentes);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotal);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalFarmacos);
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(0, 446);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(778, 26);
            this.panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(524, 4);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(225, 16);
            this.labelAdvertencia.TabIndex = 54;
            this.labelAdvertencia.Text = "No hay productos registrados!!!";
            // 
            // textCuarentena
            // 
            this.textCuarentena.Location = new System.Drawing.Point(402, 2);
            this.textCuarentena.Name = "textCuarentena";
            this.textCuarentena.Size = new System.Drawing.Size(47, 20);
            this.textCuarentena.TabIndex = 53;
            this.textCuarentena.Text = "0";
            // 
            // labelCuarentena
            // 
            this.labelCuarentena.AutoSize = true;
            this.labelCuarentena.Location = new System.Drawing.Point(312, 5);
            this.labelCuarentena.Name = "labelCuarentena";
            this.labelCuarentena.Size = new System.Drawing.Size(92, 13);
            this.labelCuarentena.TabIndex = 52;
            this.labelCuarentena.Text = "Total Cuarentena:";
            // 
            // textVigentes
            // 
            this.textVigentes.Location = new System.Drawing.Point(237, 2);
            this.textVigentes.Name = "textVigentes";
            this.textVigentes.Size = new System.Drawing.Size(47, 20);
            this.textVigentes.TabIndex = 50;
            this.textVigentes.Text = "0";
            // 
            // labelVigentes
            // 
            this.labelVigentes.AutoSize = true;
            this.labelVigentes.Location = new System.Drawing.Point(162, 5);
            this.labelVigentes.Name = "labelVigentes";
            this.labelVigentes.Size = new System.Drawing.Size(78, 13);
            this.labelVigentes.TabIndex = 51;
            this.labelVigentes.Text = "Total Vigentes:";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(95, 2);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(47, 20);
            this.textTotal.TabIndex = 49;
            this.textTotal.Text = "0";
            // 
            // labelTotalFarmacos
            // 
            this.labelTotalFarmacos.AutoSize = true;
            this.labelTotalFarmacos.Location = new System.Drawing.Point(4, 5);
            this.labelTotalFarmacos.Name = "labelTotalFarmacos";
            this.labelTotalFarmacos.Size = new System.Drawing.Size(93, 13);
            this.labelTotalFarmacos.TabIndex = 49;
            this.labelTotalFarmacos.Text = "Total Registrados:";
            // 
            // panelContenedorGestionProductos
            // 
            this.panelContenedorGestionProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorGestionProductos.Controls.Add(this.btnProductosVendidos);
            this.panelContenedorGestionProductos.Controls.Add(this.btnVenderProducto);
            this.panelContenedorGestionProductos.Controls.Add(this.panel2);
            this.panelContenedorGestionProductos.Controls.Add(this.panel1);
            this.panelContenedorGestionProductos.Controls.Add(this.btnNuevoProducto);
            this.panelContenedorGestionProductos.Controls.Add(this.panelSubDataGridFarmacos);
            this.panelContenedorGestionProductos.Controls.Add(this.btnModificarProducto);
            this.panelContenedorGestionProductos.Controls.Add(this.panelConsultaDeProductos);
            this.panelContenedorGestionProductos.Controls.Add(this.btnFarmacosVencidos);
            this.panelContenedorGestionProductos.Location = new System.Drawing.Point(3, 53);
            this.panelContenedorGestionProductos.Name = "panelContenedorGestionProductos";
            this.panelContenedorGestionProductos.Size = new System.Drawing.Size(792, 534);
            this.panelContenedorGestionProductos.TabIndex = 52;
            // 
            // btnProductosVendidos
            // 
            this.btnProductosVendidos.BackColor = System.Drawing.Color.DarkRed;
            this.btnProductosVendidos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductosVendidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnProductosVendidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProductosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosVendidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductosVendidos.IconChar = FontAwesome.Sharp.IconChar.HandshakeAlt;
            this.btnProductosVendidos.IconColor = System.Drawing.Color.White;
            this.btnProductosVendidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductosVendidos.IconSize = 30;
            this.btnProductosVendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosVendidos.Location = new System.Drawing.Point(615, 498);
            this.btnProductosVendidos.Name = "btnProductosVendidos";
            this.btnProductosVendidos.Size = new System.Drawing.Size(151, 35);
            this.btnProductosVendidos.TabIndex = 60;
            this.btnProductosVendidos.Text = "   Vendidos";
            this.btnProductosVendidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductosVendidos.UseVisualStyleBackColor = false;
            this.btnProductosVendidos.Click += new System.EventHandler(this.btnProductosVendidos_Click);
            // 
            // btnVenderProducto
            // 
            this.btnVenderProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVenderProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVenderProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVenderProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVenderProducto.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnVenderProducto.IconColor = System.Drawing.Color.Black;
            this.btnVenderProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenderProducto.IconSize = 30;
            this.btnVenderProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenderProducto.Location = new System.Drawing.Point(465, 498);
            this.btnVenderProducto.Name = "btnVenderProducto";
            this.btnVenderProducto.Size = new System.Drawing.Size(151, 35);
            this.btnVenderProducto.TabIndex = 59;
            this.btnVenderProducto.Text = "   Vender $";
            this.btnVenderProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenderProducto.UseVisualStyleBackColor = false;
            this.btnVenderProducto.Click += new System.EventHandler(this.btnVenderProducto_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(448, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 24);
            this.panel2.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(109, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Venta de Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 24);
            this.panel1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(138, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Registrar Productos";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnNuevoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoProducto.IconChar = FontAwesome.Sharp.IconChar.Vial;
            this.btnNuevoProducto.IconColor = System.Drawing.Color.Black;
            this.btnNuevoProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoProducto.IconSize = 30;
            this.btnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.Location = new System.Drawing.Point(0, 498);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(151, 35);
            this.btnNuevoProducto.TabIndex = 54;
            this.btnNuevoProducto.Text = "   Nuevo producto";
            this.btnNuevoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarProducto.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarProducto.IconColor = System.Drawing.Color.Black;
            this.btnModificarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProducto.IconSize = 30;
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Location = new System.Drawing.Point(148, 498);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(151, 35);
            this.btnModificarProducto.TabIndex = 51;
            this.btnModificarProducto.Text = "   Modificar";
            this.btnModificarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnFarmacosVencidos
            // 
            this.btnFarmacosVencidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnFarmacosVencidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFarmacosVencidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFarmacosVencidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarmacosVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmacosVencidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFarmacosVencidos.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.btnFarmacosVencidos.IconColor = System.Drawing.Color.Black;
            this.btnFarmacosVencidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFarmacosVencidos.IconSize = 30;
            this.btnFarmacosVencidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFarmacosVencidos.Location = new System.Drawing.Point(298, 498);
            this.btnFarmacosVencidos.Name = "btnFarmacosVencidos";
            this.btnFarmacosVencidos.Size = new System.Drawing.Size(151, 35);
            this.btnFarmacosVencidos.TabIndex = 50;
            this.btnFarmacosVencidos.Text = "   Vencidos";
            this.btnFarmacosVencidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFarmacosVencidos.UseVisualStyleBackColor = false;
            this.btnFarmacosVencidos.Click += new System.EventHandler(this.btnFarmacosVencidos_Click);
            // 
            // labelTextFondo
            // 
            this.labelTextFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextFondo.AutoSize = true;
            this.labelTextFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFondo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTextFondo.Location = new System.Drawing.Point(726, 9);
            this.labelTextFondo.Name = "labelTextFondo";
            this.labelTextFondo.Size = new System.Drawing.Size(45, 12);
            this.labelTextFondo.TabIndex = 62;
            this.labelTextFondo.Text = "MONTO";
            // 
            // labelCash
            // 
            this.labelCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCash.Location = new System.Drawing.Point(730, 25);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(14, 16);
            this.labelCash.TabIndex = 61;
            this.labelCash.Text = "*";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Cash";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.cash;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Cash";
            this.dataGridViewImageColumn3.Image = global::Presentacion.Properties.Resources.cash;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // iconCash
            // 
            this.iconCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCash.BackColor = System.Drawing.SystemColors.Control;
            this.iconCash.ForeColor = System.Drawing.Color.Olive;
            this.iconCash.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconCash.IconColor = System.Drawing.Color.Olive;
            this.iconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCash.Location = new System.Drawing.Point(692, 12);
            this.iconCash.Name = "iconCash";
            this.iconCash.Size = new System.Drawing.Size(32, 32);
            this.iconCash.TabIndex = 60;
            this.iconCash.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.btnVolver.IconColor = System.Drawing.SystemColors.WindowText;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(21, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 35);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // labelMedicamentosAgotados
            // 
            this.labelMedicamentosAgotados.AutoSize = true;
            this.labelMedicamentosAgotados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicamentosAgotados.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMedicamentosAgotados.Location = new System.Drawing.Point(309, 25);
            this.labelMedicamentosAgotados.Name = "labelMedicamentosAgotados";
            this.labelMedicamentosAgotados.Size = new System.Drawing.Size(225, 16);
            this.labelMedicamentosAgotados.TabIndex = 55;
            this.labelMedicamentosAgotados.Text = "No hay productos registrados!!!";
            this.labelMedicamentosAgotados.Visible = false;
            // 
            // FormGestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.labelMedicamentosAgotados);
            this.Controls.Add(this.labelTextFondo);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.iconCash);
            this.Controls.Add(this.panelContenedorGestionProductos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBarraVolver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionProducto";
            this.Text = "s";
            this.panelConsultaDeProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            this.panelContenedorGestionProductos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.DataGridView dataGridFarmacos;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelFiltroVia;
        private System.Windows.Forms.ComboBox comboFiltroVia;
        private FontAwesome.Sharp.IconButton btnFarmacosVencidos;
        private FontAwesome.Sharp.IconButton btnModificarProducto;
        private System.Windows.Forms.Panel panelContenedorGestionProductos;
        private System.Windows.Forms.ComboBox comboFiltroTipo;
        private System.Windows.Forms.Label labelFiltroTipo;
        private System.Windows.Forms.TextBox textCuarentena;
        private System.Windows.Forms.Label labelCuarentena;
        private System.Windows.Forms.TextBox textVigentes;
        private System.Windows.Forms.Label labelVigentes;
        private System.Windows.Forms.TextBox textSearch;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private FontAwesome.Sharp.IconButton btnNuevoProducto;
        private System.Windows.Forms.Label labelAdvertencia;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private FontAwesome.Sharp.IconButton btnProductosVendidos;
        private FontAwesome.Sharp.IconButton btnVenderProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTextFondo;
        private System.Windows.Forms.Label labelCash;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVenta;
        private System.Windows.Forms.Label labelMedicamentosAgotados;
    }
}

