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
        Caja cajaRegistradora;
        CajaRegistradoraService cajaRegistradoraService;
        ProductoService productoService;
        ProductoFacturaTxtService productoTxtService = new ProductoFacturaTxtService();
        ProductoVendidoTxtService productoVendidoTxtService = new ProductoVendidoTxtService();
        //Variables de caja
        double totalFactura = 0;
        string idCajaAbierta;
        double montoActualCaja;
        //Variables de productos
        string[] referencias = new string[1000];
        string referenciaProducto;
        int cantidadProducto;
        string nombreProducto;
        string detalleProducto;
        double precioProducto;
        string loteProducto;
        string laboratorioProducto;
        string estadoProducto;
        DateTime fechaDeRegistro;
        DateTime fechaDeVencimiento;
        string viaProducto;
        string tipoProducto;
        double precioDeNegocio;
        double porcentajeDeVenta;

        public FormFacturaDeProducto()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            CargarArchivo(productoTxtService);
            ConsultarCajaAbierta();
            SumtoriaDeFactura();
        }
        private void MapearProductosVendidos(string referencia)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            respuesta = productoService.BuscarPorReferencia(referencia);
            if (respuesta.Producto != null)
            {
                referenciaProducto = respuesta.Producto.Referencia;
                nombreProducto = respuesta.Producto.Nombre;
                detalleProducto = respuesta.Producto.Detalle;
                precioProducto = respuesta.Producto.PrecioDeVenta;
                loteProducto = respuesta.Producto.Lote;
                laboratorioProducto = respuesta.Producto.Laboratorio;
                estadoProducto = respuesta.Producto.Estado;
                fechaDeRegistro = respuesta.Producto.FechaDeRegistro;
                fechaDeVencimiento = respuesta.Producto.FechaDeVencimiento;
                tipoProducto = respuesta.Producto.Tipo;
                viaProducto = respuesta.Producto.Via;
                precioDeNegocio = respuesta.Producto.PrecioDeNegocio;
                porcentajeDeVenta = respuesta.Producto.PorcentajeDeVenta;
                ProductoVendidoTxt productoTxt = new ProductoVendidoTxt(cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, fechaDeRegistro,
                    fechaDeVencimiento, loteProducto, laboratorioProducto, estadoProducto, tipoProducto, viaProducto, precioDeNegocio, precioProducto, porcentajeDeVenta);
                string mensaje = productoVendidoTxtService.Guardar(productoTxt);
            }
        }
        private void ContarProductosVendidos()
        {
            foreach (DataGridViewRow fila in dataGridFacturaProductos.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (i == 0)
                    {
                        referencias[i]= Convert.ToString(fila.Cells[i].Value);
                        string referencia = referencias[i];
                        MapearProductosVendidos(referencia);
                    }
                    i = i + 1;
                }
            }
        }
        private void SumtoriaDeFactura()
        {
            totalFactura = montoActualCaja;
            foreach (DataGridViewRow fila in dataGridFacturaProductos.Rows)
            {
                int i = 0;
                int cantidad = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    //Determinamos la cantidad del producto
                    if (i==1)
                    {
                        cantidad = Convert.ToInt32(fila.Cells[i].Value);
                    }
                    else
                    {
                        //Determinamos el valor por unidad y luego multiplicamos por la cantidad
                        if(i == 4)
                        {
                            int valorUnidad = Convert.ToInt32(fila.Cells[i].Value);
                            int valorTotal = valorUnidad * cantidad;
                            totalFactura = totalFactura + valorTotal;
                        }
                    }
                    i = i + 1;
                }
            }
            labelTotalFactura.Text = totalFactura.ToString();
        }
        public void ConsultarCajaAbierta() 
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                var cajasRegistradoras = new List<Caja> { respuesta.CajaRegistradora };
                labelCash.Text = respuesta.CajaRegistradora.Monto.ToString();
                idCajaAbierta = respuesta.CajaRegistradora.IdCaja;
                montoActualCaja = respuesta.CajaRegistradora.Monto;
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCash.Text = "Sin definir";
                }
            }
        }
        public void CargarArchivo(ProductoFacturaTxtService productoTxtService)
        {
            ProductoFacturaTxtConsultaResponse productoTxtConsultaResponse = productoTxtService.Consultar();
            if (productoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    string referencia = item.Referencia;
                    int cantidad = item.Cantidad;
                    cantidadProducto = cantidad;
                    string nombre = item.Nombre;
                    string detalle = item.Detalle;
                    double precio = item.Precio;
                    dataGridFacturaProductos.Rows.Add(referencia, cantidad, nombre, detalle, precio);
                }
                ContarProductosVendidos();
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
        private void EliminarFactura()
        {
            ProductoFacturaTxt productoTxt = new ProductoFacturaTxt();
            string mensaje = productoTxtService.EliminarHistorial();
            dataGridFacturaProductos.DataSource = null;
            ConsultarHistorial();
        }
        private Caja MapearCashCaja()
        {
            cajaRegistradora = new Caja();
            cajaRegistradora.IdCaja = idCajaAbierta;
            double totalMonto = totalFactura;
            cajaRegistradora.Monto = totalMonto;
            return cajaRegistradora;
        }
        private void ModificarCashCaja()
        {
            var respuesta = MessageBox.Show("¿Está seguro que quieres vender estos productos?", "Mensaje de venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Caja cajaRegistradora = MapearCashCaja();
                string mensaje = cajaRegistradoraService.ModificarCash(cajaRegistradora);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                labelCash.Text = "Sin definir";
            }
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            EliminarFactura();
            this.Close();
        }
        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            ModificarCashCaja();
            ConsultarCajaAbierta();
            EliminarFactura();
            this.Close();
        }
    }
}
