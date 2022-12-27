
namespace Presentacion
{
    partial class FormProductosVendidos
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
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.dataGridFarmacos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.comboFiltroAdministracion = new System.Windows.Forms.ComboBox();
            this.labelFiltroAdministracion = new System.Windows.Forms.Label();
            this.comboFiltroPresentacion = new System.Windows.Forms.ComboBox();
            this.labelFiltroPresentacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textCuarentena = new System.Windows.Forms.TextBox();
            this.labelCuarentena = new System.Windows.Forms.Label();
            this.textVigentes = new System.Windows.Forms.TextBox();
            this.labelVigentes = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.menuTop.SuspendLayout();
            this.panelConsultaDeProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panelSubDataGridFarmacos.SuspendLayout();
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
            this.menuTop.Size = new System.Drawing.Size(808, 26);
            this.menuTop.TabIndex = 5;
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
            this.btnCerrar.Location = new System.Drawing.Point(780, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Controls.Add(this.dataGridFarmacos);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(18, 36);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(772, 446);
            this.panelConsultaDeProductos.TabIndex = 51;
            // 
            // dataGridFarmacos
            // 
            this.dataGridFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFarmacos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridFarmacos.Location = new System.Drawing.Point(0, 24);
            this.dataGridFarmacos.Name = "dataGridFarmacos";
            this.dataGridFarmacos.Size = new System.Drawing.Size(772, 419);
            this.dataGridFarmacos.TabIndex = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnClose);
            this.panelTituloDataGridFarmacos.Controls.Add(this.textSearch);
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnSearch);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboFiltroAdministracion);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltroAdministracion);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboFiltroPresentacion);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltroPresentacion);
            this.panelTituloDataGridFarmacos.Controls.Add(this.label4);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(772, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(703, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 56;
            this.btnClose.TabStop = false;
            this.btnClose.Visible = false;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(578, 1);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(127, 20);
            this.textSearch.TabIndex = 54;
            this.textSearch.Text = "Buscar nombre";
            this.textSearch.Visible = false;
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
            this.btnSearch.Location = new System.Drawing.Point(725, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.TabStop = false;
            // 
            // comboFiltroAdministracion
            // 
            this.comboFiltroAdministracion.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Orales",
            "Intravenoso"});
            this.comboFiltroAdministracion.FormattingEnabled = true;
            this.comboFiltroAdministracion.Items.AddRange(new object[] {
            "Todos",
            "Oral",
            "Intravenosa"});
            this.comboFiltroAdministracion.Location = new System.Drawing.Point(463, 1);
            this.comboFiltroAdministracion.Name = "comboFiltroAdministracion";
            this.comboFiltroAdministracion.Size = new System.Drawing.Size(109, 21);
            this.comboFiltroAdministracion.TabIndex = 54;
            this.comboFiltroAdministracion.Text = "Todos";
            // 
            // labelFiltroAdministracion
            // 
            this.labelFiltroAdministracion.AutoSize = true;
            this.labelFiltroAdministracion.Location = new System.Drawing.Point(385, 5);
            this.labelFiltroAdministracion.Name = "labelFiltroAdministracion";
            this.labelFiltroAdministracion.Size = new System.Drawing.Size(81, 13);
            this.labelFiltroAdministracion.TabIndex = 53;
            this.labelFiltroAdministracion.Text = "Filtro por admin:";
            // 
            // comboFiltroPresentacion
            // 
            this.comboFiltroPresentacion.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Jarabe",
            "Comprimido",
            "Capsula",
            "Intramusculares",
            "Intradermicos"});
            this.comboFiltroPresentacion.FormattingEnabled = true;
            this.comboFiltroPresentacion.Items.AddRange(new object[] {
            "Todos",
            "Jarabe",
            "Comprimido",
            "Capsula",
            "Intramusculares",
            "Intradermicos"});
            this.comboFiltroPresentacion.Location = new System.Drawing.Point(299, 1);
            this.comboFiltroPresentacion.Name = "comboFiltroPresentacion";
            this.comboFiltroPresentacion.Size = new System.Drawing.Size(86, 21);
            this.comboFiltroPresentacion.TabIndex = 52;
            this.comboFiltroPresentacion.Text = "Todos";
            // 
            // labelFiltroPresentacion
            // 
            this.labelFiltroPresentacion.AutoSize = true;
            this.labelFiltroPresentacion.Location = new System.Drawing.Point(204, 5);
            this.labelFiltroPresentacion.Name = "labelFiltroPresentacion";
            this.labelFiltroPresentacion.Size = new System.Drawing.Size(96, 13);
            this.labelFiltroPresentacion.TabIndex = 50;
            this.labelFiltroPresentacion.Text = "Filtro presentacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Produtos Vendidos";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
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
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(15, 480);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(778, 26);
            this.panelSubDataGridFarmacos.TabIndex = 53;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Enabled = false;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(524, 4);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(210, 16);
            this.labelAdvertencia.TabIndex = 54;
            this.labelAdvertencia.Text = "No hay productos vendidos!!!";
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
            // FormProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 518);
            this.Controls.Add(this.panelSubDataGridFarmacos);
            this.Controls.Add(this.panelConsultaDeProductos);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductosVendidos";
            this.Text = "FormProductosVendidos";
            this.menuTop.ResumeLayout(false);
            this.panelConsultaDeProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.DataGridView dataGridFarmacos;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.TextBox textSearch;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private System.Windows.Forms.ComboBox comboFiltroAdministracion;
        private System.Windows.Forms.Label labelFiltroAdministracion;
        private System.Windows.Forms.ComboBox comboFiltroPresentacion;
        private System.Windows.Forms.Label labelFiltroPresentacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox textCuarentena;
        private System.Windows.Forms.Label labelCuarentena;
        private System.Windows.Forms.TextBox textVigentes;
        private System.Windows.Forms.Label labelVigentes;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelTotalFarmacos;
    }
}