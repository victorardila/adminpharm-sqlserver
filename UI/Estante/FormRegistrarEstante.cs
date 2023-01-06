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
    public partial class FormRegistrarEstante : Form
    {
        EstanteService estanteService;
        Estante estante;
        int cantidadDeEstante;
        int numeroDeEstante;
        public FormRegistrarEstante()
        {
            estanteService = new EstanteService(ConfigConnection.ConnectionString);
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
        private void Recorrerestantes()
        {
            cantidadDeEstante = int.Parse(textNumeroEstante.Text);
            for(int i=1;i<= cantidadDeEstante; i++)
            {
                numeroDeEstante = i;
                RegistrarEstantes();
            }
        }
        private void RegistrarEstantes()
        {
            Estante estante = MapearEstante();
            string mensaje = estanteService.Guardar(estante);
        }
        private Estante MapearEstante()
        {
            estante = new Estante();
            estante.NumeroDeEstante=numeroDeEstante;
            estante.CantidadDeProductos = 0;
            return estante;
        }
        private void btnRegistrarEstante_Click(object sender, EventArgs e)
        {
            Recorrerestantes();
            this.Close();
        }
    }
}
