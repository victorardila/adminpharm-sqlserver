
namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelInicioSesion = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPasword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
            this.iconNoSeePasword = new FontAwesome.Sharp.IconPictureBox();
            this.iconSeePasword = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNoSeePasword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSeePasword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelInicioSesion);
            this.panel2.Controls.Add(this.pictureLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 146);
            this.panel2.TabIndex = 1;
            // 
            // labelInicioSesion
            // 
            this.labelInicioSesion.AutoSize = true;
            this.labelInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioSesion.Location = new System.Drawing.Point(129, 102);
            this.labelInicioSesion.Name = "labelInicioSesion";
            this.labelInicioSesion.Size = new System.Drawing.Size(115, 20);
            this.labelInicioSesion.TabIndex = 1;
            this.labelInicioSesion.Text = "Iniciar sesion";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(133, 6);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(110, 84);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(58, 230);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(66, 16);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Usuario:";
            // 
            // labelPasword
            // 
            this.labelPasword.AutoSize = true;
            this.labelPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasword.Location = new System.Drawing.Point(58, 258);
            this.labelPasword.Name = "labelPasword";
            this.labelPasword.Size = new System.Drawing.Size(91, 16);
            this.labelPasword.TabIndex = 3;
            this.labelPasword.Text = "Contraseña:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(150, 225);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(160, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(150, 258);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(160, 20);
            this.textBoxPasword.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(150, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 20;
            this.btnMinimizar.Location = new System.Drawing.Point(322, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(346, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.SystemColors.Control;
            this.iconUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 21;
            this.iconUser.Location = new System.Drawing.Point(36, 228);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(21, 22);
            this.iconUser.TabIndex = 7;
            this.iconUser.TabStop = false;
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.SystemColors.Control;
            this.iconPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPassword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 21;
            this.iconPassword.Location = new System.Drawing.Point(36, 256);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(21, 22);
            this.iconPassword.TabIndex = 8;
            this.iconPassword.TabStop = false;
            // 
            // iconNoSeePasword
            // 
            this.iconNoSeePasword.BackColor = System.Drawing.SystemColors.Control;
            this.iconNoSeePasword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconNoSeePasword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconNoSeePasword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconNoSeePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNoSeePasword.IconSize = 21;
            this.iconNoSeePasword.Location = new System.Drawing.Point(316, 256);
            this.iconNoSeePasword.Name = "iconNoSeePasword";
            this.iconNoSeePasword.Size = new System.Drawing.Size(21, 22);
            this.iconNoSeePasword.TabIndex = 9;
            this.iconNoSeePasword.TabStop = false;
            this.iconNoSeePasword.Click += new System.EventHandler(this.iconNoSeePasword_Click);
            // 
            // iconSeePasword
            // 
            this.iconSeePasword.BackColor = System.Drawing.SystemColors.Control;
            this.iconSeePasword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSeePasword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconSeePasword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSeePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSeePasword.IconSize = 21;
            this.iconSeePasword.Location = new System.Drawing.Point(316, 256);
            this.iconSeePasword.Name = "iconSeePasword";
            this.iconSeePasword.Size = new System.Drawing.Size(21, 22);
            this.iconSeePasword.TabIndex = 10;
            this.iconSeePasword.TabStop = false;
            this.iconSeePasword.Click += new System.EventHandler(this.iconSeePasword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 375);
            this.Controls.Add(this.iconSeePasword);
            this.Controls.Add(this.iconNoSeePasword);
            this.Controls.Add(this.iconPassword);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPasword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNoSeePasword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSeePasword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInicioSesion;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPasword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private FontAwesome.Sharp.IconPictureBox iconNoSeePasword;
        private FontAwesome.Sharp.IconPictureBox iconSeePasword;
    }
}