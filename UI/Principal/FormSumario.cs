using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class InicioResumen : Form
    {

        public InicioResumen()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            labelRefresh.Visible = true;
            labelPapelera.Visible = false;
        }
        private void iconPapelera_MouseHover(object sender, EventArgs e)
        {
            labelPapelera.Visible = true;
            labelRefresh.Visible = false;
        }
    }
}
