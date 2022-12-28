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
    public partial class FormProductosVendidos : Form
    {
        ProductoService productoService;
        ProductoVendidoTxtService productoVendidoTxtService = new ProductoVendidoTxtService();
        ProductoVendidoTxt productoTxt = new ProductoVendidoTxt();
        public FormProductosVendidos()
        {
            InitializeComponent();
            cargarArchivo(productoVendidoTxtService);
        }

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
                    dataGridProductosVendidos.Rows.Add(Cantidad, Referencia, Nombre, Detalle, FechaDeRegistro,
                        FechaDeVencimiento, Lote, Laboratorio, Estado, Tipo, Via, PrecioDeNegocio, PrecioDeVenta, GananciaPorProducto);
                }
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
                    dataGridProductosVendidos.Rows.Add(Cantidad, Referencia, Nombre, Detalle, FechaDeRegistro,
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
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de productos vendidos?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ProductoFacturaTxt productoTxt = new ProductoFacturaTxt();
                string mensaje = productoVendidoTxtService.EliminarHistorial();
                dataGridProductosVendidos.DataSource = null;
                ConsultarHistorial();
            }
        }
    }
}
