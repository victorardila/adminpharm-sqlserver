
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.panelSubDataGridEstantes = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textTotalEstantes = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.panelTituloDataGridEstantes = new System.Windows.Forms.Panel();
            this.labelAdvertenciaCliente = new System.Windows.Forms.Label();
            this.btnCloseEstante = new FontAwesome.Sharp.IconPictureBox();
            this.textSearchEstante = new System.Windows.Forms.TextBox();
            this.btnSearchEstante = new FontAwesome.Sharp.IconPictureBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminarEstantes = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarEstantes = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridEstantes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelConsultaDeProductos.SuspendLayout();
            this.panelSubDataGridEstantes.SuspendLayout();
            this.panelTituloDataGridEstantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEstante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEstante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestionar Estantes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 36);
            this.panel1.TabIndex = 62;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panel2.Location = new System.Drawing.Point(8, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 35);
            this.panel2.TabIndex = 54;
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConsultaDeProductos.Controls.Add(this.panelSubDataGridEstantes);
            this.panelConsultaDeProductos.Controls.Add(this.dataGridEstantes);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridEstantes);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(22, 57);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(750, 349);
            this.panelConsultaDeProductos.TabIndex = 63;
            // 
            // panelSubDataGridEstantes
            // 
            this.panelSubDataGridEstantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubDataGridEstantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridEstantes.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridEstantes.Controls.Add(this.textTotalEstantes);
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
            // panelTituloDataGridEstantes
            // 
            this.panelTituloDataGridEstantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTituloDataGridEstantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridEstantes.Controls.Add(this.labelAdvertenciaCliente);
            this.panelTituloDataGridEstantes.Controls.Add(this.btnCloseEstante);
            this.panelTituloDataGridEstantes.Controls.Add(this.textSearchEstante);
            this.panelTituloDataGridEstantes.Controls.Add(this.btnSearchEstante);
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
            // 
            // textSearchEstante
            // 
            this.textSearchEstante.Location = new System.Drawing.Point(577, 1);
            this.textSearchEstante.Name = "textSearchEstante";
            this.textSearchEstante.Size = new System.Drawing.Size(127, 20);
            this.textSearchEstante.TabIndex = 83;
            this.textSearchEstante.Text = "Buscar numero";
            this.textSearchEstante.Visible = false;
            // 
            // btnSearchEstante
            // 
            this.btnSearchEstante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Consultar Estantes";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btnEliminarEstantes
            // 
            this.btnEliminarEstantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEliminarEstantes.FlatAppearance.BorderSize = 0;
            this.btnEliminarEstantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEliminarEstantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarEstantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarEstantes.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarEstantes.IconColor = System.Drawing.Color.Black;
            this.btnEliminarEstantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEstantes.IconSize = 30;
            this.btnEliminarEstantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEstantes.Location = new System.Drawing.Point(373, 413);
            this.btnEliminarEstantes.Name = "btnEliminarEstantes";
            this.btnEliminarEstantes.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarEstantes.TabIndex = 65;
            this.btnEliminarEstantes.Text = "   Eliminar Estantes";
            this.btnEliminarEstantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEstantes.UseVisualStyleBackColor = false;
            this.btnEliminarEstantes.Click += new System.EventHandler(this.btnEliminarEstantes_Click_1);
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
            this.btnRegistrarEstantes.Location = new System.Drawing.Point(257, 412);
            this.btnRegistrarEstantes.Name = "btnRegistrarEstantes";
            this.btnRegistrarEstantes.Size = new System.Drawing.Size(110, 35);
            this.btnRegistrarEstantes.TabIndex = 64;
            this.btnRegistrarEstantes.Text = "   Registrar Estantes";
            this.btnRegistrarEstantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarEstantes.UseVisualStyleBackColor = false;
            this.btnRegistrarEstantes.Click += new System.EventHandler(this.btnRegistrarEstantes_Click_1);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.deleRojBlack;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // dataGridEstantes
            // 
            this.dataGridEstantes.AllowUserToAddRows = false;
            this.dataGridEstantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridEstantes.Location = new System.Drawing.Point(0, 23);
            this.dataGridEstantes.Name = "dataGridEstantes";
            this.dataGridEstantes.RowHeadersVisible = false;
            this.dataGridEstantes.Size = new System.Drawing.Size(750, 304);
            this.dataGridEstantes.TabIndex = 50;
            // 
            // FormGestionDeEstantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 467);
            this.Controls.Add(this.panelConsultaDeProductos);
            this.Controls.Add(this.btnEliminarEstantes);
            this.Controls.Add(this.btnRegistrarEstantes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionDeEstantes";
            this.Text = "FormGestionDeEstantes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelConsultaDeProductos.ResumeLayout(false);
            this.panelSubDataGridEstantes.ResumeLayout(false);
            this.panelSubDataGridEstantes.PerformLayout();
            this.panelTituloDataGridEstantes.ResumeLayout(false);
            this.panelTituloDataGridEstantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseEstante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchEstante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.Panel panelSubDataGridEstantes;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox textTotalEstantes;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.Panel panelTituloDataGridEstantes;
        private System.Windows.Forms.Label labelAdvertenciaCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseEstante;
        private System.Windows.Forms.TextBox textSearchEstante;
        private FontAwesome.Sharp.IconPictureBox btnSearchEstante;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnEliminarEstantes;
        private FontAwesome.Sharp.IconButton btnRegistrarEstantes;
        private System.Windows.Forms.DataGridView dataGridEstantes;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}