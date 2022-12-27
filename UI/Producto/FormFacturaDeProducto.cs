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
    public partial class FormFacturaDeProducto : Form
    {
        ProductoFacturaTxt productoTxt = new ProductoFacturaTxt();
        ProductoFacturaTxtService productoTxtService = new ProductoFacturaTxtService();
        double TotalFactura;
        string referenciaProducto;
        int cantidadProducto;
        ProductoService productoService;
        List<Producto> productos;
        Producto producto;
        public FormFacturaDeProducto()
        {
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            cargarArchivo(productoTxtService);
            SumatoriaFactura();
        }
        public void cargarArchivo(ProductoFacturaTxtService productoTxtService)
        {
            ProductoFacturaTxtConsultaResponse productoTxtConsultaResponse = productoTxtService.Consultar();
            if (productoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    string referencia = item.Referencia;
                    int cantidad = item.Cantidad;
                    string nombre = item.Nombre;
                    string detalle = item.Detalle;
                    double precio = item.Precio;
                    dataGridFacturaProductos.Rows.Add(referencia, cantidad, nombre, detalle, precio);
                }
            }
            else
            {
                if (productoTxtConsultaResponse.ProductoTxts.Count == 0)
                {
                    dataGridFacturaProductos = null;
                }
            }
        }
        private void ConsultarHistorial()
        {
            ProductoFacturaTxtConsultaResponse productoTxtConsultaResponse = productoTxtService.Consultar();
            if (productoTxtConsultaResponse.Encontrado == true)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    string referencia = item.Referencia;
                    int cantidad = item.Cantidad;
                    string nombre = item.Nombre;
                    string detalle = item.Detalle;
                    double precio = item.Precio;
                    dataGridFacturaProductos.Rows.Add(referencia, cantidad, nombre, detalle, precio);
                }
            }
            else
            {
                string mensaje = productoTxtConsultaResponse.Mensaje;
                MessageBox.Show(mensaje.ToString());
            }
        }
        private void SumatoriaFactura()
        {
            int i = 0;
            foreach (DataGridViewRow fila in dataGridFacturaProductos.Rows)
            {
                int j = 0;
                double valor=0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (j == 4)
                    {
                        valor = Convert.ToInt32(fila.Cells[4].Value);
                        TotalFactura = TotalFactura + valor;
                        break;
                    }
                    j = j + 1;
                }
                i = i + 1;
            }
            labelTotalFactura.Text = TotalFactura.ToString();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            LimpiarFactura();
        }
        private void LimpiarFactura()
        {
            ProductoFacturaTxt productoTxt = new ProductoFacturaTxt();
            string mensaje = productoTxtService.EliminarHistorial();
            dataGridFacturaProductos.DataSource = null;
            ConsultarHistorial();
        }
        private void textPago_TextChanged(object sender, EventArgs e)
        {
            if (textPago.Text != "")
            {
                labelVueltos.Text = "";
                int pago = int.Parse(textPago.Text);
                int TotalFactura = int.Parse(labelTotalFactura.Text);
                int diferencia = pago - TotalFactura;
                labelVueltos.Text = diferencia.ToString();
            }
        }
        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            LimpiarFactura();
            ConsultarHistorial();
        }
    }
}
