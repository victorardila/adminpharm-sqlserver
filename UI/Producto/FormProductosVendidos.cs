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
    public partial class FormProductosVendidos : Form
    {
        ProductoService productoService;
        ProductoVendidoTxtService productoVendidoTxtService = new ProductoVendidoTxtService();
        ProductoVendidoTxt productoTxt = new ProductoVendidoTxt();
        int cantidadProductoBD;
        string referenciaProducto;
        int cantidadARestar;
        int cantidadProducto;
        string nombreProducto;
        string detalleProducto;
        double precioProducto;
        public FormProductosVendidos()
        {
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            cargarArchivo(productoVendidoTxtService);
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
        public void cargarArchivo(ProductoVendidoTxtService productoVendidoTxtService)
        {
            ProductoVendidoTxtConsultaResponse productoVendidoTxtConsultaResponse = productoVendidoTxtService.Consultar();
            if (productoVendidoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoVendidoTxtConsultaResponse.ProductoTxts)
                {
                    Deshacer.Image=Properties.Resources.Regresar;
                    cantidadProducto = item.Cantidad;
                    referenciaProducto = item.Referencia;
                    nombreProducto = item.Nombre;
                    detalleProducto = item.Detalle;
                    precioProducto = item.Precio;
                    dataGridProductosVendidos.Rows.Add(Deshacer.Image, cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, precioProducto);
                }
                textTotal.Text = productoVendidoTxtService.Totalizar();
            }
            else
            {
                if (productoVendidoTxtConsultaResponse.ProductoTxts.Count == 0)
                {
                    dataGridProductosVendidos.DataSource = null;
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void ConsultarHistorial()
        {
            ProductoVendidoTxtConsultaResponse productoTxtConsultaResponse = productoVendidoTxtService.Consultar();
            if (productoTxtConsultaResponse.Encontrado == true)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    Deshacer.Image = Properties.Resources.Regresar;
                    string referencia = item.Referencia;
                    int cantidad = item.Cantidad;
                    string nombre = item.Nombre;
                    string detalle = item.Detalle;
                    double precio = item.Precio;
                    dataGridProductosVendidos.Rows.Add(Deshacer.Image, cantidad, referencia, nombre, detalle, precio);
                }
            }
            else
            {
                dataGridProductosVendidos.DataSource = null;
                string mensaje = productoTxtConsultaResponse.Mensaje;
                MessageBox.Show(mensaje.ToString());
            }
        }

        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de productos vendidos?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ProductoFacturaTxt productoTxt = new ProductoFacturaTxt();
                string mensaje = productoVendidoTxtService.EliminarHistorial();
                dataGridProductosVendidos.DataSource = null;
                ConsultarHistorial();
            }
        }

        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormProductosVendidos_MouseDown(object sender, MouseEventArgs e)
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
                productoVendidoTxtService.Eliminar(referencia);
                dataGridProductosVendidos.Rows.Clear();
            }
        }
        private void dataGridProductosVendidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string referencia;
            string nombre;
            int cantidad;
            if (dataGridProductosVendidos.Rows != null)
            {
                if (dataGridProductosVendidos.Columns[e.ColumnIndex].Name == "Deshacer")
                {
                    referencia = Convert.ToString(dataGridProductosVendidos.CurrentRow.Cells["Referencia"].Value.ToString());
                    cantidad = Convert.ToInt32(dataGridProductosVendidos.CurrentRow.Cells["Cantidad"].Value.ToString());
                    nombre= Convert.ToString(dataGridProductosVendidos.CurrentRow.Cells["Nombre"].Value.ToString());
                    string msg = "Desea deshacer la venta de este producto " + nombre + "?";
                    var respuesta = MessageBox.Show(msg, "Deshacer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        DevolverAlInventario(referencia, cantidad);
                        ConsultarHistorial();
                    }
                }
            }
            else
            {
                if (dataGridProductosVendidos.Rows == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
