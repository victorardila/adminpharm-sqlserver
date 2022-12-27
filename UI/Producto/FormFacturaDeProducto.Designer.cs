
namespace Presentacion
{
    partial class FormFacturaDeProducto
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
            this.dataGridFacturaProductos = new System.Windows.Forms.DataGridView();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirFactura = new FontAwesome.Sharp.IconButton();
            this.labelTitleFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPago = new System.Windows.Forms.TextBox();
            this.labelVueltos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalFactura = new System.Windows.Forms.Label();
            this.menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturaProductos)).BeginInit();
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
            this.menuTop.Size = new System.Drawing.Size(697, 26);
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
            this.btnCerrar.Location = new System.Drawing.Point(669, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridFacturaProductos
            // 
            this.dataGridFacturaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Referencia,
            this.Cantidad,
            this.Nombre,
            this.Detalle,
            this.Precio});
            this.dataGridFacturaProductos.Location = new System.Drawing.Point(67, 143);
            this.dataGridFacturaProductos.Name = "dataGridFacturaProductos";
            this.dataGridFacturaProductos.Size = new System.Drawing.Size(556, 140);
            this.dataGridFacturaProductos.TabIndex = 6;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.Width = 85;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 130;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 183;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 65;
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnImprimirFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimirFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimirFactura.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirFactura.IconColor = System.Drawing.Color.Black;
            this.btnImprimirFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirFactura.IconSize = 30;
            this.btnImprimirFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFactura.Location = new System.Drawing.Point(275, 287);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(151, 35);
            this.btnImprimirFactura.TabIndex = 60;
            this.btnImprimirFactura.Text = "   Imprimir Factura";
            this.btnImprimirFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // labelTitleFactura
            // 
            this.labelTitleFactura.AutoSize = true;
            this.labelTitleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelTitleFactura.Location = new System.Drawing.Point(62, 38);
            this.labelTitleFactura.Name = "labelTitleFactura";
            this.labelTitleFactura.Size = new System.Drawing.Size(260, 29);
            this.labelTitleFactura.TabIndex = 61;
            this.labelTitleFactura.Text = "Factura de productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(111, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Pago= $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(411, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Vueltos= $";
            // 
            // textPago
            // 
            this.textPago.BackColor = System.Drawing.Color.Black;
            this.textPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textPago.Location = new System.Drawing.Point(192, 114);
            this.textPago.Name = "textPago";
            this.textPago.Size = new System.Drawing.Size(116, 26);
            this.textPago.TabIndex = 64;
            this.textPago.TextChanged += new System.EventHandler(this.textPago_TextChanged);
            // 
            // labelVueltos
            // 
            this.labelVueltos.AutoSize = true;
            this.labelVueltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVueltos.ForeColor = System.Drawing.Color.DarkRed;
            this.labelVueltos.Location = new System.Drawing.Point(503, 120);
            this.labelVueltos.Name = "labelVueltos";
            this.labelVueltos.Size = new System.Drawing.Size(16, 20);
            this.labelVueltos.TabIndex = 65;
            this.labelVueltos.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(205, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "Total factura:";
            // 
            // labelTotalFactura
            // 
            this.labelTotalFactura.AutoSize = true;
            this.labelTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelTotalFactura.Location = new System.Drawing.Point(332, 79);
            this.labelTotalFactura.Name = "labelTotalFactura";
            this.labelTotalFactura.Size = new System.Drawing.Size(18, 24);
            this.labelTotalFactura.TabIndex = 67;
            this.labelTotalFactura.Text = "*";
            // 
            // FormFacturaDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 342);
            this.Controls.Add(this.labelTotalFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVueltos);
            this.Controls.Add(this.textPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitleFactura);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.dataGridFacturaProductos);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacturaDeProducto";
            this.Opacity = 0.9D;
            this.Text = "FormFacturaDeProducto";
            this.menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.DataGridView dataGridFacturaProductos;
        private FontAwesome.Sharp.IconButton btnImprimirFactura;
        private System.Windows.Forms.Label labelTitleFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPago;
        private System.Windows.Forms.Label labelVueltos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}