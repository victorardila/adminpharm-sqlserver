
namespace Presentacion
{
    partial class FormGestionDeEstantes
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
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textTotalEstantes = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.dataGridEstantes = new System.Windows.Forms.DataGridView();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertenciaCliente = new System.Windows.Forms.Label();
            this.textSearchEstante = new System.Windows.Forms.TextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelContenedorGestionProductos = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnModificarEstantes = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCloseEstante = new FontAwesome.Sharp.IconPictureBox();
            this.btnSearchEstante = new FontAwesome.Sharp.IconPictureBox();
            this.btnRegistrarEstantes = new FontAwesome.Sharp.IconButton();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelConsultaDeProductos.SuspendLayout();
            this.panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstantes)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            this.panelContenedorGestionProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEstante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEstante)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraVolver
            // 
            this.panelBarraVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelBarraVolver.Location = new System.Drawing.Point(8, 6);
            this.panelBarraVolver.Name = "panelBarraVolver";
            this.panelBarraVolver.Size = new System.Drawing.Size(7, 35);
            this.panelBarraVolver.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestionar Estantes";
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Controls.Add(this.panelSubDataGridFarmacos);
            this.panelConsultaDeProductos.Controls.Add(this.dataGridEstantes);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(3, 3);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(750, 349);
            this.panelConsultaDeProductos.TabIndex = 49;
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridFarmacos.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalEstantes);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalFarmacos);
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(0, 324);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(750, 22);
            this.panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(548, 2);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(195, 16);
            this.labelAdvertencia.TabIndex = 87;
            this.labelAdvertencia.Text = "No hay datos registrados!!!";
            this.labelAdvertencia.Visible = false;
            // 
            // textTotalEstantes
            // 
            this.textTotalEstantes.Location = new System.Drawing.Point(95, 0);
            this.textTotalEstantes.Name = "textTotalEstantes";
            this.textTotalEstantes.Size = new System.Drawing.Size(47, 20);
            this.textTotalEstantes.TabIndex = 49;
            this.textTotalEstantes.Text = "0";
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
            // dataGridEstantes
            // 
            this.dataGridEstantes.AllowUserToAddRows = false;
            this.dataGridEstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridEstantes.Location = new System.Drawing.Point(0, 23);
            this.dataGridEstantes.Name = "dataGridEstantes";
            this.dataGridEstantes.RowHeadersVisible = false;
            this.dataGridEstantes.Size = new System.Drawing.Size(750, 304);
            this.dataGridEstantes.TabIndex = 50;
            this.dataGridEstantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEstantes_CellClick);
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelAdvertenciaCliente);
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnCloseEstante);
            this.panelTituloDataGridFarmacos.Controls.Add(this.textSearchEstante);
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnSearchEstante);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboEstado);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltro);
            this.panelTituloDataGridFarmacos.Controls.Add(this.label4);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(750, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // labelAdvertenciaCliente
            // 
            this.labelAdvertenciaCliente.AutoSize = true;
            this.labelAdvertenciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertenciaCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertenciaCliente.Location = new System.Drawing.Point(405, 3);
            this.labelAdvertenciaCliente.Name = "labelAdvertenciaCliente";
            this.labelAdvertenciaCliente.Size = new System.Drawing.Size(157, 16);
            this.labelAdvertenciaCliente.TabIndex = 86;
            this.labelAdvertenciaCliente.Text = "No hay coincidencias";
            this.labelAdvertenciaCliente.Visible = false;
            // 
            // textSearchEstante
            // 
            this.textSearchEstante.Location = new System.Drawing.Point(577, 1);
            this.textSearchEstante.Name = "textSearchEstante";
            this.textSearchEstante.Size = new System.Drawing.Size(127, 20);
            this.textSearchEstante.TabIndex = 83;
            this.textSearchEstante.Text = "Buscar numero";
            this.textSearchEstante.Visible = false;
            this.textSearchEstante.TextChanged += new System.EventHandler(this.textSearchEstante_TextChanged);
            this.textSearchEstante.Enter += new System.EventHandler(this.textSearchCliente_Enter);
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Todos",
            "Vacio",
            "Medio Vacio",
            "Medio Lleno",
            "Casi Lleno",
            "Lleno"});
            this.comboEstado.Location = new System.Drawing.Point(300, 2);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(86, 21);
            this.comboEstado.TabIndex = 52;
            this.comboEstado.Text = "Todos";
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(210, 6);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(88, 13);
            this.labelFiltro.TabIndex = 50;
            this.labelFiltro.Text = "Filtrar por estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Consultar Estantes";
            // 
            // panelContenedorGestionProductos
            // 
            this.panelContenedorGestionProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorGestionProductos.Controls.Add(this.btnModificarEstantes);
            this.panelContenedorGestionProductos.Controls.Add(this.panelConsultaDeProductos);
            this.panelContenedorGestionProductos.Controls.Add(this.btnRegistrarEstantes);
            this.panelContenedorGestionProductos.Location = new System.Drawing.Point(12, 47);
            this.panelContenedorGestionProductos.Name = "panelContenedorGestionProductos";
            this.panelContenedorGestionProductos.Size = new System.Drawing.Size(755, 397);
            this.panelContenedorGestionProductos.TabIndex = 53;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btnModificarEstantes
            // 
            this.btnModificarEstantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnModificarEstantes.FlatAppearance.BorderSize = 0;
            this.btnModificarEstantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnModificarEstantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificarEstantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarEstantes.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificarEstantes.IconColor = System.Drawing.Color.Black;
            this.btnModificarEstantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarEstantes.IconSize = 30;
            this.btnModificarEstantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEstantes.Location = new System.Drawing.Point(354, 359);
            this.btnModificarEstantes.Name = "btnModificarEstantes";
            this.btnModificarEstantes.Size = new System.Drawing.Size(110, 35);
            this.btnModificarEstantes.TabIndex = 51;
            this.btnModificarEstantes.Text = "   Modificar Estantes";
            this.btnModificarEstantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarEstantes.UseVisualStyleBackColor = false;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // btnCloseEstante
            // 
            this.btnCloseEstante.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseEstante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseEstante.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseEstante.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseEstante.IconColor = System.Drawing.Color.DarkRed;
            this.btnCloseEstante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseEstante.IconSize = 18;
            this.btnCloseEstante.Location = new System.Drawing.Point(704, 2);
            this.btnCloseEstante.Name = "btnCloseEstante";
            this.btnCloseEstante.Size = new System.Drawing.Size(18, 18);
            this.btnCloseEstante.TabIndex = 85;
            this.btnCloseEstante.TabStop = false;
            this.btnCloseEstante.Visible = false;
            this.btnCloseEstante.Click += new System.EventHandler(this.btnCloseCliente_Click);
            // 
            // btnSearchEstante
            // 
            this.btnSearchEstante.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchEstante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchEstante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchEstante.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchEstante.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchEstante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchEstante.IconSize = 20;
            this.btnSearchEstante.Location = new System.Drawing.Point(723, 1);
            this.btnSearchEstante.Name = "btnSearchEstante";
            this.btnSearchEstante.Size = new System.Drawing.Size(20, 20);
            this.btnSearchEstante.TabIndex = 84;
            this.btnSearchEstante.TabStop = false;
            this.btnSearchEstante.Click += new System.EventHandler(this.btnSearchCliente_Click);
            // 
            // btnRegistrarEstantes
            // 
            this.btnRegistrarEstantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnRegistrarEstantes.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEstantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRegistrarEstantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarEstantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarEstantes.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnRegistrarEstantes.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarEstantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarEstantes.IconSize = 30;
            this.btnRegistrarEstantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarEstantes.Location = new System.Drawing.Point(238, 358);
            this.btnRegistrarEstantes.Name = "btnRegistrarEstantes";
            this.btnRegistrarEstantes.Size = new System.Drawing.Size(110, 35);
            this.btnRegistrarEstantes.TabIndex = 50;
            this.btnRegistrarEstantes.Text = "   Registrar Estantes";
            this.btnRegistrarEstantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarEstantes.UseVisualStyleBackColor = false;
            this.btnRegistrarEstantes.Click += new System.EventHandler(this.btnRegistrarEstantes_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(19, 6);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 35);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormGestionDeEstantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 467);
            this.Controls.Add(this.panelContenedorGestionProductos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBarraVolver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionDeEstantes";
            this.Text = "FormGestionDeEstantes";
            this.panelConsultaDeProductos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstantes)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            this.panelContenedorGestionProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEstante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEstante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnModificarEstantes;
        private FontAwesome.Sharp.IconButton btnRegistrarEstantes;
        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.TextBox textTotalEstantes;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.DataGridView dataGridEstantes;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.Label labelAdvertenciaCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseEstante;
        private System.Windows.Forms.TextBox textSearchEstante;
        private FontAwesome.Sharp.IconPictureBox btnSearchEstante;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelContenedorGestionProductos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label labelAdvertencia;
    }
}