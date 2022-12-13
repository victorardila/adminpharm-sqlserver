
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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
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
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.comboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelConsultarCajas = new System.Windows.Forms.Label();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorGestionProductos.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelConsultaDeCajas.SuspendLayout();
            this.panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
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
            this.panelSubMenu.Controls.Add(this.iconButton2);
            this.panelSubMenu.Controls.Add(this.iconButton1);
            this.panelSubMenu.Controls.Add(this.btnAbrirCaja);
            this.panelSubMenu.Location = new System.Drawing.Point(632, 0);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(125, 354);
            this.panelSubMenu.TabIndex = 51;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 96);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(123, 35);
            this.iconButton2.TabIndex = 53;
            this.iconButton2.Text = "Historial de Cajas";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 60);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(123, 35);
            this.iconButton1.TabIndex = 52;
            this.iconButton1.Text = "  Cerrar Caja";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
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
            this.btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
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
            this.dataGridFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFarmacos.Location = new System.Drawing.Point(0, 24);
            this.dataGridFarmacos.Name = "dataGridFarmacos";
            this.dataGridFarmacos.Size = new System.Drawing.Size(630, 324);
            this.dataGridFarmacos.TabIndex = 50;
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboFiltroEstado);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltro);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelConsultarCajas);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(630, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // comboFiltroEstado
            // 
            this.comboFiltroEstado.FormattingEnabled = true;
            this.comboFiltroEstado.Items.AddRange(new object[] {
            "Abierta",
            "Cerrada"});
            this.comboFiltroEstado.Location = new System.Drawing.Point(261, 1);
            this.comboFiltroEstado.Name = "comboFiltroEstado";
            this.comboFiltroEstado.Size = new System.Drawing.Size(86, 21);
            this.comboFiltroEstado.TabIndex = 52;
            this.comboFiltroEstado.Text = "Todos";
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
            // FormGestionCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
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
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label label1;
    }
}