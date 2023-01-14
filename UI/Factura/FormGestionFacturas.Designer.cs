
namespace Presentacion
{
    partial class FormGestionFacturas
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
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorGestionProductos = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnEliminarHistorial = new FontAwesome.Sharp.IconButton();
            this.panelConsultaDeProductos = new System.Windows.Forms.Panel();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.textTotalTarjeta = new System.Windows.Forms.TextBox();
            this.labelTotalTarjeta = new System.Windows.Forms.Label();
            this.textTotalEfectivo = new System.Windows.Forms.TextBox();
            this.labelTotalEfectivo = new System.Windows.Forms.Label();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textTotalFacturas = new System.Windows.Forms.TextBox();
            this.labelTotalFacturas = new System.Windows.Forms.Label();
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertenciaCliente = new System.Windows.Forms.Label();
            this.btnCloseFactura = new FontAwesome.Sharp.IconPictureBox();
            this.textSearchFactura = new System.Windows.Forms.TextBox();
            this.btnSearchFactura = new FontAwesome.Sharp.IconPictureBox();
            this.comboIdCaja = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelContenedorGestionProductos.SuspendLayout();
            this.panelConsultaDeProductos.SuspendLayout();
            this.panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchFactura)).BeginInit();
            this.SuspendLayout();
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
            this.btnVolver.TabIndex = 37;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelBarraVolver
            // 
            this.panelBarraVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelBarraVolver.Location = new System.Drawing.Point(8, 6);
            this.panelBarraVolver.Name = "panelBarraVolver";
            this.panelBarraVolver.Size = new System.Drawing.Size(7, 35);
            this.panelBarraVolver.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Gestionar Facturas";
            // 
            // panelContenedorGestionProductos
            // 
            this.panelContenedorGestionProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorGestionProductos.Controls.Add(this.iconButton1);
            this.panelContenedorGestionProductos.Controls.Add(this.btnEliminarHistorial);
            this.panelContenedorGestionProductos.Controls.Add(this.panelConsultaDeProductos);
            this.panelContenedorGestionProductos.Location = new System.Drawing.Point(19, 58);
            this.panelContenedorGestionProductos.Name = "panelContenedorGestionProductos";
            this.panelContenedorGestionProductos.Size = new System.Drawing.Size(755, 397);
            this.panelContenedorGestionProductos.TabIndex = 54;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(380, 355);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(110, 35);
            this.iconButton1.TabIndex = 52;
            this.iconButton1.Text = "   Ver facturas";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnEliminarHistorial
            // 
            this.btnEliminarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEliminarHistorial.FlatAppearance.BorderSize = 0;
            this.btnEliminarHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEliminarHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHistorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarHistorial.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarHistorial.IconColor = System.Drawing.Color.Black;
            this.btnEliminarHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarHistorial.IconSize = 30;
            this.btnEliminarHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarHistorial.Location = new System.Drawing.Point(264, 355);
            this.btnEliminarHistorial.Name = "btnEliminarHistorial";
            this.btnEliminarHistorial.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarHistorial.TabIndex = 51;
            this.btnEliminarHistorial.Text = "   Eliminar Historial";
            this.btnEliminarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarHistorial.UseVisualStyleBackColor = false;
            this.btnEliminarHistorial.Click += new System.EventHandler(this.btnEliminarHistorial_Click);
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Controls.Add(this.panelSubDataGridFarmacos);
            this.panelConsultaDeProductos.Controls.Add(this.dataGridFacturas);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(3, 3);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(750, 349);
            this.panelConsultaDeProductos.TabIndex = 49;
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalTarjeta);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalTarjeta);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalEfectivo);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalEfectivo);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalFacturas);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalFacturas);
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(0, 324);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(750, 22);
            this.panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // textTotalTarjeta
            // 
            this.textTotalTarjeta.Location = new System.Drawing.Point(361, 0);
            this.textTotalTarjeta.Name = "textTotalTarjeta";
            this.textTotalTarjeta.Size = new System.Drawing.Size(47, 20);
            this.textTotalTarjeta.TabIndex = 90;
            this.textTotalTarjeta.Text = "0";
            // 
            // labelTotalTarjeta
            // 
            this.labelTotalTarjeta.AutoSize = true;
            this.labelTotalTarjeta.Location = new System.Drawing.Point(295, 4);
            this.labelTotalTarjeta.Name = "labelTotalTarjeta";
            this.labelTotalTarjeta.Size = new System.Drawing.Size(66, 13);
            this.labelTotalTarjeta.TabIndex = 91;
            this.labelTotalTarjeta.Text = "Total tarjeta:";
            // 
            // textTotalEfectivo
            // 
            this.textTotalEfectivo.Location = new System.Drawing.Point(234, 0);
            this.textTotalEfectivo.Name = "textTotalEfectivo";
            this.textTotalEfectivo.Size = new System.Drawing.Size(47, 20);
            this.textTotalEfectivo.TabIndex = 88;
            this.textTotalEfectivo.Text = "0";
            // 
            // labelTotalEfectivo
            // 
            this.labelTotalEfectivo.AutoSize = true;
            this.labelTotalEfectivo.Location = new System.Drawing.Point(159, 4);
            this.labelTotalEfectivo.Name = "labelTotalEfectivo";
            this.labelTotalEfectivo.Size = new System.Drawing.Size(76, 13);
            this.labelTotalEfectivo.TabIndex = 89;
            this.labelTotalEfectivo.Text = "Total Efectivo:";
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
            // textTotalFacturas
            // 
            this.textTotalFacturas.Location = new System.Drawing.Point(95, 0);
            this.textTotalFacturas.Name = "textTotalFacturas";
            this.textTotalFacturas.Size = new System.Drawing.Size(47, 20);
            this.textTotalFacturas.TabIndex = 49;
            this.textTotalFacturas.Text = "0";
            // 
            // labelTotalFacturas
            // 
            this.labelTotalFacturas.AutoSize = true;
            this.labelTotalFacturas.Location = new System.Drawing.Point(4, 5);
            this.labelTotalFacturas.Name = "labelTotalFacturas";
            this.labelTotalFacturas.Size = new System.Drawing.Size(93, 13);
            this.labelTotalFacturas.TabIndex = 49;
            this.labelTotalFacturas.Text = "Total Registrados:";
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.AllowUserToAddRows = false;
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridFacturas.Location = new System.Drawing.Point(0, 23);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.RowHeadersVisible = false;
            this.dataGridFacturas.Size = new System.Drawing.Size(750, 304);
            this.dataGridFacturas.TabIndex = 50;
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
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelAdvertenciaCliente);
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnCloseFactura);
            this.panelTituloDataGridFarmacos.Controls.Add(this.textSearchFactura);
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnSearchFactura);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboIdCaja);
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
            // btnCloseFactura
            // 
            this.btnCloseFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFactura.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseFactura.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseFactura.IconColor = System.Drawing.Color.DarkRed;
            this.btnCloseFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseFactura.IconSize = 18;
            this.btnCloseFactura.Location = new System.Drawing.Point(704, 2);
            this.btnCloseFactura.Name = "btnCloseFactura";
            this.btnCloseFactura.Size = new System.Drawing.Size(18, 18);
            this.btnCloseFactura.TabIndex = 85;
            this.btnCloseFactura.TabStop = false;
            this.btnCloseFactura.Visible = false;
            this.btnCloseFactura.Click += new System.EventHandler(this.btnCloseFactura_Click);
            // 
            // textSearchFactura
            // 
            this.textSearchFactura.Location = new System.Drawing.Point(577, 1);
            this.textSearchFactura.Name = "textSearchFactura";
            this.textSearchFactura.Size = new System.Drawing.Size(127, 20);
            this.textSearchFactura.TabIndex = 83;
            this.textSearchFactura.Text = "Buscar secuencia de factura";
            this.textSearchFactura.Visible = false;
            this.textSearchFactura.TextChanged += new System.EventHandler(this.textSearchFactura_TextChanged);
            this.textSearchFactura.Enter += new System.EventHandler(this.textSearchFactura_Enter);
            // 
            // btnSearchFactura
            // 
            this.btnSearchFactura.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchFactura.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchFactura.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchFactura.IconSize = 20;
            this.btnSearchFactura.Location = new System.Drawing.Point(723, 1);
            this.btnSearchFactura.Name = "btnSearchFactura";
            this.btnSearchFactura.Size = new System.Drawing.Size(20, 20);
            this.btnSearchFactura.TabIndex = 84;
            this.btnSearchFactura.TabStop = false;
            this.btnSearchFactura.Click += new System.EventHandler(this.btnSearchFactura_Click);
            // 
            // comboIdCaja
            // 
            this.comboIdCaja.FormattingEnabled = true;
            this.comboIdCaja.Items.AddRange(new object[] {
            "Todos"});
            this.comboIdCaja.Location = new System.Drawing.Point(300, 1);
            this.comboIdCaja.Name = "comboIdCaja";
            this.comboIdCaja.Size = new System.Drawing.Size(86, 21);
            this.comboIdCaja.TabIndex = 52;
            this.comboIdCaja.Text = "Todos";
            this.comboIdCaja.SelectedIndexChanged += new System.EventHandler(this.comboIdCaja_SelectedIndexChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(198, 6);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(102, 13);
            this.labelFiltro.TabIndex = 50;
            this.labelFiltro.Text = "Filtrar por id de caja:";
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
            this.label4.Text = "Consultar Facturas";
            // 
            // FormGestionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.panelContenedorGestionProductos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBarraVolver);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionFacturas";
            this.Text = "FormGestionFacturas";
            this.panelContenedorGestionProductos.ResumeLayout(false);
            this.panelConsultaDeProductos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedorGestionProductos;
        private FontAwesome.Sharp.IconButton btnEliminarHistorial;
        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox textTotalFacturas;
        private System.Windows.Forms.Label labelTotalFacturas;
        private System.Windows.Forms.DataGridView dataGridFacturas;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.Label labelAdvertenciaCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseFactura;
        private System.Windows.Forms.TextBox textSearchFactura;
        private FontAwesome.Sharp.IconPictureBox btnSearchFactura;
        private System.Windows.Forms.ComboBox comboIdCaja;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTotalTarjeta;
        private System.Windows.Forms.Label labelTotalTarjeta;
        private System.Windows.Forms.TextBox textTotalEfectivo;
        private System.Windows.Forms.Label labelTotalEfectivo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}