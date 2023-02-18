using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using Entity;
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormProductosVencidos : Form
    {
        ProductoService productoService;
        ProductoVencidoTxtService productoVencidoTxtService = new ProductoVencidoTxtService();
        ProductoVencidoTxt productoTxt = new ProductoVencidoTxt();
        public FormProductosVencidos()
        {
            InitializeComponent();
            cargarArchivo(productoVencidoTxtService);
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
        public void cargarArchivo(ProductoVencidoTxtService productoVencidoTxtService)
        {
            ProductoVencidoTxtConsultaResponse productoVencidoTxtConsultaResponse = productoVencidoTxtService.Consultar();
            if (productoVencidoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoVencidoTxtConsultaResponse.ProductoTxts)
                {
                    int Cantidad = item.Cantidad;
                    string Referencia = item.Referencia;
                    string Nombre = item.Nombre;
                    string Detalle = item.Detalle;
                    DateTime FechaDeRegistro = item.FechaDeRegistro;
                    DateTime FechaDeVencimiento = item.FechaDeVencimiento;
                    string Lote = item.Lote;
                    string Laboratorio = item.Laboratorio;
                    string Estado = item.Estado;
                    string Tipo = item.Tipo;
                    string Via = item.Via;
                    double PrecioDeNegocio = item.PrecioDeNegocio;
                    double PrecioDeVenta = item.PrecioDeVenta;
                    double GananciaPorProducto = item.GananciaPorProducto;
                    dataGridProductosVencidos.Rows.Add(Cantidad, Referencia, Nombre, Detalle, FechaDeRegistro, 
                        FechaDeVencimiento, Lote, Laboratorio, Estado, Tipo, Via, PrecioDeNegocio, PrecioDeVenta, GananciaPorProducto);
                }
                textTotal.Text = productoVencidoTxtService.Totalizar();
                textVigentes.Text= productoVencidoTxtService.TotalizarTipo("Vigente");
                textCuarentena.Text = productoVencidoTxtService.TotalizarTipo("Cuaretena");
            }
            else
            {
                if (productoVencidoTxtConsultaResponse.ProductoTxts.Count == 0)
                {
                    dataGridProductosVencidos.DataSource = null;
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void ConsultarHistorial()
        {
            ProductoVencidoTxtConsultaResponse productoTxtConsultaResponse = productoVencidoTxtService.Consultar();
            if (productoTxtConsultaResponse.Encontrado == true)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    int Cantidad = item.Cantidad;
                    string Referencia = item.Referencia;
                    string Nombre = item.Nombre;
                    string Detalle = item.Detalle;
                    DateTime FechaDeRegistro = item.FechaDeRegistro;
                    DateTime FechaDeVencimiento = item.FechaDeVencimiento;
                    string Lote = item.Lote;
                    string Laboratorio = item.Laboratorio;
                    string Estado = item.Estado;
                    string Tipo = item.Tipo;
                    string Via = item.Via;
                    double PrecioDeNegocio = item.PrecioDeNegocio;
                    double PrecioDeVenta = item.PrecioDeVenta;
                    double GananciaPorProducto = item.GananciaPorProducto;
                    dataGridProductosVencidos.Rows.Add(Cantidad, Referencia, Nombre, Detalle, FechaDeRegistro,
                        FechaDeVencimiento, Lote, Laboratorio, Estado, Tipo, Via, PrecioDeNegocio, PrecioDeVenta, GananciaPorProducto);
                }
            }
            else
            {
                string mensaje = productoTxtConsultaResponse.Mensaje;
                MessageBox.Show(mensaje.ToString());
            }
        }
        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de productos vencidos?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ProductoFacturaTxt productoTxt = new ProductoFacturaTxt();
                string mensaje = productoVencidoTxtService.EliminarHistorial();
                dataGridProductosVencidos.DataSource = null;
                ConsultarHistorial();
            }
        }

        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormProductosVencidos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
