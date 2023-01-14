
namespace Presentacion
{
    partial class FormGestionCaja
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
            this.panelContenedorGestionProductos = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnHistorial = new FontAwesome.Sharp.IconButton();
            this.btnCerrarCaja = new FontAwesome.Sharp.IconButton();
            this.btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            this.panelConsultaDeCajas = new System.Windows.Forms.Panel();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.textTotalCajasCerradas = new System.Windows.Forms.TextBox();
            this.labelTotalCajasCerradas = new System.Windows.Forms.Label();
            this.textTotalCajasAbiertas = new System.Windows.Forms.TextBox();
            this.labelTotalCajasAbiertas = new System.Windows.Forms.Label();
            this.textTotalCajas = new System.Windows.Forms.TextBox();
            this.labelTotalCajas = new System.Windows.Forms.Label();
            this.dataGridFarmacos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.comboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelConsultarCajas = new System.Windows.Forms.Label();
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTextFondo = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iconCash = new FontAwesome.Sharp.IconPictureBox();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.ImprimirProductosVendidos = new System.Drawing.Printing.PrintDocument();
            this.panelContenedorGestionProductos.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelConsultaDeCajas.SuspendLayout();
            this.panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedorGestionProductos
            // 
            this.panelContenedorGestionProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorGestionProductos.Controls.Add(this.panelSubMenu);
            this.panelContenedorGestionProductos.Controls.Add(this.panelConsultaDeCajas);
            this.panelContenedorGestionProductos.Location = new System.Drawing.Point(17, 54);
            this.panelContenedorGestionProductos.Name = "panelContenedorGestionProductos";
            this.panelContenedorGestionProductos.Size = new System.Drawing.Size(758, 354);
            this.panelContenedorGestionProductos.TabIndex = 53;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubMenu.Controls.Add(this.btnHistorial);
            this.panelSubMenu.Controls.Add(this.btnCerrarCaja);
            this.panelSubMenu.Controls.Add(this.btnAbrirCaja);
            this.panelSubMenu.Location = new System.Drawing.Point(632, 0);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(125, 354);
            this.panelSubMenu.TabIndex = 51;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.btnHistorial.IconColor = System.Drawing.Color.Black;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.IconSize = 30;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(0, 96);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(123, 48);
            this.btnHistorial.TabIndex = 53;
            this.btnHistorial.Text = "Eliminar Cajas Cerradas";
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnCerrarCaja.FlatAppearance.BorderSize = 0;
            this.btnCerrarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.SackXmark;
            this.btnCerrarCaja.IconColor = System.Drawing.Color.Black;
            this.btnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarCaja.IconSize = 30;
            this.btnCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarCaja.Location = new System.Drawing.Point(0, 60);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(123, 35);
            this.btnCerrarCaja.TabIndex = 52;
            this.btnCerrarCaja.Text = "  Cerrar Caja";
            this.btnCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnAbrirCaja.IconColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirCaja.IconSize = 30;
            this.btnAbrirCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaja.Location = new System.Drawing.Point(0, 24);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(123, 35);
            this.btnAbrirCaja.TabIndex = 51;
            this.btnAbrirCaja.Text = "   Abrir Caja";
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // panelConsultaDeCajas
            // 
            this.panelConsultaDeCajas.Controls.Add(this.panelSubDataGridFarmacos);
            this.panelConsultaDeCajas.Controls.Add(this.dataGridFarmacos);
            this.panelConsultaDeCajas.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeCajas.Location = new System.Drawing.Point(3, 4);
            this.panelConsultaDeCajas.Name = "panelConsultaDeCajas";
            this.panelConsultaDeCajas.Size = new System.Drawing.Size(630, 348);
            this.panelConsultaDeCajas.TabIndex = 50;
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalCajasCerradas);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalCajasCerradas);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalCajasAbiertas);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalCajasAbiertas);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalCajas);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalCajas);
            this.panelSubDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(0, 326);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(630, 22);
            this.panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // textTotalCajasCerradas
            // 
            this.textTotalCajasCerradas.Location = new System.Drawing.Point(471, 2);
            this.textTotalCajasCerradas.Name = "textTotalCajasCerradas";
            this.textTotalCajasCerradas.Size = new System.Drawing.Size(47, 20);
            this.textTotalCajasCerradas.TabIndex = 53;
            this.textTotalCajasCerradas.Text = "0";
            // 
            // labelTotalCajasCerradas
            // 
            this.labelTotalCajasCerradas.AutoSize = true;
            this.labelTotalCajasCerradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCajasCerradas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalCajasCerradas.Location = new System.Drawing.Point(342, 5);
            this.labelTotalCajasCerradas.Name = "labelTotalCajasCerradas";
            this.labelTotalCajasCerradas.Size = new System.Drawing.Size(129, 13);
            this.labelTotalCajasCerradas.TabIndex = 52;
            this.labelTotalCajasCerradas.Text = "Total Cajas Cerradas:";
            // 
            // textTotalCajasAbiertas
            // 
            this.textTotalCajasAbiertas.Location = new System.Drawing.Point(287, 1);
            this.textTotalCajasAbiertas.Name = "textTotalCajasAbiertas";
            this.textTotalCajasAbiertas.Size = new System.Drawing.Size(47, 20);
            this.textTotalCajasAbiertas.TabIndex = 51;
            this.textTotalCajasAbiertas.Text = "0";
            // 
            // labelTotalCajasAbiertas
            // 
            this.labelTotalCajasAbiertas.AutoSize = true;
            this.labelTotalCajasAbiertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCajasAbiertas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalCajasAbiertas.Location = new System.Drawing.Point(146, 5);
            this.labelTotalCajasAbiertas.Name = "labelTotalCajasAbiertas";
            this.labelTotalCajasAbiertas.Size = new System.Drawing.Size(141, 13);
            this.labelTotalCajasAbiertas.TabIndex = 50;
            this.labelTotalCajasAbiertas.Text = "Total de cajas abiertas:";
            // 
            // textTotalCajas
            // 
            this.textTotalCajas.Location = new System.Drawing.Point(95, 1);
            this.textTotalCajas.Name = "textTotalCajas";
            this.textTotalCajas.Size = new System.Drawing.Size(47, 20);
            this.textTotalCajas.TabIndex = 49;
            this.textTotalCajas.Text = "0";
            // 
            // labelTotalCajas
            // 
            this.labelTotalCajas.AutoSize = true;
            this.labelTotalCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCajas.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalCajas.Location = new System.Drawing.Point(4, 5);
            this.labelTotalCajas.Name = "labelTotalCajas";
            this.labelTotalCajas.Size = new System.Drawing.Size(92, 13);
            this.labelTotalCajas.TabIndex = 49;
            this.labelTotalCajas.Text = "Total de cajas:";
            // 
            // dataGridFarmacos
            // 
            this.dataGridFarmacos.AllowUserToAddRows = false;
            this.dataGridFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFarmacos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridFarmacos.Location = new System.Drawing.Point(0, 24);
            this.dataGridFarmacos.Name = "dataGridFarmacos";
            this.dataGridFarmacos.ReadOnly = true;
            this.dataGridFarmacos.RowHeadersVisible = false;
            this.dataGridFarmacos.Size = new System.Drawing.Size(630, 304);
            this.dataGridFarmacos.TabIndex = 50;
            this.dataGridFarmacos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFarmacos_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelAdvertencia);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboFiltroEstado);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltro);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelConsultarCajas);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(630, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAdvertencia.Location = new System.Drawing.Point(365, 5);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(201, 16);
            this.labelAdvertencia.TabIndex = 60;
            this.labelAdvertencia.Text = "No hay datos Registrados!!!";
            this.labelAdvertencia.Visible = false;
            // 
            // comboFiltroEstado
            // 
            this.comboFiltroEstado.FormattingEnabled = true;
            this.comboFiltroEstado.Items.AddRange(new object[] {
            "Todos",
            "Abierta",
            "Cerrada"});
            this.comboFiltroEstado.Location = new System.Drawing.Point(261, 1);
            this.comboFiltroEstado.Name = "comboFiltroEstado";
            this.comboFiltroEstado.Size = new System.Drawing.Size(86, 21);
            this.comboFiltroEstado.TabIndex = 52;
            this.comboFiltroEstado.Text = "Todos";
            this.comboFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.comboFiltroEstado_SelectedIndexChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFiltro.Location = new System.Drawing.Point(223, 6);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(39, 13);
            this.labelFiltro.TabIndex = 50;
            this.labelFiltro.Text = "Filtro:";
            // 
            // labelConsultarCajas
            // 
            this.labelConsultarCajas.AutoSize = true;
            this.labelConsultarCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultarCajas.ForeColor = System.Drawing.Color.White;
            this.labelConsultarCajas.Location = new System.Drawing.Point(3, 4);
            this.labelConsultarCajas.Name = "labelConsultarCajas";
            this.labelConsultarCajas.Size = new System.Drawing.Size(117, 16);
            this.labelConsultarCajas.TabIndex = 51;
            this.labelConsultarCajas.Text = "Consultar Cajas";
            // 
            // panelBarraVolver
            // 
            this.panelBarraVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelBarraVolver.Location = new System.Drawing.Point(10, 12);
            this.panelBarraVolver.Name = "panelBarraVolver";
            this.panelBarraVolver.Size = new System.Drawing.Size(7, 35);
            this.panelBarraVolver.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Gestionar Cajas";
            // 
            // labelTextFondo
            // 
            this.labelTextFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextFondo.AutoSize = true;
            this.labelTextFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextFondo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTextFondo.Location = new System.Drawing.Point(713, 9);
            this.labelTextFondo.Name = "labelTextFondo";
            this.labelTextFondo.Size = new System.Drawing.Size(45, 12);
            this.labelTextFondo.TabIndex = 59;
            this.labelTextFondo.Text = "MONTO";
            // 
            // labelCash
            // 
            this.labelCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCash.AutoSize = true;
            this.labelCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCash.Location = new System.Drawing.Point(717, 25);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(14, 16);
            this.labelCash.TabIndex = 58;
            this.labelCash.Text = "*";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // iconCash
            // 
            this.iconCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCash.BackColor = System.Drawing.SystemColors.Control;
            this.iconCash.ForeColor = System.Drawing.Color.Olive;
            this.iconCash.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconCash.IconColor = System.Drawing.Color.Olive;
            this.iconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCash.Location = new System.Drawing.Point(679, 12);
            this.iconCash.Name = "iconCash";
            this.iconCash.Size = new System.Drawing.Size(32, 32);
            this.iconCash.TabIndex = 57;
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
            this.btnVolver.TabIndex = 55;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ImprimirProductosVendidos
            // 
            this.ImprimirProductosVendidos.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // FormGestionCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.labelTextFondo);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.iconCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBarraVolver);
            this.Controls.Add(this.panelContenedorGestionProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionCaja";
            this.Text = "FormGestionCaja";
            this.panelContenedorGestionProductos.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelConsultaDeCajas.ResumeLayout(false);
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedorGestionProductos;
        private System.Windows.Forms.Panel panelConsultaDeCajas;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.TextBox textTotalCajasCerradas;
        private System.Windows.Forms.Label labelTotalCajasCerradas;
        private System.Windows.Forms.TextBox textTotalCajasAbiertas;
        private System.Windows.Forms.Label labelTotalCajasAbiertas;
        private System.Windows.Forms.TextBox textTotalCajas;
        private System.Windows.Forms.Label labelTotalCajas;
        private System.Windows.Forms.DataGridView dataGridFarmacos;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.ComboBox comboFiltroEstado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelConsultarCajas;
        private System.Windows.Forms.Panel panelSubMenu;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnCerrarCaja;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTextFondo;
        private System.Windows.Forms.Label labelCash;
        private FontAwesome.Sharp.IconPictureBox iconCash;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Drawing.Printing.PrintDocument ImprimirProductosVendidos;
    }
}