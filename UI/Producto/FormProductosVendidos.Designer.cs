
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
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
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
            this.btnLimpiarHistorial = new FontAwesome.Sharp.IconButton();
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
            this.Cantidad,
            this.Referencia,
            this.Nombre,
            this.Detalle,
            this.Precio});
            this.dataGridProductosVendidos.Location = new System.Drawing.Point(0, 24);
            this.dataGridProductosVendidos.Name = "dataGridProductosVendidos";
            this.dataGridProductosVendidos.RowHeadersVisible = false;
            this.dataGridProductosVendidos.Size = new System.Drawing.Size(772, 419);
            this.dataGridProductosVendidos.TabIndex = 51;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 180;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 108;
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridFarmacos.Controls.Add(this.label4);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(772, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
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
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(524, 4);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(210, 16);
            this.labelAdvertencia.TabIndex = 54;
            this.labelAdvertencia.Text = "No hay productos vendidos!!!";
            this.labelAdvertencia.Visible = false;
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
            // btnLimpiarHistorial
            // 
            this.btnLimpiarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnLimpiarHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarHistorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiarHistorial.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnLimpiarHistorial.IconColor = System.Drawing.Color.Black;
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
        private System.Windows.Forms.TextBox textCuarentena;
        private System.Windows.Forms.Label labelCuarentena;
        private System.Windows.Forms.TextBox textVigentes;
        private System.Windows.Forms.Label labelVigentes;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.DataGridView dataGridProductosVendidos;
        private FontAwesome.Sharp.IconButton btnLimpiarHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}