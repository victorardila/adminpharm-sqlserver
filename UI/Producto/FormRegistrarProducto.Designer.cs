
namespace Presentacion
{
    partial class FormRegistrarProducto
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
            this.panelRegistroDeProductos = new System.Windows.Forms.Panel();
            this.labelNumeroNeveras = new System.Windows.Forms.Label();
            this.labelNumeroVitrinas = new System.Windows.Forms.Label();
            this.labelNumeroEstantes = new System.Windows.Forms.Label();
            this.labelNeveras = new System.Windows.Forms.Label();
            this.labelVitrinas = new System.Windows.Forms.Label();
            this.labelEstantes = new System.Windows.Forms.Label();
            this.panelPrecioNegocio = new System.Windows.Forms.Panel();
            this.textPrecioNegocio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelUbicacion = new System.Windows.Forms.Panel();
            this.checkedNevera = new System.Windows.Forms.CheckedListBox();
            this.checkedVitrina = new System.Windows.Forms.CheckedListBox();
            this.checkedEstante = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboUbicacion = new System.Windows.Forms.ComboBox();
            this.labelNumeroUbicacion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.comboLaboratorio = new System.Windows.Forms.ComboBox();
            this.labelLaboratorio = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.textDetalle = new System.Windows.Forms.TextBox();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.comboVia = new System.Windows.Forms.ComboBox();
            this.panelTituloDeRegistroProductos = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textReferencia = new System.Windows.Forms.TextBox();
            this.labelReferencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombreFarmaceutico = new System.Windows.Forms.TextBox();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.dateTimeFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelVia = new System.Windows.Forms.Label();
            this.labelFechaVencimiento = new System.Windows.Forms.Label();
            this.textLote = new System.Windows.Forms.TextBox();
            this.dateTimeFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.labelLote = new System.Windows.Forms.Label();
            this.panelValores = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrecioDeNegocio = new System.Windows.Forms.Label();
            this.textPrecioCaja = new System.Windows.Forms.TextBox();
            this.textPrecioUnidad = new System.Windows.Forms.TextBox();
            this.textPrecioBlister = new System.Windows.Forms.TextBox();
            this.labelPorcentajeDeVenta = new System.Windows.Forms.Label();
            this.menuTop.SuspendLayout();
            this.panelRegistroDeProductos.SuspendLayout();
            this.panelPrecioNegocio.SuspendLayout();
            this.panelUbicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTituloDeRegistroProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panelValores.SuspendLayout();
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
            this.menuTop.Size = new System.Drawing.Size(548, 26);
            this.menuTop.TabIndex = 3;
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
            this.btnCerrar.Location = new System.Drawing.Point(520, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelRegistroDeProductos
            // 
            this.panelRegistroDeProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistroDeProductos.Controls.Add(this.labelNumeroNeveras);
            this.panelRegistroDeProductos.Controls.Add(this.labelNumeroVitrinas);
            this.panelRegistroDeProductos.Controls.Add(this.labelNumeroEstantes);
            this.panelRegistroDeProductos.Controls.Add(this.labelNeveras);
            this.panelRegistroDeProductos.Controls.Add(this.labelVitrinas);
            this.panelRegistroDeProductos.Controls.Add(this.labelEstantes);
            this.panelRegistroDeProductos.Controls.Add(this.panelPrecioNegocio);
            this.panelRegistroDeProductos.Controls.Add(this.panelUbicacion);
            this.panelRegistroDeProductos.Controls.Add(this.pictureBox2);
            this.panelRegistroDeProductos.Controls.Add(this.pictureBox1);
            this.panelRegistroDeProductos.Controls.Add(this.labelAdvertencia);
            this.panelRegistroDeProductos.Controls.Add(this.comboLaboratorio);
            this.panelRegistroDeProductos.Controls.Add(this.labelLaboratorio);
            this.panelRegistroDeProductos.Controls.Add(this.comboTipo);
            this.panelRegistroDeProductos.Controls.Add(this.labelTipo);
            this.panelRegistroDeProductos.Controls.Add(this.label1);
            this.panelRegistroDeProductos.Controls.Add(this.textCantidad);
            this.panelRegistroDeProductos.Controls.Add(this.btnModificar);
            this.panelRegistroDeProductos.Controls.Add(this.btnRegistrar);
            this.panelRegistroDeProductos.Controls.Add(this.textDetalle);
            this.panelRegistroDeProductos.Controls.Add(this.labelDetalle);
            this.panelRegistroDeProductos.Controls.Add(this.comboVia);
            this.panelRegistroDeProductos.Controls.Add(this.panelTituloDeRegistroProductos);
            this.panelRegistroDeProductos.Controls.Add(this.textReferencia);
            this.panelRegistroDeProductos.Controls.Add(this.labelReferencia);
            this.panelRegistroDeProductos.Controls.Add(this.label2);
            this.panelRegistroDeProductos.Controls.Add(this.textNombreFarmaceutico);
            this.panelRegistroDeProductos.Controls.Add(this.labelFechaRegistro);
            this.panelRegistroDeProductos.Controls.Add(this.dateTimeFechaRegistro);
            this.panelRegistroDeProductos.Controls.Add(this.labelVia);
            this.panelRegistroDeProductos.Controls.Add(this.labelFechaVencimiento);
            this.panelRegistroDeProductos.Controls.Add(this.textLote);
            this.panelRegistroDeProductos.Controls.Add(this.dateTimeFechaVencimiento);
            this.panelRegistroDeProductos.Controls.Add(this.labelLote);
            this.panelRegistroDeProductos.Controls.Add(this.panelValores);
            this.panelRegistroDeProductos.Location = new System.Drawing.Point(0, 24);
            this.panelRegistroDeProductos.Name = "panelRegistroDeProductos";
            this.panelRegistroDeProductos.Size = new System.Drawing.Size(548, 456);
            this.panelRegistroDeProductos.TabIndex = 49;
            this.panelRegistroDeProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistroDeProductos_MouseDown);
            // 
            // labelNumeroNeveras
            // 
            this.labelNumeroNeveras.AutoSize = true;
            this.labelNumeroNeveras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroNeveras.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelNumeroNeveras.Location = new System.Drawing.Point(503, 92);
            this.labelNumeroNeveras.Name = "labelNumeroNeveras";
            this.labelNumeroNeveras.Size = new System.Drawing.Size(12, 13);
            this.labelNumeroNeveras.TabIndex = 84;
            this.labelNumeroNeveras.Text = "*";
            // 
            // labelNumeroVitrinas
            // 
            this.labelNumeroVitrinas.AutoSize = true;
            this.labelNumeroVitrinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroVitrinas.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelNumeroVitrinas.Location = new System.Drawing.Point(503, 73);
            this.labelNumeroVitrinas.Name = "labelNumeroVitrinas";
            this.labelNumeroVitrinas.Size = new System.Drawing.Size(12, 13);
            this.labelNumeroVitrinas.TabIndex = 83;
            this.labelNumeroVitrinas.Text = "*";
            // 
            // labelNumeroEstantes
            // 
            this.labelNumeroEstantes.AutoSize = true;
            this.labelNumeroEstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroEstantes.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelNumeroEstantes.Location = new System.Drawing.Point(503, 56);
            this.labelNumeroEstantes.Name = "labelNumeroEstantes";
            this.labelNumeroEstantes.Size = new System.Drawing.Size(12, 13);
            this.labelNumeroEstantes.TabIndex = 82;
            this.labelNumeroEstantes.Text = "*";
            // 
            // labelNeveras
            // 
            this.labelNeveras.AutoSize = true;
            this.labelNeveras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNeveras.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelNeveras.Location = new System.Drawing.Point(433, 92);
            this.labelNeveras.Name = "labelNeveras";
            this.labelNeveras.Size = new System.Drawing.Size(70, 13);
            this.labelNeveras.TabIndex = 81;
            this.labelNeveras.Text = "# Neveras:";
            // 
            // labelVitrinas
            // 
            this.labelVitrinas.AutoSize = true;
            this.labelVitrinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVitrinas.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelVitrinas.Location = new System.Drawing.Point(433, 73);
            this.labelVitrinas.Name = "labelVitrinas";
            this.labelVitrinas.Size = new System.Drawing.Size(65, 13);
            this.labelVitrinas.TabIndex = 80;
            this.labelVitrinas.Text = "# Vitrinas:";
            // 
            // labelEstantes
            // 
            this.labelEstantes.AutoSize = true;
            this.labelEstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstantes.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelEstantes.Location = new System.Drawing.Point(432, 55);
            this.labelEstantes.Name = "labelEstantes";
            this.labelEstantes.Size = new System.Drawing.Size(72, 13);
            this.labelEstantes.TabIndex = 75;
            this.labelEstantes.Text = "# Estantes:";
            // 
            // panelPrecioNegocio
            // 
            this.panelPrecioNegocio.BackColor = System.Drawing.Color.Black;
            this.panelPrecioNegocio.Controls.Add(this.textPrecioNegocio);
            this.panelPrecioNegocio.Controls.Add(this.label4);
            this.panelPrecioNegocio.Location = new System.Drawing.Point(0, 308);
            this.panelPrecioNegocio.Name = "panelPrecioNegocio";
            this.panelPrecioNegocio.Size = new System.Drawing.Size(547, 30);
            this.panelPrecioNegocio.TabIndex = 79;
            // 
            // textPrecioNegocio
            // 
            this.textPrecioNegocio.Location = new System.Drawing.Point(275, 5);
            this.textPrecioNegocio.Name = "textPrecioNegocio";
            this.textPrecioNegocio.Size = new System.Drawing.Size(89, 20);
            this.textPrecioNegocio.TabIndex = 74;
            this.textPrecioNegocio.Text = "0";
            this.textPrecioNegocio.Enter += new System.EventHandler(this.textPrecioNegocio_Enter);
            this.textPrecioNegocio.Leave += new System.EventHandler(this.textPrecioNegocio_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(138, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Precio para negocio: $";
            // 
            // panelUbicacion
            // 
            this.panelUbicacion.BackColor = System.Drawing.Color.Black;
            this.panelUbicacion.Controls.Add(this.checkedNevera);
            this.panelUbicacion.Controls.Add(this.checkedVitrina);
            this.panelUbicacion.Controls.Add(this.checkedEstante);
            this.panelUbicacion.Controls.Add(this.label5);
            this.panelUbicacion.Controls.Add(this.comboUbicacion);
            this.panelUbicacion.Controls.Add(this.labelNumeroUbicacion);
            this.panelUbicacion.Location = new System.Drawing.Point(-1, 339);
            this.panelUbicacion.Name = "panelUbicacion";
            this.panelUbicacion.Size = new System.Drawing.Size(547, 30);
            this.panelUbicacion.TabIndex = 73;
            // 
            // checkedNevera
            // 
            this.checkedNevera.FormattingEnabled = true;
            this.checkedNevera.Items.AddRange(new object[] {
            "Nevera"});
            this.checkedNevera.Location = new System.Drawing.Point(299, 5);
            this.checkedNevera.Name = "checkedNevera";
            this.checkedNevera.Size = new System.Drawing.Size(97, 19);
            this.checkedNevera.TabIndex = 81;
            this.checkedNevera.SelectedIndexChanged += new System.EventHandler(this.checkedNevera_SelectedIndexChanged);
            // 
            // checkedVitrina
            // 
            this.checkedVitrina.FormattingEnabled = true;
            this.checkedVitrina.Items.AddRange(new object[] {
            "Vitrina"});
            this.checkedVitrina.Location = new System.Drawing.Point(198, 5);
            this.checkedVitrina.Name = "checkedVitrina";
            this.checkedVitrina.Size = new System.Drawing.Size(95, 19);
            this.checkedVitrina.TabIndex = 80;
            this.checkedVitrina.SelectedIndexChanged += new System.EventHandler(this.checkedVitrina_SelectedIndexChanged);
            // 
            // checkedEstante
            // 
            this.checkedEstante.FormattingEnabled = true;
            this.checkedEstante.Items.AddRange(new object[] {
            "Estante"});
            this.checkedEstante.Location = new System.Drawing.Point(102, 5);
            this.checkedEstante.Name = "checkedEstante";
            this.checkedEstante.Size = new System.Drawing.Size(90, 19);
            this.checkedEstante.TabIndex = 79;
            this.checkedEstante.SelectedIndexChanged += new System.EventHandler(this.checkedEstante_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Ubicacion:";
            // 
            // comboUbicacion
            // 
            this.comboUbicacion.FormattingEnabled = true;
            this.comboUbicacion.Items.AddRange(new object[] {
            "0"});
            this.comboUbicacion.Location = new System.Drawing.Point(421, 4);
            this.comboUbicacion.Name = "comboUbicacion";
            this.comboUbicacion.Size = new System.Drawing.Size(85, 21);
            this.comboUbicacion.TabIndex = 60;
            this.comboUbicacion.Text = "0";
            this.comboUbicacion.SelectedIndexChanged += new System.EventHandler(this.comboNumeroEstante_SelectedIndexChanged);
            // 
            // labelNumeroUbicacion
            // 
            this.labelNumeroUbicacion.AutoSize = true;
            this.labelNumeroUbicacion.ForeColor = System.Drawing.Color.White;
            this.labelNumeroUbicacion.Location = new System.Drawing.Point(402, 8);
            this.labelNumeroUbicacion.Name = "labelNumeroUbicacion";
            this.labelNumeroUbicacion.Size = new System.Drawing.Size(17, 13);
            this.labelNumeroUbicacion.TabIndex = 52;
            this.labelNumeroUbicacion.Text = "#:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.Medicamentos;
            this.pictureBox2.Location = new System.Drawing.Point(254, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.CodigoDeBarras;
            this.pictureBox1.Location = new System.Drawing.Point(101, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(165, 31);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(184, 16);
            this.labelAdvertencia.TabIndex = 60;
            this.labelAdvertencia.Text = "No existe este producto!!!";
            this.labelAdvertencia.Visible = false;
            // 
            // comboLaboratorio
            // 
            this.comboLaboratorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboLaboratorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboLaboratorio.FormattingEnabled = true;
            this.comboLaboratorio.Location = new System.Drawing.Point(389, 213);
            this.comboLaboratorio.Name = "comboLaboratorio";
            this.comboLaboratorio.Size = new System.Drawing.Size(115, 21);
            this.comboLaboratorio.TabIndex = 67;
            this.comboLaboratorio.Text = "Sin definir";
            // 
            // labelLaboratorio
            // 
            this.labelLaboratorio.AutoSize = true;
            this.labelLaboratorio.Location = new System.Drawing.Point(328, 217);
            this.labelLaboratorio.Name = "labelLaboratorio";
            this.labelLaboratorio.Size = new System.Drawing.Size(63, 13);
            this.labelLaboratorio.TabIndex = 66;
            this.labelLaboratorio.Text = "Laboratorio:";
            // 
            // comboTipo
            // 
            this.comboTipo.Enabled = false;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Sin definir",
            "Analgésico",
            "Anestésico",
            "Ansiolítico",
            "Antibiótico",
            "Anti-inflamatorio",
            "Anticolinérgico",
            "Anticonceptivo",
            "Anticonvulsivo",
            "Antidepresivo",
            "Antidiabético",
            "Antiemético",
            "Anti-helmíntico",
            "Anti-hipertensivo",
            "Anti-histamínico",
            "Antipirético",
            "Relajante muscular"});
            this.comboTipo.Location = new System.Drawing.Point(342, 247);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(178, 21);
            this.comboTipo.TabIndex = 64;
            this.comboTipo.Text = "Sin definir";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(309, 250);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(31, 13);
            this.labelTipo.TabIndex = 63;
            this.labelTipo.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Cantidad de producto:";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(123, 148);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(144, 20);
            this.textCantidad.TabIndex = 61;
            this.textCantidad.Text = "0";
            this.textCantidad.Enter += new System.EventHandler(this.textCantidad_Enter);
            this.textCantidad.Leave += new System.EventHandler(this.textCantidad_Leave);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.Indigo;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(278, 413);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(174, 35);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "   Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            this.btnRegistrar.IconColor = System.Drawing.Color.Navy;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 30;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(98, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(174, 35);
            this.btnRegistrar.TabIndex = 54;
            this.btnRegistrar.Text = "   Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // textDetalle
            // 
            this.textDetalle.Location = new System.Drawing.Point(136, 201);
            this.textDetalle.Multiline = true;
            this.textDetalle.Name = "textDetalle";
            this.textDetalle.Size = new System.Drawing.Size(187, 39);
            this.textDetalle.TabIndex = 59;
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Location = new System.Drawing.Point(9, 215);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(124, 13);
            this.labelDetalle.TabIndex = 58;
            this.labelDetalle.Text = "Detalle de medicamento:";
            // 
            // comboVia
            // 
            this.comboVia.Enabled = false;
            this.comboVia.FormattingEnabled = true;
            this.comboVia.Items.AddRange(new object[] {
            "Sin definir",
            "Oral",
            "Inyectable",
            "Rectal",
            "Vaginal",
            "Ocular",
            "Ótica",
            "Nasal",
            "Inhalatoria",
            "Nebulizantes",
            "Cutanea",
            "Transdérmica"});
            this.comboVia.Location = new System.Drawing.Point(418, 275);
            this.comboVia.Name = "comboVia";
            this.comboVia.Size = new System.Drawing.Size(102, 21);
            this.comboVia.TabIndex = 56;
            this.comboVia.Text = "Sin definir";
            // 
            // panelTituloDeRegistroProductos
            // 
            this.panelTituloDeRegistroProductos.BackColor = System.Drawing.Color.Black;
            this.panelTituloDeRegistroProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTituloDeRegistroProductos.Controls.Add(this.btnClose);
            this.panelTituloDeRegistroProductos.Controls.Add(this.textSearch);
            this.panelTituloDeRegistroProductos.Controls.Add(this.btnSearch);
            this.panelTituloDeRegistroProductos.Controls.Add(this.labelTitle);
            this.panelTituloDeRegistroProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDeRegistroProductos.Location = new System.Drawing.Point(0, 0);
            this.panelTituloDeRegistroProductos.Name = "panelTituloDeRegistroProductos";
            this.panelTituloDeRegistroProductos.Size = new System.Drawing.Size(546, 24);
            this.panelTituloDeRegistroProductos.TabIndex = 48;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(501, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 59;
            this.btnClose.TabStop = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Location = new System.Drawing.Point(374, 1);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(127, 20);
            this.textSearch.TabIndex = 57;
            this.textSearch.Text = "Buscar referencia";
            this.textSearch.Visible = false;
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 20;
            this.btnSearch.Location = new System.Drawing.Point(521, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(4, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(138, 16);
            this.labelTitle.TabIndex = 50;
            this.labelTitle.Text = "Registrar Producto";
            // 
            // textReferencia
            // 
            this.textReferencia.Location = new System.Drawing.Point(337, 149);
            this.textReferencia.Name = "textReferencia";
            this.textReferencia.Size = new System.Drawing.Size(144, 20);
            this.textReferencia.TabIndex = 33;
            this.textReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textReferencia_KeyPress);
            // 
            // labelReferencia
            // 
            this.labelReferencia.AutoSize = true;
            this.labelReferencia.Location = new System.Drawing.Point(273, 153);
            this.labelReferencia.Name = "labelReferencia";
            this.labelReferencia.Size = new System.Drawing.Size(62, 13);
            this.labelReferencia.TabIndex = 32;
            this.labelReferencia.Text = "Referencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre farmaceutico:";
            // 
            // textNombreFarmaceutico
            // 
            this.textNombreFarmaceutico.Location = new System.Drawing.Point(123, 174);
            this.textNombreFarmaceutico.Name = "textNombreFarmaceutico";
            this.textNombreFarmaceutico.Size = new System.Drawing.Size(144, 20);
            this.textNombreFarmaceutico.TabIndex = 35;
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Location = new System.Drawing.Point(9, 251);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(92, 13);
            this.labelFechaRegistro.TabIndex = 36;
            this.labelFechaRegistro.Text = "Fecha de registro:";
            // 
            // dateTimeFechaRegistro
            // 
            this.dateTimeFechaRegistro.Enabled = false;
            this.dateTimeFechaRegistro.Location = new System.Drawing.Point(101, 248);
            this.dateTimeFechaRegistro.Name = "dateTimeFechaRegistro";
            this.dateTimeFechaRegistro.Size = new System.Drawing.Size(191, 20);
            this.dateTimeFechaRegistro.TabIndex = 37;
            // 
            // labelVia
            // 
            this.labelVia.AutoSize = true;
            this.labelVia.Location = new System.Drawing.Point(326, 279);
            this.labelVia.Name = "labelVia";
            this.labelVia.Size = new System.Drawing.Size(91, 13);
            this.labelVia.TabIndex = 42;
            this.labelVia.Text = "Via de aplicacion:";
            // 
            // labelFechaVencimiento
            // 
            this.labelFechaVencimiento.AutoSize = true;
            this.labelFechaVencimiento.Location = new System.Drawing.Point(8, 280);
            this.labelFechaVencimiento.Name = "labelFechaVencimiento";
            this.labelFechaVencimiento.Size = new System.Drawing.Size(115, 13);
            this.labelFechaVencimiento.TabIndex = 38;
            this.labelFechaVencimiento.Text = "Fecha de vencimiento:";
            // 
            // textLote
            // 
            this.textLote.Location = new System.Drawing.Point(320, 175);
            this.textLote.Name = "textLote";
            this.textLote.Size = new System.Drawing.Size(144, 20);
            this.textLote.TabIndex = 41;
            // 
            // dateTimeFechaVencimiento
            // 
            this.dateTimeFechaVencimiento.Location = new System.Drawing.Point(123, 277);
            this.dateTimeFechaVencimiento.Name = "dateTimeFechaVencimiento";
            this.dateTimeFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaVencimiento.TabIndex = 39;
            // 
            // labelLote
            // 
            this.labelLote.AutoSize = true;
            this.labelLote.Location = new System.Drawing.Point(283, 178);
            this.labelLote.Name = "labelLote";
            this.labelLote.Size = new System.Drawing.Size(31, 13);
            this.labelLote.TabIndex = 40;
            this.labelLote.Text = "Lote:";
            // 
            // panelValores
            // 
            this.panelValores.BackColor = System.Drawing.Color.Black;
            this.panelValores.Controls.Add(this.label3);
            this.panelValores.Controls.Add(this.labelPrecioDeNegocio);
            this.panelValores.Controls.Add(this.textPrecioCaja);
            this.panelValores.Controls.Add(this.textPrecioUnidad);
            this.panelValores.Controls.Add(this.textPrecioBlister);
            this.panelValores.Controls.Add(this.labelPorcentajeDeVenta);
            this.panelValores.Location = new System.Drawing.Point(0, 370);
            this.panelValores.Name = "panelValores";
            this.panelValores.Size = new System.Drawing.Size(547, 30);
            this.panelValores.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(375, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Valor por caja:";
            // 
            // labelPrecioDeNegocio
            // 
            this.labelPrecioDeNegocio.AutoSize = true;
            this.labelPrecioDeNegocio.ForeColor = System.Drawing.Color.White;
            this.labelPrecioDeNegocio.Location = new System.Drawing.Point(4, 9);
            this.labelPrecioDeNegocio.Name = "labelPrecioDeNegocio";
            this.labelPrecioDeNegocio.Size = new System.Drawing.Size(87, 13);
            this.labelPrecioDeNegocio.TabIndex = 44;
            this.labelPrecioDeNegocio.Text = "Valor por unidad:";
            // 
            // textPrecioCaja
            // 
            this.textPrecioCaja.Location = new System.Drawing.Point(450, 5);
            this.textPrecioCaja.Name = "textPrecioCaja";
            this.textPrecioCaja.Size = new System.Drawing.Size(88, 20);
            this.textPrecioCaja.TabIndex = 70;
            this.textPrecioCaja.Text = "0";
            this.textPrecioCaja.Enter += new System.EventHandler(this.textPrecioCaja_Enter);
            this.textPrecioCaja.Leave += new System.EventHandler(this.textPrecioCaja_Leave);
            // 
            // textPrecioUnidad
            // 
            this.textPrecioUnidad.Location = new System.Drawing.Point(91, 5);
            this.textPrecioUnidad.Name = "textPrecioUnidad";
            this.textPrecioUnidad.Size = new System.Drawing.Size(89, 20);
            this.textPrecioUnidad.TabIndex = 45;
            this.textPrecioUnidad.Text = "0";
            this.textPrecioUnidad.Enter += new System.EventHandler(this.textPrecioUnidad_Enter);
            this.textPrecioUnidad.Leave += new System.EventHandler(this.textPrecioUnidad_Leave);
            // 
            // textPrecioBlister
            // 
            this.textPrecioBlister.Location = new System.Drawing.Point(279, 5);
            this.textPrecioBlister.Name = "textPrecioBlister";
            this.textPrecioBlister.Size = new System.Drawing.Size(88, 20);
            this.textPrecioBlister.TabIndex = 46;
            this.textPrecioBlister.Text = "0";
            this.textPrecioBlister.Enter += new System.EventHandler(this.textPrecioBlister_Enter);
            this.textPrecioBlister.Leave += new System.EventHandler(this.textPrecioBlister_Leave);
            // 
            // labelPorcentajeDeVenta
            // 
            this.labelPorcentajeDeVenta.AutoSize = true;
            this.labelPorcentajeDeVenta.BackColor = System.Drawing.Color.Black;
            this.labelPorcentajeDeVenta.ForeColor = System.Drawing.Color.White;
            this.labelPorcentajeDeVenta.Location = new System.Drawing.Point(193, 8);
            this.labelPorcentajeDeVenta.Name = "labelPorcentajeDeVenta";
            this.labelPorcentajeDeVenta.Size = new System.Drawing.Size(82, 13);
            this.labelPorcentajeDeVenta.TabIndex = 47;
            this.labelPorcentajeDeVenta.Text = "Valor por blister:";
            // 
            // FormRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 479);
            this.Controls.Add(this.panelRegistroDeProductos);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarProducto";
            this.Opacity = 0.9D;
            this.Text = "FormRegistrarProducto";
            this.menuTop.ResumeLayout(false);
            this.panelRegistroDeProductos.ResumeLayout(false);
            this.panelRegistroDeProductos.PerformLayout();
            this.panelPrecioNegocio.ResumeLayout(false);
            this.panelPrecioNegocio.PerformLayout();
            this.panelUbicacion.ResumeLayout(false);
            this.panelUbicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTituloDeRegistroProductos.ResumeLayout(false);
            this.panelTituloDeRegistroProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panelValores.ResumeLayout(false);
            this.panelValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelRegistroDeProductos;
        private System.Windows.Forms.TextBox textDetalle;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.ComboBox comboVia;
        private System.Windows.Forms.Label labelNumeroUbicacion;
        private System.Windows.Forms.Panel panelTituloDeRegistroProductos;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textReferencia;
        private System.Windows.Forms.Label labelPorcentajeDeVenta;
        private System.Windows.Forms.Label labelReferencia;
        private System.Windows.Forms.TextBox textPrecioBlister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrecioUnidad;
        private System.Windows.Forms.TextBox textNombreFarmaceutico;
        private System.Windows.Forms.Label labelPrecioDeNegocio;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.DateTimePicker dateTimeFechaRegistro;
        private System.Windows.Forms.Label labelVia;
        private System.Windows.Forms.Label labelFechaVencimiento;
        private System.Windows.Forms.TextBox textLote;
        private System.Windows.Forms.DateTimePicker dateTimeFechaVencimiento;
        private System.Windows.Forms.Label labelLote;
        private System.Windows.Forms.ComboBox comboUbicacion;
        private System.Windows.Forms.ComboBox comboLaboratorio;
        private System.Windows.Forms.Label labelLaboratorio;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.TextBox textSearch;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrecioCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCantidad;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.Panel panelValores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPrecioNegocio;
        private System.Windows.Forms.Panel panelUbicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Panel panelPrecioNegocio;
        private System.Windows.Forms.CheckedListBox checkedEstante;
        private System.Windows.Forms.CheckedListBox checkedVitrina;
        private System.Windows.Forms.CheckedListBox checkedNevera;
        private System.Windows.Forms.Label labelNeveras;
        private System.Windows.Forms.Label labelVitrinas;
        private System.Windows.Forms.Label labelEstantes;
        private System.Windows.Forms.Label labelNumeroNeveras;
        private System.Windows.Forms.Label labelNumeroVitrinas;
        private System.Windows.Forms.Label labelNumeroEstantes;
    }
}