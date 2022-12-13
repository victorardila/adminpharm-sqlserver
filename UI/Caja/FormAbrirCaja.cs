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
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormAbrirCaja : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        Caja cajaRegistradora;
        public FormAbrirCaja()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormAbrirCaja_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textMonto.Text == "0")
            {
                textMonto.Text = "";
                textMonto.ForeColor = Color.FromArgb(140, 3, 3);
            }
        }
        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textMonto.Text == "")
            {
                textMonto.ForeColor = Color.Maroon;
                textMonto.Text = "0";
            }
        }
        private Caja MapearCajaRegistradora()
        {
            cajaRegistradora = new Caja();
            cajaRegistradora.Monto = int.Parse(textMonto.Text);
            return cajaRegistradora;
        }
        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            Caja cajaRegistradora = MapearCajaRegistradora();
            string mensaje = cajaRegistradoraService.Guardar(cajaRegistradora);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            btnAbrirCaja.Enabled = false;
            this.Close();
        }
    }
}
