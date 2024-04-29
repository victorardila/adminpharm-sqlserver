
namespace Presentacion
{
    partial class FormInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInicioSesion = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.linkLabelRestaurarContraseña = new System.Windows.Forms.LinkLabel();
            this.linkLabelRegistrarUsuario = new System.Windows.Forms.LinkLabel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.iconAdvertencia = new FontAwesome.Sharp.IconPictureBox();
            this.iconSeePasword = new FontAwesome.Sharp.IconPictureBox();
            this.iconNoSeePasword = new FontAwesome.Sharp.IconPictureBox();
            this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnAjustarServidor = new FontAwesome.Sharp.IconButton();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdvertencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSeePasword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNoSeePasword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(408, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.btnCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(379, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnMinimizar.Location = new System.Drawing.Point(355, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureLogo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 133);
            this.panel2.TabIndex = 1;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = global::Presentacion.Properties.Resources.Fondo;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(408, 133);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 133);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // labelInicioSesion
            // 
            this.labelInicioSesion.AutoSize = true;
            this.labelInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.labelInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicioSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInicioSesion.Location = new System.Drawing.Point(147, 165);
            this.labelInicioSesion.Name = "labelInicioSesion";
            this.labelInicioSesion.Size = new System.Drawing.Size(115, 20);
            this.labelInicioSesion.TabIndex = 1;
            this.labelInicioSesion.Text = "Iniciar sesion";
            // 
            // textBoxUser
            // 
            this.textBoxUser.AllowDrop = true;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUser.Location = new System.Drawing.Point(111, 191);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(202, 32);
            this.textBoxUser.TabIndex = 4;
            this.textBoxUser.Text = "@Usuario";
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPasword.Location = new System.Drawing.Point(111, 225);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(202, 26);
            this.textBoxPasword.TabIndex = 5;
            this.textBoxPasword.Text = "Contraseña";
            this.textBoxPasword.UseSystemPasswordChar = true;
            this.textBoxPasword.TextChanged += new System.EventHandler(this.textBoxPasword_TextChanged);
            this.textBoxPasword.Enter += new System.EventHandler(this.textBoxPasword_Enter);
            this.textBoxPasword.Leave += new System.EventHandler(this.textBoxPasword_Leave);
            // 
            // linkLabelRestaurarContraseña
            // 
            this.linkLabelRestaurarContraseña.AutoSize = true;
            this.linkLabelRestaurarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRestaurarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRestaurarContraseña.Location = new System.Drawing.Point(159, 288);
            this.linkLabelRestaurarContraseña.Name = "linkLabelRestaurarContraseña";
            this.linkLabelRestaurarContraseña.Size = new System.Drawing.Size(161, 16);
            this.linkLabelRestaurarContraseña.TabIndex = 11;
            this.linkLabelRestaurarContraseña.TabStop = true;
            this.linkLabelRestaurarContraseña.Text = "¿Olvidaste tu contraseña?";
            this.linkLabelRestaurarContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRestaurarContraseña_LinkClicked);
            // 
            // linkLabelRegistrarUsuario
            // 
            this.linkLabelRegistrarUsuario.AutoSize = true;
            this.linkLabelRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrarUsuario.Location = new System.Drawing.Point(128, 309);
            this.linkLabelRegistrarUsuario.Name = "linkLabelRegistrarUsuario";
            this.linkLabelRegistrarUsuario.Size = new System.Drawing.Size(186, 16);
            this.linkLabelRegistrarUsuario.TabIndex = 12;
            this.linkLabelRegistrarUsuario.TabStop = true;
            this.linkLabelRegistrarUsuario.Text = "¿No tienes cuenta? Registrate";
            this.linkLabelRegistrarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistrarUsuario_LinkClicked);
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.ForeColor = System.Drawing.Color.Maroon;
            this.labelAdvertencia.Location = new System.Drawing.Point(179, 262);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(64, 13);
            this.labelAdvertencia.TabIndex = 14;
            this.labelAdvertencia.Text = "Advertencia";
            this.labelAdvertencia.Visible = false;
            // 
            // iconAdvertencia
            // 
            this.iconAdvertencia.BackColor = System.Drawing.SystemColors.Control;
            this.iconAdvertencia.ForeColor = System.Drawing.Color.Maroon;
            this.iconAdvertencia.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconAdvertencia.IconColor = System.Drawing.Color.Maroon;
            this.iconAdvertencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAdvertencia.IconSize = 20;
            this.iconAdvertencia.Location = new System.Drawing.Point(156, 258);
            this.iconAdvertencia.Name = "iconAdvertencia";
            this.iconAdvertencia.Size = new System.Drawing.Size(20, 20);
            this.iconAdvertencia.TabIndex = 13;
            this.iconAdvertencia.TabStop = false;
            this.iconAdvertencia.Visible = false;
            // 
            // iconSeePasword
            // 
            this.iconSeePasword.BackColor = System.Drawing.Color.Transparent;
            this.iconSeePasword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSeePasword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSeePasword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconSeePasword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSeePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSeePasword.IconSize = 31;
            this.iconSeePasword.Location = new System.Drawing.Point(275, 223);
            this.iconSeePasword.Name = "iconSeePasword";
            this.iconSeePasword.Size = new System.Drawing.Size(38, 31);
            this.iconSeePasword.TabIndex = 10;
            this.iconSeePasword.TabStop = false;
            this.iconSeePasword.UseGdi = true;
            this.iconSeePasword.UseIconCache = true;
            this.iconSeePasword.Visible = false;
            this.iconSeePasword.Click += new System.EventHandler(this.iconSeePasword_Click);
            // 
            // iconNoSeePasword
            // 
            this.iconNoSeePasword.BackColor = System.Drawing.Color.Transparent;
            this.iconNoSeePasword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconNoSeePasword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconNoSeePasword.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconNoSeePasword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNoSeePasword.IconSize = 31;
            this.iconNoSeePasword.Location = new System.Drawing.Point(275, 223);
            this.iconNoSeePasword.Name = "iconNoSeePasword";
            this.iconNoSeePasword.Size = new System.Drawing.Size(38, 31);
            this.iconNoSeePasword.TabIndex = 9;
            this.iconNoSeePasword.TabStop = false;
            this.iconNoSeePasword.Click += new System.EventHandler(this.iconNoSeePasword_Click);
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.SystemColors.Control;
            this.iconPassword.ForeColor = System.Drawing.Color.Goldenrod;
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPassword.IconColor = System.Drawing.Color.Goldenrod;
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 27;
            this.iconPassword.Location = new System.Drawing.Point(84, 225);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(27, 31);
            this.iconPassword.TabIndex = 8;
            this.iconPassword.TabStop = false;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.SystemColors.Control;
            this.iconUser.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUser.IconColor = System.Drawing.Color.DarkOliveGreen;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 27;
            this.iconUser.Location = new System.Drawing.Point(84, 191);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(27, 32);
            this.iconUser.TabIndex = 7;
            this.iconUser.TabStop = false;
            // 
            // btnAjustarServidor
            // 
            this.btnAjustarServidor.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnAjustarServidor.IconColor = System.Drawing.Color.Black;
            this.btnAjustarServidor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjustarServidor.IconSize = 24;
            this.btnAjustarServidor.Location = new System.Drawing.Point(365, 162);
            this.btnAjustarServidor.Name = "btnAjustarServidor";
            this.btnAjustarServidor.Size = new System.Drawing.Size(38, 29);
            this.btnAjustarServidor.TabIndex = 15;
            this.btnAjustarServidor.UseVisualStyleBackColor = true;
            this.btnAjustarServidor.Visible = false;
            this.btnAjustarServidor.Click += new System.EventHandler(this.btnAjustarServidor_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnIngresar.BackgroundImage = global::Presentacion.Properties.Resources.Fondo2;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnIngresar.IconColor = System.Drawing.Color.Black;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 30;
            this.btnIngresar.Location = new System.Drawing.Point(132, 338);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(136, 44);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 397);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelInicioSesion);
            this.Controls.Add(this.btnAjustarServidor);
            this.Controls.Add(this.labelAdvertencia);
            this.Controls.Add(this.iconAdvertencia);
            this.Controls.Add(this.linkLabelRegistrarUsuario);
            this.Controls.Add(this.linkLabelRestaurarContraseña);
            this.Controls.Add(this.iconSeePasword);
            this.Controls.Add(this.iconNoSeePasword);
            this.Controls.Add(this.iconPassword);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicioSesion";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormInicioSesion_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdvertencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSeePasword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNoSeePasword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInicioSesion;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPasword;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private FontAwesome.Sharp.IconPictureBox iconNoSeePasword;
        private FontAwesome.Sharp.IconPictureBox iconSeePasword;
        private System.Windows.Forms.LinkLabel linkLabelRestaurarContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelRegistrarUsuario;
        private FontAwesome.Sharp.IconPictureBox iconAdvertencia;
        private System.Windows.Forms.Label labelAdvertencia;
        private FontAwesome.Sharp.IconButton btnAjustarServidor;
        private FontAwesome.Sharp.IconButton btnIngresar;
    }
}