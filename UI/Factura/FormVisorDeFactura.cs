using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Spire.PdfViewer.Forms;

namespace Presentacion
{   
    public partial class FormVisorDeFactura : Form
    {
        public string nombreDeArchivo;
        public string rutaDeGuardado;
        public FormVisorDeFactura()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormVisorDeFactura_Load(object sender, EventArgs e)
        {
            labelFileName.Text = nombreDeArchivo;
            labelURL.Text = rutaDeGuardado;
            string pdfDoc = rutaDeGuardado+"\\"+nombreDeArchivo;
            if (File.Exists(pdfDoc))
            {
                this.lectorDePDF.LoadFromFile(pdfDoc);
            }
        }
    }
}
