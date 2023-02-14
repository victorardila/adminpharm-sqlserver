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
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormRegistrarVitrina : Form
    {
        VitrinaService vitrinaService;
        Vitrina vitrina;
        int cantidadDeVitrina;
        string numeroDeVitrina;
        public FormRegistrarVitrina()
        {
            vitrinaService = new VitrinaService(ConfigConnection.ConnectionString);
            InitializeComponent();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Recorrervitrinas()
        {
            cantidadDeVitrina = int.Parse(textNumeroVitrina.Text);
            for (int i = 1; i <= cantidadDeVitrina; i++)
            {
                numeroDeVitrina = "VITRINA " + i;
                RegistrarVitrinas();
            }
        }
        private void RegistrarVitrinas()
        {
            Vitrina vitrina = MapearVitrina();
            string mensaje = vitrinaService.Guardar(vitrina);
        }
        private Vitrina MapearVitrina()
        {
            vitrina = new Vitrina();
            vitrina.NumeroDeVitrina = numeroDeVitrina;
            vitrina.CantidadDeProductos = 0;
            return vitrina;
        }

        private void FormRegistrarVitrina_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistrarEstante_Click(object sender, EventArgs e)
        {
            Recorrervitrinas();
            this.Close();
        }
    }
}
