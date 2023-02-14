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
    public partial class FormRegistrarNevera : Form
    {
        NeveraService neveraService;
        Nevera nevera;
        int cantidadDeNevera;
        string numeroDeNevera;
        public FormRegistrarNevera()
        {
            neveraService = new NeveraService(ConfigConnection.ConnectionString);
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
        private void Recorrerneveras()
        {
            cantidadDeNevera = int.Parse(textNumeroNevera.Text);
            for (int i = 1; i <= cantidadDeNevera; i++)
            {
                numeroDeNevera = "ESTANTE " + i;
                RegistrarNeveras();
            }
        }
        private void RegistrarNeveras()
        {
            Nevera nevera = MapearNevera();
            string mensaje = neveraService.Guardar(nevera);
        }
        private Nevera MapearNevera()
        {
            nevera = new Nevera();
            nevera.NumeroDeNevera = numeroDeNevera;
            nevera.CantidadDeProductos = 0;
            return nevera;
        }

        private void FormRegistrarNevera_MouseDown(object sender, MouseEventArgs e)
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
            Recorrerneveras();
            this.Close();
        }
    }
}
