
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelConsultaDeClientes = new System.Windows.Forms.Panel();
            this.panelSubDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.textTotalMujeres = new System.Windows.Forms.TextBox();
            this.labelTotalMujeres = new System.Windows.Forms.Label();
            this.textTotalHombres = new System.Windows.Forms.TextBox();
            this.labelTotalHombres = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.labelTotalFarmacos = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTituloDataGridFarmacos = new System.Windows.Forms.Panel();
            this.labelAdvertenciaCliente = new System.Windows.Forms.Label();
            this.btnCloseCliente = new FontAwesome.Sharp.IconPictureBox();
            this.textSearchCliente = new System.Windows.Forms.TextBox();
            this.btnSearchCliente = new FontAwesome.Sharp.IconPictureBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.labelConsultaDeClientes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRegistrarCliente = new System.Windows.Forms.Panel();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.dateTimeFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDeNacimiento = new System.Windows.Forms.Label();
            this.comboSexoCliente = new System.Windows.Forms.ComboBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelRegistroDeEmpleados = new System.Windows.Forms.Label();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelConsultaDeClientes.SuspendLayout();
            this.panelSubDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.panelTituloDataGridFarmacos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCliente)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelRegistrarCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.btnVolver.IconColor = System.Drawing.Color.White;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 30;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(21, 1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 34);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestionar Clientes";
            // 
            // panelConsultaDeClientes
            // 
            this.panelConsultaDeClientes.Controls.Add(this.panelSubDataGridFarmacos);
            this.panelConsultaDeClientes.Controls.Add(this.dataGridClientes);
            this.panelConsultaDeClientes.Controls.Add(this.panelTituloDataGridFarmacos);
            this.panelConsultaDeClientes.Location = new System.Drawing.Point(3, 3);
            this.panelConsultaDeClientes.Name = "panelConsultaDeClientes";
            this.panelConsultaDeClientes.Size = new System.Drawing.Size(773, 248);
            this.panelConsultaDeClientes.TabIndex = 50;
            // 
            // panelSubDataGridFarmacos
            // 
            this.panelSubDataGridFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubDataGridFarmacos.Controls.Add(this.labelAdvertencia);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalMujeres);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalMujeres);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotalHombres);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalHombres);
            this.panelSubDataGridFarmacos.Controls.Add(this.textTotal);
            this.panelSubDataGridFarmacos.Controls.Add(this.labelTotalFarmacos);
            this.panelSubDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubDataGridFarmacos.Location = new System.Drawing.Point(0, 226);
            this.panelSubDataGridFarmacos.Name = "panelSubDataGridFarmacos";
            this.panelSubDataGridFarmacos.Size = new System.Drawing.Size(773, 22);
            this.panelSubDataGridFarmacos.TabIndex = 51;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(489, 1);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(210, 16);
            this.labelAdvertencia.TabIndex = 62;
            this.labelAdvertencia.Text = "No hay clientes registrados!!!";
            this.labelAdvertencia.Visible = false;
            // 
            // textTotalMujeres
            // 
            this.textTotalMujeres.Location = new System.Drawing.Point(369, 0);
            this.textTotalMujeres.Name = "textTotalMujeres";
            this.textTotalMujeres.Size = new System.Drawing.Size(47, 20);
            this.textTotalMujeres.TabIndex = 60;
            this.textTotalMujeres.Text = "0";
            // 
            // labelTotalMujeres
            // 
            this.labelTotalMujeres.AutoSize = true;
            this.labelTotalMujeres.Location = new System.Drawing.Point(298, 4);
            this.labelTotalMujeres.Name = "labelTotalMujeres";
            this.labelTotalMujeres.Size = new System.Drawing.Size(73, 13);
            this.labelTotalMujeres.TabIndex = 61;
            this.labelTotalMujeres.Text = "Total mujeres:";
            // 
            // textTotalHombres
            // 
            this.textTotalHombres.Location = new System.Drawing.Point(233, 0);
            this.textTotalHombres.Name = "textTotalHombres";
            this.textTotalHombres.Size = new System.Drawing.Size(47, 20);
            this.textTotalHombres.TabIndex = 58;
            this.textTotalHombres.Text = "0";
            // 
            // labelTotalHombres
            // 
            this.labelTotalHombres.AutoSize = true;
            this.labelTotalHombres.Location = new System.Drawing.Point(157, 4);
            this.labelTotalHombres.Name = "labelTotalHombres";
            this.labelTotalHombres.Size = new System.Drawing.Size(77, 13);
            this.labelTotalHombres.TabIndex = 59;
            this.labelTotalHombres.Text = "Total hombres:";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(97, 0);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(47, 20);
            this.textTotal.TabIndex = 56;
            this.textTotal.Text = "0";
            // 
            // labelTotalFarmacos
            // 
            this.labelTotalFarmacos.AutoSize = true;
            this.labelTotalFarmacos.Location = new System.Drawing.Point(6, 5);
            this.labelTotalFarmacos.Name = "labelTotalFarmacos";
            this.labelTotalFarmacos.Size = new System.Drawing.Size(93, 13);
            this.labelTotalFarmacos.TabIndex = 57;
            this.labelTotalFarmacos.Text = "Total Registrados:";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataGridClientes.Location = new System.Drawing.Point(0, 24);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersVisible = false;
            this.dataGridClientes.Size = new System.Drawing.Size(770, 224);
            this.dataGridClientes.TabIndex = 50;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
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
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnCloseCliente);
            this.panelTituloDataGridFarmacos.Controls.Add(this.textSearchCliente);
            this.panelTituloDataGridFarmacos.Controls.Add(this.btnSearchCliente);
            this.panelTituloDataGridFarmacos.Controls.Add(this.comboSexo);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelFiltro);
            this.panelTituloDataGridFarmacos.Controls.Add(this.labelConsultaDeClientes);
            this.panelTituloDataGridFarmacos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDataGridFarmacos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDataGridFarmacos.Name = "panelTituloDataGridFarmacos";
            this.panelTituloDataGridFarmacos.Size = new System.Drawing.Size(773, 24);
            this.panelTituloDataGridFarmacos.TabIndex = 49;
            // 
            // labelAdvertenciaCliente
            // 
            this.labelAdvertenciaCliente.AutoSize = true;
            this.labelAdvertenciaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertenciaCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertenciaCliente.Location = new System.Drawing.Point(406, 3);
            this.labelAdvertenciaCliente.Name = "labelAdvertenciaCliente";
            this.labelAdvertenciaCliente.Size = new System.Drawing.Size(157, 16);
            this.labelAdvertenciaCliente.TabIndex = 82;
            this.labelAdvertenciaCliente.Text = "No hay coincidencias";
            this.labelAdvertenciaCliente.Visible = false;
            // 
            // btnCloseCliente
            // 
            this.btnCloseCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCloseCliente.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseCliente.IconColor = System.Drawing.Color.DarkRed;
            this.btnCloseCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseCliente.IconSize = 18;
            this.btnCloseCliente.Location = new System.Drawing.Point(705, 2);
            this.btnCloseCliente.Name = "btnCloseCliente";
            this.btnCloseCliente.Size = new System.Drawing.Size(18, 18);
            this.btnCloseCliente.TabIndex = 81;
            this.btnCloseCliente.TabStop = false;
            this.btnCloseCliente.Visible = false;
            this.btnCloseCliente.Click += new System.EventHandler(this.btnCloseCliente_Click);
            // 
            // textSearchCliente
            // 
            this.textSearchCliente.Location = new System.Drawing.Point(578, 1);
            this.textSearchCliente.Name = "textSearchCliente";
            this.textSearchCliente.Size = new System.Drawing.Size(127, 20);
            this.textSearchCliente.TabIndex = 79;
            this.textSearchCliente.Text = "Buscar identificacion";
            this.textSearchCliente.Visible = false;
            this.textSearchCliente.TextChanged += new System.EventHandler(this.textSearchCliente_TextChanged);
            this.textSearchCliente.Enter += new System.EventHandler(this.textSearchCliente_Enter);
            this.textSearchCliente.Leave += new System.EventHandler(this.textSearchCliente_Leave);
            // 
            // btnSearchCliente
            // 
            this.btnSearchCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchCliente.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchCliente.IconSize = 20;
            this.btnSearchCliente.Location = new System.Drawing.Point(724, 1);
            this.btnSearchCliente.Name = "btnSearchCliente";
            this.btnSearchCliente.Size = new System.Drawing.Size(20, 20);
            this.btnSearchCliente.TabIndex = 80;
            this.btnSearchCliente.TabStop = false;
            this.btnSearchCliente.Click += new System.EventHandler(this.btnSearchCliente_Click);
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Todos",
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(261, 1);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(86, 21);
            this.comboSexo.TabIndex = 52;
            this.comboSexo.Text = "Todos";
            this.comboSexo.SelectedIndexChanged += new System.EventHandler(this.comboSexo_SelectedIndexChanged);
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
            this.panel2.Size = new System.Drawing.Size(776, 453);
            this.panel2.TabIndex = 52;
            // 
            // panelRegistrarCliente
            // 
            this.panelRegistrarCliente.Controls.Add(this.labelCodigoCliente);
            this.panelRegistrarCliente.Controls.Add(this.labelCodigo);
            this.panelRegistrarCliente.Controls.Add(this.dateTimeFechaDeNacimiento);
            this.panelRegistrarCliente.Controls.Add(this.labelFechaDeNacimiento);
            this.panelRegistrarCliente.Controls.Add(this.comboSexoCliente);
            this.panelRegistrarCliente.Controls.Add(this.labelSexo);
            this.panelRegistrarCliente.Controls.Add(this.labelRegistroDeEmpleados);
            this.panelRegistrarCliente.Controls.Add(this.btnModificar);
            this.panelRegistrarCliente.Controls.Add(this.btnRegistrar);
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
            this.panelRegistrarCliente.Location = new System.Drawing.Point(3, 251);
            this.panelRegistrarCliente.Name = "panelRegistrarCliente";
            this.panelRegistrarCliente.Size = new System.Drawing.Size(773, 199);
            this.panelRegistrarCliente.TabIndex = 51;
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelCodigoCliente.Location = new System.Drawing.Point(646, 3);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(92, 16);
            this.labelCodigoCliente.TabIndex = 59;
            this.labelCodigoCliente.Text = "#                   ";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelCodigo.Location = new System.Drawing.Point(482, 3);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(142, 16);
            this.labelCodigo.TabIndex = 58;
            this.labelCodigo.Text = "Codigo de clientes:";
            // 
            // dateTimeFechaDeNacimiento
            // 
            this.dateTimeFechaDeNacimiento.Location = new System.Drawing.Point(121, 86);
            this.dateTimeFechaDeNacimiento.Name = "dateTimeFechaDeNacimiento";
            this.dateTimeFechaDeNacimiento.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFechaDeNacimiento.TabIndex = 57;
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
            // comboSexoCliente
            // 
            this.comboSexoCliente.FormattingEnabled = true;
            this.comboSexoCliente.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexoCliente.Location = new System.Drawing.Point(358, 85);
            this.comboSexoCliente.Name = "comboSexoCliente";
            this.comboSexoCliente.Size = new System.Drawing.Size(59, 21);
            this.comboSexoCliente.TabIndex = 55;
            this.comboSexoCliente.Text = "M";
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
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(485, 100);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 35);
            this.btnModificar.TabIndex = 53;
            this.btnModificar.Text = "   Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 30;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(485, 60);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 35);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Text = "   Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // comboTipoDeId
            // 
            this.comboTipoDeId.FormattingEnabled = true;
            this.comboTipoDeId.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.comboTipoDeId.Location = new System.Drawing.Point(306, 54);
            this.comboTipoDeId.Name = "comboTipoDeId";
            this.comboTipoDeId.Size = new System.Drawing.Size(50, 21);
            this.comboTipoDeId.TabIndex = 13;
            this.comboTipoDeId.Text = "CC";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 36);
            this.panel1.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panel3.Location = new System.Drawing.Point(10, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 35);
            this.panel3.TabIndex = 54;
            // 
            // FormGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionClientes";
            this.Text = "FormGestionClientes";
            this.panelConsultaDeClientes.ResumeLayout(false);
            this.panelSubDataGridFarmacos.ResumeLayout(false);
            this.panelSubDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.panelTituloDataGridFarmacos.ResumeLayout(false);
            this.panelTituloDataGridFarmacos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelRegistrarCliente.ResumeLayout(false);
            this.panelRegistrarCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelConsultaDeClientes;
        private System.Windows.Forms.Panel panelSubDataGridFarmacos;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Panel panelTituloDataGridFarmacos;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.Label labelConsultaDeClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRegistrarCliente;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.DateTimePicker dateTimeFechaDeNacimiento;
        private System.Windows.Forms.Label labelFechaDeNacimiento;
        private System.Windows.Forms.ComboBox comboSexoCliente;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelRegistroDeEmpleados;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
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
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox textTotalMujeres;
        private System.Windows.Forms.Label labelTotalMujeres;
        private System.Windows.Forms.TextBox textTotalHombres;
        private System.Windows.Forms.Label labelTotalHombres;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelTotalFarmacos;
        private System.Windows.Forms.Label labelAdvertenciaCliente;
        private FontAwesome.Sharp.IconPictureBox btnCloseCliente;
        private System.Windows.Forms.TextBox textSearchCliente;
        private FontAwesome.Sharp.IconPictureBox btnSearchCliente;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}