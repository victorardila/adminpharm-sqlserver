using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Drawing.Printing;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FormFacturaDeProducto : Form
    {
        Caja cajaRegistradora;
        Cliente cliente;
        CajaRegistradoraService cajaRegistradoraService;
        ClienteService clienteService;
        EmpleadoService empleadoService;
        DrogueriaService drogueriaService;
        Factura factura;
        Drogueria drogueria;
        ProductoService productoService;
        FacturaService facturaService;
        ProductoFacturaTxtService productoTxtService = new ProductoFacturaTxtService();
        ProductoVendidoTxtService productoVendidoTxtService = new ProductoVendidoTxtService();
        List<Factura> facturas;
        List<Drogueria> droguerias;
        //Variables de drogueria
        string idDrogueria = "#Drog";
        string nombreDrogueria;
        string nitDrogueria;
        string fraseDistintiva;
        string regimen;
        string pbx;
        string direccion;
        string telefono;

        string referencia;
        //Variables de caja
        double totalFactura = 0;
        string idCajaAbierta;
        double montoActualCaja;
        //Variables de productos
        string[] referencias = new string[1000];
        string referenciaProducto;
        int cantidadARestar;
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
        double precioDelProducto;
        //Variables Factura
        int productoLeido;
        public FormFacturaDeProducto()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            drogueriaService = new DrogueriaService(ConfigConnection.ConnectionString);
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            CargarArchivo(productoTxtService);
            ConsultarCajaAbierta();
            ConsultarDatosDrogueria();
            SumtoriaDeFactura();
            BuscararDrogueria();
        }
        private void MapearProductosVendidos(string referencia)
        {
            
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
                    if (i==0)
                    {
                        cantidad = Convert.ToInt32(fila.Cells[i].Value);
                        cantidadARestar = cantidad;
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
            labelTotalFacturaGenerada.Text = totalFactura.ToString();
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
                    int cantidad = item.Cantidad;
                    string referencia = item.Referencia;
                    cantidadProducto = cantidad;
                    string nombre = item.Nombre;
                    string detalle = item.Detalle;
                    double precio = item.Precio;
                    precioDelProducto = precio;
                    dataGridFacturaProductos.Rows.Add(cantidad, referencia, nombre, detalle, precio);
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
            double totalMonto = montoActualCaja+totalFactura;
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
                labelVueltosGenerado.Text = "";
                int pago = int.Parse(textPago.Text);
                int TotalFactura = int.Parse(labelTotalFacturaGenerada.Text);
                int diferencia = pago - TotalFactura;
                labelVueltosGenerado.Text = diferencia.ToString();
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            EliminarFactura();
            this.Close();
        }
        private void ConsultarDatosDrogueria()
        {
            BusqueDrogueriaRespuesta respuesta = new BusqueDrogueriaRespuesta();
            string id_Drogueria = "#Drog";
            respuesta = drogueriaService.BuscarPorId(id_Drogueria);
            if (respuesta.Drogueria != null)
            {
                var droguerias = new List<Drogueria> { respuesta.Drogueria };
                var drogueria = respuesta.Drogueria;
                nombreDrogueria = drogueria.NombreDrogueria;

            }
            else
            {
                if (respuesta.Drogueria == null)
                {
                    labelCash.Text = "Sin definir";
                }
            }
        }
        private void BuscararDrogueria()
        {
            BusqueDrogueriaRespuesta respuesta = new BusqueDrogueriaRespuesta();
            respuesta = drogueriaService.BuscarPorId(idDrogueria);
            if (respuesta.Drogueria != null)
            {
                nombreDrogueria = respuesta.Drogueria.NombreDrogueria;
                nitDrogueria = respuesta.Drogueria.NIT;
                fraseDistintiva = respuesta.Drogueria.FraseDistintiva;
                regimen = respuesta.Drogueria.Regimen;
                pbx = respuesta.Drogueria.PBX;
                direccion = respuesta.Drogueria.Direccion;
                telefono = respuesta.Drogueria.Telefono;
            }
            else
            {
                if (respuesta.Drogueria == null)
                {
                   
                }
            }
        }
        private Factura MapearFactura()
        {
            factura = new Factura();
            //Mapeamos Datos de Drogueria
            factura.NombreDrogueria = nombreDrogueria;
            factura.NIT = nitDrogueria;
            factura.FraseDistintiva = fraseDistintiva;
            factura.Regimen = regimen;
            factura.PBX = pbx;
            factura.Direccion = direccion;
            factura.Telefono = telefono;
            //Mapeamos Datos de factura
            factura.NombreDeEmpleado = textNombreEmpleado.Text;
            factura.Ciudad = "Valledupar, Cesar";
            factura.IdCaja = idCajaAbierta;
            factura.NombreDeCliente = textNombreCliente.Text;
            factura.TotalSinRedondeo = totalFactura;
            //Mapeamos Forma de pago
            factura.FormaDePago = comboFormaDePago.Text;
            return factura;
        }
        private void AgregarProductosAFacturaImprimir(Factura factura)
        {
            List<Factura> listFact = new List<Factura>();
            ProductoFacturaTxtConsultaResponse productoTxtConsultaResponse = productoTxtService.Consultar();
            if (productoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    factura.Cantidad = item.Cantidad;
                    factura.Referencia = item.Referencia;
                    factura.NombreDeProducto = item.Nombre;
                    factura.DetalleDeProducto = item.Detalle;
                    factura.PrecioDeProducto = item.Precio;
                    productoLeido = productoLeido + 1;
                    listFact.Add(factura);
                }
            }
        }
        private void Armarfactura(Factura factura)
        {
            AgregarProductosAFacturaImprimir(factura);
        }

        private void btnSearchEmpleado_Click(object sender, EventArgs e)
        {
            textSearchEmpleado.Visible = true;
            btnCloseEmpleado.Visible = true;
        }
        private void btnCloseEmpleado_Click(object sender, EventArgs e)
        {
            textSearchEmpleado.Visible = false;
            btnCloseEmpleado.Visible = false;
        }

        private void btnSearchCliente_Click(object sender, EventArgs e)
        {
            textSearchCliente.Visible = true;
            btnCloseCliente.Visible = true;
        }

        private void btnCloseCliente_Click(object sender, EventArgs e)
        {
            textSearchCliente.Visible = false;
            btnCloseCliente.Visible = false;
        }
        private void textSearchEmpleado_Enter(object sender, EventArgs e)
        {
            if(textSearchEmpleado.Text == "Buscar identificacion")
            {
                textSearchEmpleado.Text = "";
            }
        }
        private void textSearchCliente_Enter(object sender, EventArgs e)
        {
            if (textSearchCliente.Text == "Buscar identificacion")
            {
                textSearchCliente.Text = "";
            }
        }
        private void textSearchEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (textSearchEmpleado.Text != "")
            {
                BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
                string Id_Empleado=textSearchEmpleado.Text;
                respuesta = empleadoService.BuscarPorIdentificacion(Id_Empleado);
                if (respuesta.Empleado != null)
                {
                    labelAdvertenciaEmpleado.Visible = false;
                    var empleados = new List<Empleado> { respuesta.Empleado };
                    var empleado = respuesta.Empleado;
                    textNombreEmpleado.Text = empleado.Nombres;
                    textApellidoEmpleado.Text = empleado.Apellidos;
                    textIdentificacionEmpleado.Text = empleado.Identificacion;
                }
                else
                {
                    if (respuesta.Empleado == null)
                    {
                        labelAdvertenciaEmpleado.Visible = true;
                        textNombreEmpleado.Text = "";
                        textApellidoEmpleado.Text = "";
                        textIdentificacionEmpleado.Text = "";
                    }
                }
            }
        }

        private void textSearchCliente_TextChanged(object sender, EventArgs e)
        {
            if (textSearchCliente.Text != "")
            {
                BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
                string Id_Cliente = textSearchCliente.Text;
                respuesta = clienteService.BuscarPorIdentificacion(Id_Cliente);
                if (respuesta.Cliente != null)
                {
                    labelAdvertenciaEmpleado.Visible = false;
                    var clientes = new List<Cliente> { respuesta.Cliente };
                    var cliente = respuesta.Cliente;
                    textNombreCliente.Text = cliente.Nombres;
                    textApellidoCliente.Text = cliente.Apellidos;
                    textIdentificacionCliente.Text = cliente.Identificacion;
                    comboTipoDeId.Text = cliente.TipoDeIdentificacion;
                    comboSexo.Text = cliente.Sexo;
                    dateTimeFechaDeNacimiento.Value = cliente.FechaDeNacimiento;
                    textDireccion.Text = cliente.Direccion;
                    textTelefono.Text = cliente.Telefono;
                    textCorreo.Text = cliente.CorreoElectronico;
                }
                else
                {
                    if (respuesta.Cliente == null)
                    {
                        labelAdvertenciaCliente.Visible = true;
                        textNombreCliente.Text = "";
                        textApellidoCliente.Text = "";
                        textIdentificacionCliente.Text = "";
                        comboTipoDeId.Text = "";
                        comboSexo.Text = "";
                        dateTimeFechaDeNacimiento.Value = DateTime.Now;
                        textDireccion.Text = "";
                        textTelefono.Text = "";
                        textCorreo.Text = "";
                    }
                }
            }
        }
        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            Factura factura=MapearFactura();
            facturaService.Guardar(factura);
            ModificarCashCaja();
            ConsultarCajaAbierta();
            Armarfactura(factura);
            EliminarFactura();
            this.Close();
        }
        private void textPago_TextChanged_1(object sender, EventArgs e)
        {
            if (textPago.Text != "")
            {
                double totalFactura = double.Parse(labelTotalFacturaGenerada.Text);
                double pago = double.Parse(textPago.Text);
                labelVueltosGenerado.Text = (pago- totalFactura).ToString();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
    }
}
