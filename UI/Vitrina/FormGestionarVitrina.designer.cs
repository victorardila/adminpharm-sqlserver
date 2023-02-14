
namespace Presentacion
{
    partial class FormGestionarVitrina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarVitrina));
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.panelSubDataGridEstantes = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textTotalVitrinas = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.dataGridVitrinas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTituloDataGridEstantes = new System.Windows.Forms.Panel();
            this.labelAdvertenciaCliente = new System.Windows.Forms.Label();
            this.btnCloseVitrina = new FontAwesome.Sharp.IconPictureBox();
            this.textSearchVitrina = new System.Windows.Forms.TextBox();
            this.btnSearchVitrina = new FontAwesome.Sharp.IconPictureBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarVitrinas = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarVitrinas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelConsultaDeProductos.SuspendLayout();
            this.panelSubDataGridEstantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVitrinas)).BeginInit();
            this.panelTituloDataGridEstantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseVitrina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchVitrina)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConsultaDeProductos.Controls.Add(this.panelSubDataGridEstantes);
            this.panelConsultaDeProductos.Controls.Add(this.dataGridVitrinas);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridEstantes);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(22, 64);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(750, 349);
            this.panelConsultaDeProductos.TabIndex = 67;
            // 
            // panelSubDataGridEstantes
            // 
            this.panelSubDataGridEstantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubDataGridEstantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridEstantes.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridEstantes.Controls.Add(this.textTotalVitrinas);
            this.panelSubDataGridEstantes.Controls.Add(this.labelTotalFarmacos);
            this.panelSubDataGridEstantes.Location = new System.Drawing.Point(0, 324);
            this.panelSubDataGridEstantes.Name = "panelSubDataGridEstantes";
            this.panelSubDataGridEstantes.Size = new System.Drawing.Size(750, 22);
            this.panelSubDataGridEstantes.TabIndex = 51;
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
            // textTotalVitrinas
            // 
            this.textTotalVitrinas.Location = new System.Drawing.Point(95, 0);
            this.textTotalVitrinas.Name = "textTotalVitrinas";
            this.textTotalVitrinas.Size = new System.Drawing.Size(47, 20);
            this.textTotalVitrinas.TabIndex = 49;
            this.textTotalVitrinas.Text = "0";
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
            // dataGridVitrinas
            // 
            this.dataGridVitrinas.AllowUserToAddRows = false;
            this.dataGridVitrinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVitrinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVitrinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridVitrinas.Location = new System.Drawing.Point(0, 23);
            this.dataGridVitrinas.Name = "dataGridVitrinas";
            this.dataGridVitrinas.RowHeadersVisible = false;
            this.dataGridVitrinas.Size = new System.Drawing.Size(750, 304);
            this.dataGridVitrinas.TabIndex = 50;
            this.dataGridVitrinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVitrinas_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // panelTituloDataGridEstantes
            // 
            this.panelTituloDataGridEstantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTituloDataGridEstantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridEstantes.Controls.Add(this.labelAdvertenciaCliente);
            this.panelTituloDataGridEstantes.Controls.Add(this.btnCloseVitrina);
            this.panelTituloDataGridEstantes.Controls.Add(this.textSearchVitrina);
            this.panelTituloDataGridEstantes.Controls.Add(this.btnSearchVitrina);
            this.panelTituloDataGridEstantes.Controls.Add(this.comboEstado);
            this.panelTituloDataGridEstantes.Controls.Add(this.labelFiltro);
            this.panelTituloDataGridEstantes.Controls.Add(this.label4);
            this.panelTituloDataGridEstantes.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridEstantes.Name = "panelTituloDataGridEstantes";
            this.panelTituloDataGridEstantes.Size = new System.Drawing.Size(750, 24);
            this.panelTituloDataGridEstantes.TabIndex = 49;
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
            // btnCloseVitrina
            // 
            this.btnCloseVitrina.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseVitrina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseVitrina.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseVitrina.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseVitrina.IconColor = System.Drawing.Color.DarkRed;
            this.btnCloseVitrina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseVitrina.IconSize = 18;
            this.btnCloseVitrina.Location = new System.Drawing.Point(704, 2);
            this.btnCloseVitrina.Name = "btnCloseVitrina";
            this.btnCloseVitrina.Size = new System.Drawing.Size(18, 18);
            this.btnCloseVitrina.TabIndex = 85;
            this.btnCloseVitrina.TabStop = false;
            this.btnCloseVitrina.Visible = false;
            this.btnCloseVitrina.Click += new System.EventHandler(this.btnCloseVitrina_Click);
            // 
            // textSearchVitrina
            // 
            this.textSearchVitrina.Location = new System.Drawing.Point(577, 1);
            this.textSearchVitrina.Name = "textSearchVitrina";
            this.textSearchVitrina.Size = new System.Drawing.Size(127, 20);
            this.textSearchVitrina.TabIndex = 83;
            this.textSearchVitrina.Text = "Buscar numero";
            this.textSearchVitrina.Visible = false;
            this.textSearchVitrina.TextChanged += new System.EventHandler(this.textSearchVitrina_TextChanged);
            this.textSearchVitrina.Enter += new System.EventHandler(this.textSearchVitrina_Enter);
            // 
            // btnSearchVitrina
            // 
            this.btnSearchVitrina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchVitrina.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchVitrina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchVitrina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchVitrina.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchVitrina.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchVitrina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchVitrina.IconSize = 20;
            this.btnSearchVitrina.Location = new System.Drawing.Point(723, 1);
            this.btnSearchVitrina.Name = "btnSearchVitrina";
            this.btnSearchVitrina.Size = new System.Drawing.Size(20, 20);
            this.btnSearchVitrina.TabIndex = 84;
            this.btnSearchVitrina.TabStop = false;
            this.btnSearchVitrina.Click += new System.EventHandler(this.btnSearchVitrina_Click);
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
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Consultar Vitrinas";
            // 
            // btnEliminarVitrinas
            // 
            this.btnEliminarVitrinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEliminarVitrinas.FlatAppearance.BorderSize = 0;
            this.btnEliminarVitrinas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEliminarVitrinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarVitrinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVitrinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVitrinas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarVitrinas.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarVitrinas.IconColor = System.Drawing.Color.Black;
            this.btnEliminarVitrinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarVitrinas.IconSize = 30;
            this.btnEliminarVitrinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarVitrinas.Location = new System.Drawing.Point(373, 420);
            this.btnEliminarVitrinas.Name = "btnEliminarVitrinas";
            this.btnEliminarVitrinas.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarVitrinas.TabIndex = 69;
            this.btnEliminarVitrinas.Text = "   Eliminar Vitrinas";
            this.btnEliminarVitrinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarVitrinas.UseVisualStyleBackColor = false;
            this.btnEliminarVitrinas.Click += new System.EventHandler(this.btnEliminarVitrinas_Click);
            // 
            // btnRegistrarVitrinas
            // 
            this.btnRegistrarVitrinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnRegistrarVitrinas.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVitrinas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRegistrarVitrinas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarVitrinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVitrinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVitrinas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarVitrinas.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnRegistrarVitrinas.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarVitrinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVitrinas.IconSize = 30;
            this.btnRegistrarVitrinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVitrinas.Location = new System.Drawing.Point(257, 419);
            this.btnRegistrarVitrinas.Name = "btnRegistrarVitrinas";
            this.btnRegistrarVitrinas.Size = new System.Drawing.Size(110, 35);
            this.btnRegistrarVitrinas.TabIndex = 68;
            this.btnRegistrarVitrinas.Text = "   Registrar Vitrinas";
            this.btnRegistrarVitrinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarVitrinas.UseVisualStyleBackColor = false;
            this.btnRegistrarVitrinas.Click += new System.EventHandler(this.btnRegistrarVitrinas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 36);
            this.panel1.TabIndex = 66;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.btnVolver.IconColor = System.Drawing.Color.White;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(18, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 35);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestionar Vitrinas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panel2.Location = new System.Drawing.Point(8, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 35);
            this.panel2.TabIndex = 54;
            // 
            // FormGestionarVitrina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 467);
            this.Controls.Add(this.panelConsultaDeProductos);
            this.Controls.Add(this.btnEliminarVitrinas);
            this.Controls.Add(this.btnRegistrarVitrinas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionarVitrina";
            this.Text = "Form1";
            this.panelConsultaDeProductos.ResumeLayout(false);
            this.panelSubDataGridEstantes.ResumeLayout(false);
            this.panelSubDataGridEstantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVitrinas)).EndInit();
            this.panelTituloDataGridEstantes.ResumeLayout(false);
            this.panelTituloDataGridEstantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseVitrina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchVitrina)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.Panel panelSubDataGridEstantes;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox textTotalVitrinas;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.DataGridView dataGridVitrinas;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelTituloDataGridEstantes;
        private System.Windows.Forms.Label labelAdvertenciaCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseVitrina;
        private System.Windows.Forms.TextBox textSearchVitrina;
        private FontAwesome.Sharp.IconPictureBox btnSearchVitrina;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnEliminarVitrinas;
        private FontAwesome.Sharp.IconButton btnRegistrarVitrinas;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

