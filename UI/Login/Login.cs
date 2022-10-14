using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void iconSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = true;
            iconSeePasword.Visible = false;
        }

        private void iconNoSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = false;
            iconSeePasword.Visible = true;
        }
    }
}
