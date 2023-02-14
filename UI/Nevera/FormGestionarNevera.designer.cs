
namespace Presentacion
{
    partial class FormGestionarNevera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarNevera));
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.panelSubDataGridEstantes = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textTotalNeveras = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.dataGridNeveras = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTituloDataGridEstantes = new System.Windows.Forms.Panel();
            this.labelAdvertenciaCliente = new System.Windows.Forms.Label();
            this.btnCloseNevera = new FontAwesome.Sharp.IconPictureBox();
            this.textSearchNevera = new System.Windows.Forms.TextBox();
            this.btnSearchNevera = new FontAwesome.Sharp.IconPictureBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarNeveras = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarNeveras = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelConsultaDeProductos.SuspendLayout();
            this.panelSubDataGridEstantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNeveras)).BeginInit();
            this.panelTituloDataGridEstantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseNevera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchNevera)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConsultaDeProductos.Controls.Add(this.panelSubDataGridEstantes);
            this.panelConsultaDeProductos.Controls.Add(this.dataGridNeveras);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridEstantes);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(22, 64);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(750, 349);
            this.panelConsultaDeProductos.TabIndex = 71;
            // 
            // panelSubDataGridEstantes
            // 
            this.panelSubDataGridEstantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubDataGridEstantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridEstantes.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridEstantes.Controls.Add(this.textTotalNeveras);
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
            // textTotalNeveras
            // 
            this.textTotalNeveras.Location = new System.Drawing.Point(95, 0);
            this.textTotalNeveras.Name = "textTotalNeveras";
            this.textTotalNeveras.Size = new System.Drawing.Size(47, 20);
            this.textTotalNeveras.TabIndex = 49;
            this.textTotalNeveras.Text = "0";
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
            // dataGridNeveras
            // 
            this.dataGridNeveras.AllowUserToAddRows = false;
            this.dataGridNeveras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNeveras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNeveras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridNeveras.Location = new System.Drawing.Point(0, 23);
            this.dataGridNeveras.Name = "dataGridNeveras";
            this.dataGridNeveras.RowHeadersVisible = false;
            this.dataGridNeveras.Size = new System.Drawing.Size(750, 304);
            this.dataGridNeveras.TabIndex = 50;
            this.dataGridNeveras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNeveras_CellClick);
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
            this.panelTituloDataGridEstantes.Controls.Add(this.btnCloseNevera);
            this.panelTituloDataGridEstantes.Controls.Add(this.textSearchNevera);
            this.panelTituloDataGridEstantes.Controls.Add(this.btnSearchNevera);
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
            // btnCloseNevera
            // 
            this.btnCloseNevera.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseNevera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseNevera.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseNevera.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseNevera.IconColor = System.Drawing.Color.DarkRed;
            this.btnCloseNevera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseNevera.IconSize = 18;
            this.btnCloseNevera.Location = new System.Drawing.Point(704, 2);
            this.btnCloseNevera.Name = "btnCloseNevera";
            this.btnCloseNevera.Size = new System.Drawing.Size(18, 18);
            this.btnCloseNevera.TabIndex = 85;
            this.btnCloseNevera.TabStop = false;
            this.btnCloseNevera.Visible = false;
            this.btnCloseNevera.Click += new System.EventHandler(this.btnCloseNevera_Click);
            // 
            // textSearchNevera
            // 
            this.textSearchNevera.Location = new System.Drawing.Point(577, 1);
            this.textSearchNevera.Name = "textSearchNevera";
            this.textSearchNevera.Size = new System.Drawing.Size(127, 20);
            this.textSearchNevera.TabIndex = 83;
            this.textSearchNevera.Text = "Buscar numero";
            this.textSearchNevera.Visible = false;
            this.textSearchNevera.TextChanged += new System.EventHandler(this.textSearchNevera_TextChanged);
            this.textSearchNevera.Enter += new System.EventHandler(this.textSearchNevera_Enter);
            // 
            // btnSearchNevera
            // 
            this.btnSearchNevera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchNevera.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchNevera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNevera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchNevera.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchNevera.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchNevera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchNevera.IconSize = 20;
            this.btnSearchNevera.Location = new System.Drawing.Point(723, 1);
            this.btnSearchNevera.Name = "btnSearchNevera";
            this.btnSearchNevera.Size = new System.Drawing.Size(20, 20);
            this.btnSearchNevera.TabIndex = 84;
            this.btnSearchNevera.TabStop = false;
            this.btnSearchNevera.Click += new System.EventHandler(this.btnSearchNevera_Click);
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
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Consultar Neveras";
            // 
            // btnEliminarNeveras
            // 
            this.btnEliminarNeveras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEliminarNeveras.FlatAppearance.BorderSize = 0;
            this.btnEliminarNeveras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEliminarNeveras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarNeveras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarNeveras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNeveras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarNeveras.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarNeveras.IconColor = System.Drawing.Color.Black;
            this.btnEliminarNeveras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarNeveras.IconSize = 30;
            this.btnEliminarNeveras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarNeveras.Location = new System.Drawing.Point(373, 420);
            this.btnEliminarNeveras.Name = "btnEliminarNeveras";
            this.btnEliminarNeveras.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarNeveras.TabIndex = 73;
            this.btnEliminarNeveras.Text = "   Eliminar Neveras";
            this.btnEliminarNeveras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarNeveras.UseVisualStyleBackColor = false;
            this.btnEliminarNeveras.Click += new System.EventHandler(this.btnEliminarNeveras_Click);
            // 
            // btnRegistrarNeveras
            // 
            this.btnRegistrarNeveras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnRegistrarNeveras.FlatAppearance.BorderSize = 0;
            this.btnRegistrarNeveras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRegistrarNeveras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarNeveras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarNeveras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNeveras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarNeveras.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnRegistrarNeveras.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarNeveras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarNeveras.IconSize = 30;
            this.btnRegistrarNeveras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarNeveras.Location = new System.Drawing.Point(257, 419);
            this.btnRegistrarNeveras.Name = "btnRegistrarNeveras";
            this.btnRegistrarNeveras.Size = new System.Drawing.Size(110, 35);
            this.btnRegistrarNeveras.TabIndex = 72;
            this.btnRegistrarNeveras.Text = "   Registrar Neveras";
            this.btnRegistrarNeveras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarNeveras.UseVisualStyleBackColor = false;
            this.btnRegistrarNeveras.Click += new System.EventHandler(this.btnRegistrarNeveras_Click);
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
            this.panel1.TabIndex = 70;
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
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestionar Neveras";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panel2.Location = new System.Drawing.Point(8, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 35);
            this.panel2.TabIndex = 54;
            // 
            // FormGestionarNevera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 467);
            this.Controls.Add(this.panelConsultaDeProductos);
            this.Controls.Add(this.btnEliminarNeveras);
            this.Controls.Add(this.btnRegistrarNeveras);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionarNevera";
            this.Text = "Form1";
            this.panelConsultaDeProductos.ResumeLayout(false);
            this.panelSubDataGridEstantes.ResumeLayout(false);
            this.panelSubDataGridEstantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNeveras)).EndInit();
            this.panelTituloDataGridEstantes.ResumeLayout(false);
            this.panelTituloDataGridEstantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseNevera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchNevera)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.Panel panelSubDataGridEstantes;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox textTotalNeveras;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.DataGridView dataGridNeveras;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelTituloDataGridEstantes;
        private System.Windows.Forms.Label labelAdvertenciaCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseNevera;
        private System.Windows.Forms.TextBox textSearchNevera;
        private FontAwesome.Sharp.IconPictureBox btnSearchNevera;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnEliminarNeveras;
        private FontAwesome.Sharp.IconButton btnRegistrarNeveras;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

