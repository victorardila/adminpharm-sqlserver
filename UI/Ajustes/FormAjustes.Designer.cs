
namespace Presentacion
{
    partial class FormAjustes
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
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelBarraVolver = new System.Windows.Forms.Panel();
            this.labelNombreDrogueria = new System.Windows.Forms.Label();
            this.textNombreDrogueria = new System.Windows.Forms.TextBox();
            this.textNIT = new System.Windows.Forms.TextBox();
            this.labelNIT = new System.Windows.Forms.Label();
            this.textFraseDistintiva = new System.Windows.Forms.TextBox();
            this.labelFraseDistintiva = new System.Windows.Forms.Label();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.textPBX = new System.Windows.Forms.TextBox();
            this.labelPBX = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboRegimen = new System.Windows.Forms.ComboBox();
            this.btnRegistrarInfo = new FontAwesome.Sharp.IconButton();
            this.btnModificarInfo = new FontAwesome.Sharp.IconButton();
            this.btnEliminarInfo = new FontAwesome.Sharp.IconButton();
            this.dataGridInfoDrogueria = new System.Windows.Forms.DataGridView();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfoDrogueria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Ajustar Informacion de la drogueria";
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
            this.btnVolver.Location = new System.Drawing.Point(24, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 35);
            this.btnVolver.TabIndex = 58;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelBarraVolver
            // 
            this.panelBarraVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelBarraVolver.Location = new System.Drawing.Point(13, 13);
            this.panelBarraVolver.Name = "panelBarraVolver";
            this.panelBarraVolver.Size = new System.Drawing.Size(7, 35);
            this.panelBarraVolver.TabIndex = 57;
            // 
            // labelNombreDrogueria
            // 
            this.labelNombreDrogueria.AutoSize = true;
            this.labelNombreDrogueria.Location = new System.Drawing.Point(77, 215);
            this.labelNombreDrogueria.Name = "labelNombreDrogueria";
            this.labelNombreDrogueria.Size = new System.Drawing.Size(120, 13);
            this.labelNombreDrogueria.TabIndex = 60;
            this.labelNombreDrogueria.Text = "Nombre de la drogueria:";
            // 
            // textNombreDrogueria
            // 
            this.textNombreDrogueria.Location = new System.Drawing.Point(197, 212);
            this.textNombreDrogueria.Name = "textNombreDrogueria";
            this.textNombreDrogueria.Size = new System.Drawing.Size(226, 20);
            this.textNombreDrogueria.TabIndex = 61;
            // 
            // textNIT
            // 
            this.textNIT.Location = new System.Drawing.Point(462, 214);
            this.textNIT.Name = "textNIT";
            this.textNIT.Size = new System.Drawing.Size(189, 20);
            this.textNIT.TabIndex = 63;
            // 
            // labelNIT
            // 
            this.labelNIT.AutoSize = true;
            this.labelNIT.Location = new System.Drawing.Point(429, 215);
            this.labelNIT.Name = "labelNIT";
            this.labelNIT.Size = new System.Drawing.Size(28, 13);
            this.labelNIT.TabIndex = 62;
            this.labelNIT.Text = "NIT:";
            // 
            // textFraseDistintiva
            // 
            this.textFraseDistintiva.Location = new System.Drawing.Point(163, 247);
            this.textFraseDistintiva.Multiline = true;
            this.textFraseDistintiva.Name = "textFraseDistintiva";
            this.textFraseDistintiva.Size = new System.Drawing.Size(260, 52);
            this.textFraseDistintiva.TabIndex = 65;
            // 
            // labelFraseDistintiva
            // 
            this.labelFraseDistintiva.AutoSize = true;
            this.labelFraseDistintiva.Location = new System.Drawing.Point(77, 267);
            this.labelFraseDistintiva.Name = "labelFraseDistintiva";
            this.labelFraseDistintiva.Size = new System.Drawing.Size(80, 13);
            this.labelFraseDistintiva.TabIndex = 64;
            this.labelFraseDistintiva.Text = "Frase distintiva:";
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Location = new System.Drawing.Point(434, 263);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(52, 13);
            this.labelRegimen.TabIndex = 66;
            this.labelRegimen.Text = "Regimen:";
            // 
            // textPBX
            // 
            this.textPBX.Location = new System.Drawing.Point(114, 309);
            this.textPBX.Name = "textPBX";
            this.textPBX.Size = new System.Drawing.Size(132, 20);
            this.textPBX.TabIndex = 69;
            // 
            // labelPBX
            // 
            this.labelPBX.AutoSize = true;
            this.labelPBX.Location = new System.Drawing.Point(77, 312);
            this.labelPBX.Name = "labelPBX";
            this.labelPBX.Size = new System.Drawing.Size(31, 13);
            this.labelPBX.TabIndex = 68;
            this.labelPBX.Text = "PBX:";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(302, 309);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(202, 20);
            this.textDireccion.TabIndex = 71;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(248, 312);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 70;
            this.labelDireccion.Text = "Direccion:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(568, 309);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 20);
            this.textTelefono.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Telefono:";
            // 
            // comboRegimen
            // 
            this.comboRegimen.FormattingEnabled = true;
            this.comboRegimen.Location = new System.Drawing.Point(488, 259);
            this.comboRegimen.Name = "comboRegimen";
            this.comboRegimen.Size = new System.Drawing.Size(121, 21);
            this.comboRegimen.TabIndex = 74;
            // 
            // btnRegistrarInfo
            // 
            this.btnRegistrarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnRegistrarInfo.FlatAppearance.BorderSize = 0;
            this.btnRegistrarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRegistrarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarInfo.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnRegistrarInfo.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarInfo.IconSize = 30;
            this.btnRegistrarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarInfo.Location = new System.Drawing.Point(123, 346);
            this.btnRegistrarInfo.Name = "btnRegistrarInfo";
            this.btnRegistrarInfo.Size = new System.Drawing.Size(123, 35);
            this.btnRegistrarInfo.TabIndex = 75;
            this.btnRegistrarInfo.Text = "Registrar informacion";
            this.btnRegistrarInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarInfo.UseVisualStyleBackColor = false;
            this.btnRegistrarInfo.Click += new System.EventHandler(this.btnRegistrarInfo_Click);
            // 
            // btnModificarInfo
            // 
            this.btnModificarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnModificarInfo.FlatAppearance.BorderSize = 0;
            this.btnModificarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnModificarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarInfo.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnModificarInfo.IconColor = System.Drawing.Color.Black;
            this.btnModificarInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarInfo.IconSize = 30;
            this.btnModificarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarInfo.Location = new System.Drawing.Point(319, 346);
            this.btnModificarInfo.Name = "btnModificarInfo";
            this.btnModificarInfo.Size = new System.Drawing.Size(123, 35);
            this.btnModificarInfo.TabIndex = 76;
            this.btnModificarInfo.Text = "Modificar Informacion";
            this.btnModificarInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarInfo.UseVisualStyleBackColor = false;
            this.btnModificarInfo.Click += new System.EventHandler(this.btnModificarInfo_Click);
            // 
            // btnEliminarInfo
            // 
            this.btnEliminarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEliminarInfo.FlatAppearance.BorderSize = 0;
            this.btnEliminarInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEliminarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEliminarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarInfo.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnEliminarInfo.IconColor = System.Drawing.Color.Black;
            this.btnEliminarInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarInfo.IconSize = 30;
            this.btnEliminarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarInfo.Location = new System.Drawing.Point(513, 346);
            this.btnEliminarInfo.Name = "btnEliminarInfo";
            this.btnEliminarInfo.Size = new System.Drawing.Size(123, 35);
            this.btnEliminarInfo.TabIndex = 77;
            this.btnEliminarInfo.Text = "Eliminar Informacion";
            this.btnEliminarInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarInfo.UseVisualStyleBackColor = false;
            this.btnEliminarInfo.Click += new System.EventHandler(this.btnEliminarInfo_Click);
            // 
            // dataGridInfoDrogueria
            // 
            this.dataGridInfoDrogueria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfoDrogueria.Location = new System.Drawing.Point(68, 91);
            this.dataGridInfoDrogueria.Name = "dataGridInfoDrogueria";
            this.dataGridInfoDrogueria.Size = new System.Drawing.Size(600, 115);
            this.dataGridInfoDrogueria.TabIndex = 78;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(65, 72);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(225, 16);
            this.labelAdvertencia.TabIndex = 79;
            this.labelAdvertencia.Text = "No hay productos registrados!!!";
            // 
            // FormAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAdvertencia);
            this.Controls.Add(this.dataGridInfoDrogueria);
            this.Controls.Add(this.btnEliminarInfo);
            this.Controls.Add(this.btnModificarInfo);
            this.Controls.Add(this.btnRegistrarInfo);
            this.Controls.Add(this.comboRegimen);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textPBX);
            this.Controls.Add(this.labelPBX);
            this.Controls.Add(this.labelRegimen);
            this.Controls.Add(this.textFraseDistintiva);
            this.Controls.Add(this.labelFraseDistintiva);
            this.Controls.Add(this.textNIT);
            this.Controls.Add(this.labelNIT);
            this.Controls.Add(this.textNombreDrogueria);
            this.Controls.Add(this.labelNombreDrogueria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBarraVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjustes";
            this.Text = "FormAjustes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfoDrogueria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label labelNombreDrogueria;
        private System.Windows.Forms.TextBox textNombreDrogueria;
        private System.Windows.Forms.TextBox textNIT;
        private System.Windows.Forms.Label labelNIT;
        private System.Windows.Forms.TextBox textFraseDistintiva;
        private System.Windows.Forms.Label labelFraseDistintiva;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.TextBox textPBX;
        private System.Windows.Forms.Label labelPBX;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboRegimen;
        private FontAwesome.Sharp.IconButton btnRegistrarInfo;
        private FontAwesome.Sharp.IconButton btnModificarInfo;
        private FontAwesome.Sharp.IconButton btnEliminarInfo;
        private System.Windows.Forms.DataGridView dataGridInfoDrogueria;
        private System.Windows.Forms.Label labelAdvertencia;
    }
}