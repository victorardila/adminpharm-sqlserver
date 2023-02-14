
namespace Presentacion
{
    partial class FormRegistrarNevera
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
            this.textNumeroNevera = new System.Windows.Forms.TextBox();
            this.btnRegistrarEstante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitleCaja = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuTop.Size = new System.Drawing.Size(507, 26);
            this.menuTop.TabIndex = 4;
            this.menuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuTop_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(479, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // textNumeroNevera
            // 
            this.textNumeroNevera.BackColor = System.Drawing.SystemColors.Control;
            this.textNumeroNevera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumeroNevera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroNevera.ForeColor = System.Drawing.Color.Black;
            this.textNumeroNevera.Location = new System.Drawing.Point(312, 127);
            this.textNumeroNevera.Name = "textNumeroNevera";
            this.textNumeroNevera.Size = new System.Drawing.Size(115, 24);
            this.textNumeroNevera.TabIndex = 58;
            this.textNumeroNevera.Text = "0";
            // 
            // btnRegistrarEstante
            // 
            this.btnRegistrarEstante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnRegistrarEstante.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEstante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrarEstante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegistrarEstante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarEstante.Location = new System.Drawing.Point(194, 173);
            this.btnRegistrarEstante.Name = "btnRegistrarEstante";
            this.btnRegistrarEstante.Size = new System.Drawing.Size(172, 23);
            this.btnRegistrarEstante.TabIndex = 57;
            this.btnRegistrarEstante.Text = "Registrar estante";
            this.btnRegistrarEstante.UseVisualStyleBackColor = false;
            this.btnRegistrarEstante.Click += new System.EventHandler(this.btnRegistrarEstante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Digite el numero de neveras:";
            // 
            // labelTitleCaja
            // 
            this.labelTitleCaja.AutoSize = true;
            this.labelTitleCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleCaja.ForeColor = System.Drawing.Color.Black;
            this.labelTitleCaja.Location = new System.Drawing.Point(190, 64);
            this.labelTitleCaja.Name = "labelTitleCaja";
            this.labelTitleCaja.Size = new System.Drawing.Size(239, 24);
            this.labelTitleCaja.TabIndex = 55;
            this.labelTitleCaja.Text = "REGISTRO DE NEVERA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources._1055138;
            this.pictureBox1.Location = new System.Drawing.Point(74, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrarNevera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 205);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textNumeroNevera);
            this.Controls.Add(this.btnRegistrarEstante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitleCaja);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarNevera";
            this.Text = "FormRegistrarNevera";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegistrarNevera_MouseDown);
            this.menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textNumeroNevera;
        private System.Windows.Forms.Button btnRegistrarEstante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitleCaja;
    }
}