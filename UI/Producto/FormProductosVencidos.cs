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
        int cantidadProductoBD;
        public FormProductosVencidos()
        {
            productoService = new ProductoService(ConfigConnection.ConnectionString);
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
                    Deshacer.Image = Properties.Resources.Regresar;
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
                    dataGridProductosVencidos.Rows.Add(Deshacer.Image, Cantidad, Referencia, Nombre, Detalle, FechaDeRegistro, 
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
                    Deshacer.Image = Properties.Resources.Regresar;
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
                    dataGridProductosVencidos.Rows.Add(Deshacer.Image, Cantidad, Referencia, Nombre, Detalle, FechaDeRegistro,
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
                dataGridProductosVencidos.Rows.Clear();
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
        private void DevolverAlInventario(string referencia, int cantidad)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            respuesta = productoService.BuscarPorReferencia(referencia);
            if (respuesta.Producto != null)
            {
                cantidadProductoBD = respuesta.Producto.Cantidad;
                respuesta.Producto.Cantidad = cantidadProductoBD + cantidad;
                var producto = respuesta.Producto;
                productoService.ModificarCantidad(producto);
                productoVencidoTxtService.Eliminar(referencia);
                dataGridProductosVencidos.Rows.Clear();
            }
            else
            {
                dataGridProductosVencidos.Rows.Clear();
                string msg = "Este producto no se puede regresar al inventario puesto que ya no existe en el inventario";
                MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridProductosVencidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string referencia;
            string nombre;
            int cantidad;
            if (dataGridProductosVencidos.Rows != null)
            {
                if (dataGridProductosVencidos.Columns[e.ColumnIndex].Name == "Deshacer")
                {
                    referencia = Convert.ToString(dataGridProductosVencidos.CurrentRow.Cells["Referencia"].Value.ToString());
                    cantidad = Convert.ToInt32(dataGridProductosVencidos.CurrentRow.Cells["Cantidad"].Value.ToString());
                    nombre = Convert.ToString(dataGridProductosVencidos.CurrentRow.Cells["Nombre"].Value.ToString());
                    string msg = "Desea deshacer la venta de este producto " + nombre + "?";
                    var respuesta = MessageBox.Show(msg, "Devolver al inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        DevolverAlInventario(referencia, cantidad);
                        ConsultarHistorial();
                    }
                }
            }
            else
            {
                if (dataGridProductosVencidos.Rows == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
