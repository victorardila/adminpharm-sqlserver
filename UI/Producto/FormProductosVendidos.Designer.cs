﻿
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
            this.dataGridProductosVendidos = new System.Windows.Forms.DataGridView();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelFechaActual = new System.Windows.Forms.Label();
            this.labelFiltroFecha = new System.Windows.Forms.Label();
            this.comboFecha = new System.Windows.Forms.ComboBox();
            this.labelVentaDia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLimpiarHistorial = new FontAwesome.Sharp.IconButton();
            this.Deshacer = new System.Windows.Forms.DataGridViewImageColumn();
            this.FechaDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuTop.SuspendLayout();
            this.panelConsultaDeProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductosVendidos)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
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
            this.btnCerrar.Location = new System.Drawing.Point(780, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelConsultaDeProductos
            // 
            this.panelConsultaDeProductos.Controls.Add(this.dataGridProductosVendidos);
            this.panelConsultaDeProductos.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeProductos.Location = new System.Drawing.Point(18, 36);
            this.panelConsultaDeProductos.Name = "panelConsultaDeProductos";
            this.panelConsultaDeProductos.Size = new System.Drawing.Size(772, 446);
            this.panelConsultaDeProductos.TabIndex = 51;
            // 
            // dataGridProductosVendidos
            // 
            this.dataGridProductosVendidos.AllowUserToAddRows = false;
            this.dataGridProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductosVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deshacer,
            this.FechaDeVenta,
            this.Cantidad,
            this.Referencia,
            this.Nombre,
            this.Detalle,
            this.Unidad,
            this.Total});
            this.dataGridProductosVendidos.Location = new System.Drawing.Point(0, 24);
            this.dataGridProductosVendidos.Name = "dataGridProductosVendidos";
            this.dataGridProductosVendidos.RowHeadersVisible = false;
            this.dataGridProductosVendidos.Size = new System.Drawing.Size(772, 419);
            this.dataGridProductosVendidos.TabIndex = 51;
            this.dataGridProductosVendidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductosVendidos_CellClick);
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFechaActual);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltroFecha);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboFecha);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelVentaDia);
            this.panelTituloDataGridFarmacos.Controls.Add(this.label4);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(772, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // labelFechaActual
            // 
            this.labelFechaActual.AutoSize = true;
            this.labelFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaActual.ForeColor = System.Drawing.Color.Green;
            this.labelFechaActual.Location = new System.Drawing.Point(309, 3);
            this.labelFechaActual.Name = "labelFechaActual";
            this.labelFechaActual.Size = new System.Drawing.Size(98, 16);
            this.labelFechaActual.TabIndex = 55;
            this.labelFechaActual.Text = "Fecha Actual";
            // 
            // labelFiltroFecha
            // 
            this.labelFiltroFecha.AutoSize = true;
            this.labelFiltroFecha.Location = new System.Drawing.Point(578, 4);
            this.labelFiltroFecha.Name = "labelFiltroFecha";
            this.labelFiltroFecha.Size = new System.Drawing.Size(65, 13);
            this.labelFiltroFecha.TabIndex = 54;
            this.labelFiltroFecha.Text = "Filtro Fecha:";
            // 
            // comboFecha
            // 
            this.comboFecha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboFecha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboFecha.FormattingEnabled = true;
            this.comboFecha.Items.AddRange(new object[] {
            "Todos"});
            this.comboFecha.Location = new System.Drawing.Point(646, 0);
            this.comboFecha.Name = "comboFecha";
            this.comboFecha.Size = new System.Drawing.Size(121, 21);
            this.comboFecha.TabIndex = 53;
            this.comboFecha.Text = "Todos";
            this.comboFecha.SelectedIndexChanged += new System.EventHandler(this.comboFecha_SelectedIndexChanged);
            // 
            // labelVentaDia
            // 
            this.labelVentaDia.AutoSize = true;
            this.labelVentaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentaDia.ForeColor = System.Drawing.Color.Green;
            this.labelVentaDia.Location = new System.Drawing.Point(161, 4);
            this.labelVentaDia.Name = "labelVentaDia";
            this.labelVentaDia.Size = new System.Drawing.Size(14, 16);
            this.labelVentaDia.TabIndex = 52;
            this.labelVentaDia.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Produtos Vendidos $";
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridFarmacos.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotal);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalFarmacos);
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(18, 478);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(775, 26);
            this.panelSubDataGridFarmacos.TabIndex = 53;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(524, 4);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(210, 16);
            this.labelAdvertencia.TabIndex = 54;
            this.labelAdvertencia.Text = "No hay productos vendidos!!!";
            this.labelAdvertencia.Visible = false;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // btnLimpiarHistorial
            // 
            this.btnLimpiarHistorial.BackColor = System.Drawing.Color.DarkRed;
            this.btnLimpiarHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarHistorial.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnLimpiarHistorial.IconColor = System.Drawing.Color.White;
            this.btnLimpiarHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarHistorial.IconSize = 30;
            this.btnLimpiarHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarHistorial.Location = new System.Drawing.Point(322, 514);
            this.btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            this.btnLimpiarHistorial.Size = new System.Drawing.Size(151, 35);
            this.btnLimpiarHistorial.TabIndex = 62;
            this.btnLimpiarHistorial.Text = "   Limpiar Historial";
            this.btnLimpiarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarHistorial.UseVisualStyleBackColor = false;
            this.btnLimpiarHistorial.Click += new System.EventHandler(this.btnLimpiarHistorial_Click);
            // 
            // Deshacer
            // 
            this.Deshacer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Deshacer.HeaderText = "Deshacer";
            this.Deshacer.Image = global::Presentacion.Properties.Resources.Regresar;
            this.Deshacer.Name = "Deshacer";
            this.Deshacer.ReadOnly = true;
            this.Deshacer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Deshacer.Width = 59;
            // 
            // FechaDeVenta
            // 
            this.FechaDeVenta.HeaderText = "FechaDeVenta";
            this.FechaDeVenta.Name = "FechaDeVenta";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 50;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 160;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 150;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // FormProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 555);
            this.Controls.Add(this.btnLimpiarHistorial);
            this.Controls.Add(this.panelSubDataGridFarmacos);
            this.Controls.Add(this.panelConsultaDeProductos);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductosVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductosVendidos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProductosVendidos_MouseDown);
            this.menuTop.ResumeLayout(false);
            this.panelConsultaDeProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductosVendidos)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelConsultaDeProductos;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.DataGridView dataGridProductosVendidos;
        private FontAwesome.Sharp.IconButton btnLimpiarHistorial;
        private System.Windows.Forms.Label labelVentaDia;
        private System.Windows.Forms.ComboBox comboFecha;
        private System.Windows.Forms.Label labelFiltroFecha;
        private System.Windows.Forms.Label labelFechaActual;
        private System.Windows.Forms.DataGridViewImageColumn Deshacer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}