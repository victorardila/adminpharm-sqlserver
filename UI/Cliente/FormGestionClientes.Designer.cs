
namespace Presentacion
{
    partial class FormGestionClientes
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
            this.panelConsultaDeClientes = new System.Windows.Forms.Panel();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.textTotalFarmacos = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.dataGridFarmacos = new System.Windows.Forms.DataGridView();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelConsultaDeClientes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRegistrarCliente = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelRegistroDeEmpleados = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAbrirCaja = new FontAwesome.Sharp.IconButton();
            this.comboTipoDeId = new System.Windows.Forms.ComboBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTipoId = new System.Windows.Forms.Label();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panelConsultaDeClientes.SuspendLayout();
            this.panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRegistrarCliente.SuspendLayout();
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
            this.btnVolver.Location = new System.Drawing.Point(21, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 35);
            this.btnVolver.TabIndex = 34;
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
            this.panelBarraVolver.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestionar Clientes";
            // 
            // panelConsultaDeClientes
            // 
            this.panelConsultaDeClientes.Controls.Add(this.panelSubDataGridFarmacos);
            this.panelConsultaDeClientes.Controls.Add(this.dataGridFarmacos);
            this.panelConsultaDeClientes.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeClientes.Location = new System.Drawing.Point(3, 3);
            this.panelConsultaDeClientes.Name = "panelConsultaDeClientes";
            this.panelConsultaDeClientes.Size = new System.Drawing.Size(750, 248);
            this.panelConsultaDeClientes.TabIndex = 50;
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalFarmacos);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalFarmacos);
            this.panelSubDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(0, 226);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(750, 22);
            this.panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // textTotalFarmacos
            // 
            this.textTotalFarmacos.Location = new System.Drawing.Point(95, 0);
            this.textTotalFarmacos.Name = "textTotalFarmacos";
            this.textTotalFarmacos.Size = new System.Drawing.Size(47, 20);
            this.textTotalFarmacos.TabIndex = 49;
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
            // dataGridFarmacos
            // 
            this.dataGridFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFarmacos.Location = new System.Drawing.Point(0, 24);
            this.dataGridFarmacos.Name = "dataGridFarmacos";
            this.dataGridFarmacos.Size = new System.Drawing.Size(750, 224);
            this.dataGridFarmacos.TabIndex = 50;
            // 
            // panelTituloDataGridFarmacos
            // 
            this.panelTituloDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboBox1);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltro);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelConsultaDeClientes);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(750, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(223, 6);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(32, 13);
            this.labelFiltro.TabIndex = 50;
            this.labelFiltro.Text = "Filtro:";
            // 
            // labelConsultaDeClientes
            // 
            this.labelConsultaDeClientes.AutoSize = true;
            this.labelConsultaDeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultaDeClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelConsultaDeClientes.Location = new System.Drawing.Point(3, 4);
            this.labelConsultaDeClientes.Name = "labelConsultaDeClientes";
            this.labelConsultaDeClientes.Size = new System.Drawing.Size(133, 16);
            this.labelConsultaDeClientes.TabIndex = 51;
            this.labelConsultaDeClientes.Text = "Consultar Clientes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelRegistrarCliente);
            this.panel2.Controls.Add(this.panelConsultaDeClientes);
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 463);
            this.panel2.TabIndex = 52;
            // 
            // panelRegistrarCliente
            // 
            this.panelRegistrarCliente.Controls.Add(this.label3);
            this.panelRegistrarCliente.Controls.Add(this.label2);
            this.panelRegistrarCliente.Controls.Add(this.dateTimePicker1);
            this.panelRegistrarCliente.Controls.Add(this.labelFechaDeNacimiento);
            this.panelRegistrarCliente.Controls.Add(this.comboSexo);
            this.panelRegistrarCliente.Controls.Add(this.labelSexo);
            this.panelRegistrarCliente.Controls.Add(this.labelRegistroDeEmpleados);
            this.panelRegistrarCliente.Controls.Add(this.iconButton1);
            this.panelRegistrarCliente.Controls.Add(this.btnAbrirCaja);
            this.panelRegistrarCliente.Controls.Add(this.comboTipoDeId);
            this.panelRegistrarCliente.Controls.Add(this.textCorreo);
            this.panelRegistrarCliente.Controls.Add(this.textTelefono);
            this.panelRegistrarCliente.Controls.Add(this.textDireccion);
            this.panelRegistrarCliente.Controls.Add(this.textIdentificacion);
            this.panelRegistrarCliente.Controls.Add(this.textApellido);
            this.panelRegistrarCliente.Controls.Add(this.textNombre);
            this.panelRegistrarCliente.Controls.Add(this.labelCorreo);
            this.panelRegistrarCliente.Controls.Add(this.labelTelefono);
            this.panelRegistrarCliente.Controls.Add(this.labelDireccion);
            this.panelRegistrarCliente.Controls.Add(this.labelTipoId);
            this.panelRegistrarCliente.Controls.Add(this.labelIdentificacion);
            this.panelRegistrarCliente.Controls.Add(this.labelApellido);
            this.panelRegistrarCliente.Controls.Add(this.labelNombre);
            this.panelRegistrarCliente.Location = new System.Drawing.Point(3, 257);
            this.panelRegistrarCliente.Name = "panelRegistrarCliente";
            this.panelRegistrarCliente.Size = new System.Drawing.Size(744, 193);
            this.panelRegistrarCliente.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(646, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "#                   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(482, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Codigo de clientes:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // labelFechaDeNacimiento
            // 
            this.labelFechaDeNacimiento.AutoSize = true;
            this.labelFechaDeNacimiento.Location = new System.Drawing.Point(12, 89);
            this.labelFechaDeNacimiento.Name = "labelFechaDeNacimiento";
            this.labelFechaDeNacimiento.Size = new System.Drawing.Size(109, 13);
            this.labelFechaDeNacimiento.TabIndex = 56;
            this.labelFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Location = new System.Drawing.Point(358, 85);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(59, 21);
            this.comboSexo.TabIndex = 55;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(322, 89);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 54;
            this.labelSexo.Text = "Sexo:";
            // 
            // labelRegistroDeEmpleados
            // 
            this.labelRegistroDeEmpleados.AutoSize = true;
            this.labelRegistroDeEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroDeEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelRegistroDeEmpleados.Location = new System.Drawing.Point(4, 3);
            this.labelRegistroDeEmpleados.Name = "labelRegistroDeEmpleados";
            this.labelRegistroDeEmpleados.Size = new System.Drawing.Size(130, 16);
            this.labelRegistroDeEmpleados.TabIndex = 53;
            this.labelRegistroDeEmpleados.Text = "Registrar clientes";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(485, 100);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(110, 35);
            this.iconButton1.TabIndex = 53;
            this.iconButton1.Text = "   Modificar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbrirCaja.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnAbrirCaja.IconColor = System.Drawing.Color.Black;
            this.btnAbrirCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirCaja.IconSize = 30;
            this.btnAbrirCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCaja.Location = new System.Drawing.Point(485, 60);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(110, 35);
            this.btnAbrirCaja.TabIndex = 52;
            this.btnAbrirCaja.Text = "   Registrar";
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            // 
            // comboTipoDeId
            // 
            this.comboTipoDeId.FormattingEnabled = true;
            this.comboTipoDeId.Location = new System.Drawing.Point(306, 54);
            this.comboTipoDeId.Name = "comboTipoDeId";
            this.comboTipoDeId.Size = new System.Drawing.Size(50, 21);
            this.comboTipoDeId.TabIndex = 13;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(60, 154);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(139, 20);
            this.textCorreo.TabIndex = 12;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(266, 126);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(139, 20);
            this.textTelefono.TabIndex = 11;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(65, 123);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(139, 20);
            this.textDireccion.TabIndex = 10;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(91, 55);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(139, 20);
            this.textIdentificacion.TabIndex = 9;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(266, 28);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(151, 20);
            this.textApellido.TabIndex = 8;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(65, 28);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(139, 20);
            this.textNombre.TabIndex = 7;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(13, 157);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(41, 13);
            this.labelCorreo.TabIndex = 6;
            this.labelCorreo.Text = "Correo:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(213, 130);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Telefono:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(12, 126);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 4;
            this.labelDireccion.Text = "Direccion:";
            // 
            // labelTipoId
            // 
            this.labelTipoId.AutoSize = true;
            this.labelTipoId.Location = new System.Drawing.Point(239, 57);
            this.labelTipoId.Name = "labelTipoId";
            this.labelTipoId.Size = new System.Drawing.Size(60, 13);
            this.labelTipoId.TabIndex = 3;
            this.labelTipoId.Text = "Tipo de ID:";
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(12, 58);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.labelIdentificacion.TabIndex = 2;
            this.labelIdentificacion.Text = "Identificacion:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(213, 31);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 31);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // FormGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelBarraVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionClientes";
            this.Text = "FormGestionClientes";
            this.panelConsultaDeClientes.ResumeLayout(false);
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFarmacos)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelRegistrarCliente.ResumeLayout(false);
            this.panelRegistrarCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Panel panelBarraVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConsultaDeClientes;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.TextBox textTotalFarmacos;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.DataGridView dataGridFarmacos;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelConsultaDeClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRegistrarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFechaDeNacimiento;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelRegistroDeEmpleados;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAbrirCaja;
        private System.Windows.Forms.ComboBox comboTipoDeId;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTipoId;
        private System.Windows.Forms.Label labelIdentificacion;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
    }
}