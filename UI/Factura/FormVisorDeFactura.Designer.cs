
namespace Presentacion
{
    partial class FormVisorDeFactura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lectorDePDF = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.labelTitleFileNme = new System.Windows.Forms.Label();
            this.labelTitleURL = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 27);
            this.panel1.TabIndex = 1;
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
            this.btnCerrar.Location = new System.Drawing.Point(448, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lectorDePDF
            // 
            this.lectorDePDF.AutoScroll = true;
            this.lectorDePDF.BackColor = System.Drawing.Color.DarkGray;
            this.lectorDePDF.EastAsianFont = true;
            this.lectorDePDF.FormFillEnabled = false;
            this.lectorDePDF.Location = new System.Drawing.Point(13, 78);
            this.lectorDePDF.MultiPagesThreshold = 60;
            this.lectorDePDF.Name = "lectorDePDF";
            this.lectorDePDF.OnRenderPageExceptionEvent = null;
            this.lectorDePDF.PageLayoutMode = Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous;
            this.lectorDePDF.Size = new System.Drawing.Size(448, 356);
            this.lectorDePDF.TabIndex = 2;
            this.lectorDePDF.Text = "pdfDocumentViewer1";
            this.lectorDePDF.Threshold = 60;
            this.lectorDePDF.ViewerMode = Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage;
            this.lectorDePDF.ZoomFactor = 1F;
            this.lectorDePDF.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // labelTitleFileNme
            // 
            this.labelTitleFileNme.AutoSize = true;
            this.labelTitleFileNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleFileNme.Location = new System.Drawing.Point(13, 40);
            this.labelTitleFileNme.Name = "labelTitleFileNme";
            this.labelTitleFileNme.Size = new System.Drawing.Size(118, 13);
            this.labelTitleFileNme.TabIndex = 3;
            this.labelTitleFileNme.Text = "Nombre de archivo:";
            // 
            // labelTitleURL
            // 
            this.labelTitleURL.AutoSize = true;
            this.labelTitleURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleURL.Location = new System.Drawing.Point(12, 61);
            this.labelTitleURL.Name = "labelTitleURL";
            this.labelTitleURL.Size = new System.Drawing.Size(151, 13);
            this.labelTitleURL.TabIndex = 4;
            this.labelTitleURL.Text = "Ruta de almacenamiento:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(132, 40);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(12, 13);
            this.labelFileName.TabIndex = 5;
            this.labelFileName.Text = "*";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.Location = new System.Drawing.Point(160, 61);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(12, 13);
            this.labelURL.TabIndex = 6;
            this.labelURL.Text = "*";
            // 
            // FormVisorDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelTitleURL);
            this.Controls.Add(this.labelTitleFileNme);
            this.Controls.Add(this.lectorDePDF);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisorDeFactura";
            this.Text = "FormVisorDeFactura";
            this.Load += new System.EventHandler(this.FormVisorDeFactura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private Spire.PdfViewer.Forms.PdfDocumentViewer lectorDePDF;
        private System.Windows.Forms.Label labelTitleFileNme;
        private System.Windows.Forms.Label labelTitleURL;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelURL;
    }
}