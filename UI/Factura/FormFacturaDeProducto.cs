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
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;
using Font = System.Drawing.Font;

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
        List<ProductoFacturaTxt> productosFactura = new List<ProductoFacturaTxt>();
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
        int productoLeido = 0;
        string id_factura;
        int secuenciaDeFactura = 0;
        DateTime fechaFactura;
        string nombreEmpleado;
        string ciudad;
        string nombreCliente;
        double totalSinRedondeo;
        double totalConRedondeo;
        double valorDeRedondeo;
        string formaDePago; 
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
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //***********************************************Metodos*******************************************************
        private void MapearProductosVendidos(string referencia)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            respuesta = productoService.BuscarPorReferencia(referencia);
            if (respuesta.Producto != null)
            {
                var productos = new List<Producto> { respuesta.Producto };
                referenciaProducto = respuesta.Producto.Referencia;
                nombreProducto= respuesta.Producto.Nombre;
                detalleProducto= respuesta.Producto.Detalle;
                precioProducto= respuesta.Producto.PrecioDeVenta;
                ProductoVendidoTxt productoVendidoTxt = new ProductoVendidoTxt(cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, precioProducto);
                string mensaje = productoVendidoTxtService.Guardar(productoVendidoTxt);
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
                        cantidadProducto=Convert.ToInt32(fila.Cells[i].Value);
                    }
                    else
                    {
                        if (i == 1)
                        {
                            referencias[i] = Convert.ToString(fila.Cells[i].Value);
                            string referencia = referencias[i];
                            MapearProductosVendidos(referencia);
                            break;
                        }
                    }
                    i = i + 1;
                }
            }
        }
        private void MapearDatosActualesDeFactura(Factura factura)
        {
            factura.GenerarFechaYHoraFactura();
            fechaFactura = factura.FechaHora;
            nombreEmpleado = factura.NombreDeEmpleado;
            ciudad = factura.Ciudad;
            nombreCliente = factura.NombreDeCliente;
            totalSinRedondeo = factura.TotalSinRedondeo;
            factura.TotalizarFactura();
            totalConRedondeo = factura.TotalConRedondeo;
            totalFactura = factura.TotalFactura;
            valorDeRedondeo = factura.ValorDeRedondeo;
            formaDePago = factura.FormaDePago;
        }
        private void SumtoriaDeFactura()
        {
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
                            totalFactura = totalFactura+valorTotal;
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
        private Factura GenerarIdFactura()
        {
            factura = new Factura();
            factura.GenerarIdFactura();
            return factura;
        }
        private void SecuenciaDeFactura()
        {
            for(int i = 1; i <= 1000; i++)
            {
                BusquedaFacturaRespuesta respuesta = new BusquedaFacturaRespuesta();
                respuesta = facturaService.BuscarPorSecuencia(i);
                if (respuesta.Factura != null)
                {
                    secuenciaDeFactura = secuenciaDeFactura + 1;
                }
                else
                {
                    if (respuesta.Factura == null)
                    {
                        secuenciaDeFactura = i;
                        break;
                    }
                }
            }
        }
        private  void CargarArchivo(ProductoFacturaTxtService productoTxtService)
        {
            Factura factura = GenerarIdFactura();
            id_factura=factura.Id_Factura;
            labelIdGeneradoDeFactura.Text = id_factura;
            ProductoFacturaTxtConsultaResponse productoTxtConsultaResponse = productoTxtService.Consultar();
            if (productoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    cantidadProducto = item.Cantidad;
                    referenciaProducto = item.Referencia;
                    nombreProducto = item.Nombre;
                    detalleProducto = item.Detalle;
                    precioProducto = item.Precio;
                    dataGridFacturaProductos.Rows.Add(cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, precioProducto);
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
        private void ConsultarDatosDrogueria()
        {
            BusquedaDrogueriaRespuesta respuesta = new BusquedaDrogueriaRespuesta();
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
            BusquedaDrogueriaRespuesta respuesta = new BusquedaDrogueriaRespuesta();
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
            factura.Id_Factura = id_factura;
            //Mapeamos Datos de factura
            SecuenciaDeFactura();
            factura.SecuenciaDeFactura = secuenciaDeFactura;
            factura.NombreDeEmpleado = textNombreEmpleado.Text;
            factura.Ciudad = "Valledupar, Cesar";
            factura.IdCaja = idCajaAbierta;
            factura.NombreDeCliente = textNombreCliente.Text;
            factura.TotalSinRedondeo = totalFactura;
            //Mapeamos Forma de pago
            factura.FormaDePago = comboFormaDePago.Text;
            return factura;
        }
        private void Imprimirfactura()
        {
            //Proceso de impresion
            string nombreFactura = id_factura+".pdf";
            string directorio = @"C:\Users\VICTOR PC\Documents\Facturas\";
            string existingPathName = @"C:\Users\VICTOR PC\Documents\Facturas";
            string notExistingFileName = directorio + nombreFactura;

            if (Directory.Exists(existingPathName) && !File.Exists(notExistingFileName))
            {
                ImprimirDocumento = new PrintDocument();

                ImprimirDocumento.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                ImprimirDocumento.PrinterSettings.PrintFileName = notExistingFileName;
                ImprimirDocumento.PrinterSettings.PrintToFile = true;
                ImprimirDocumento.PrintPage += Imprimir;
                ImprimirDocumento.Print();
            }
        }

//*************************************************Eventos*****************************************************
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
        private void textSearchEmpleado_Enter(object sender, EventArgs e)
        {
            if (textSearchEmpleado.Text == "Buscar identificacion")
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
                string Id_Empleado = textSearchEmpleado.Text;
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
                    labelAdvertenciaCliente.Visible = false;
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

        private void textPago_TextChanged_1(object sender, EventArgs e)
        {
            if (textPago.Text != "")
            {
                double totalFactura = double.Parse(labelTotalFacturaGenerada.Text);
                double pago = double.Parse(textPago.Text);
                labelVueltosGenerado.Text = (pago - totalFactura).ToString();
            }
        }
//******************************************Administrar factura**************************************************
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial Narrow",10);
            int ancho = 220;
            int y = 20;
            StringFormat stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;
            stringFormatCenter.LineAlignment = StringAlignment.Center;

            StringFormat stringFormatRight = new StringFormat();
            stringFormatRight.Alignment = StringAlignment.Far;
            stringFormatRight.LineAlignment = StringAlignment.Far;
            
            e.Graphics.DrawString(nombreDrogueria, font, Brushes.Black, new RectangleF(0, y,ancho,20), stringFormatCenter);

            e.Graphics.DrawString("NIT: "+nitDrogueria, font, Brushes.Black, new RectangleF(0, y+40, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString(fraseDistintiva, font, Brushes.Black, new RectangleF(0, y+53, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("PBX: "+pbx, font, Brushes.Black, new RectangleF(0, y+66, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("Regimen: " + regimen, font, Brushes.Black, new RectangleF(0, y + 79, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("Direccion: "+direccion, font, Brushes.Black, new RectangleF(0, y+92, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("Telefono: "+telefono, font, Brushes.Black, new RectangleF(0, y+105, ancho, 13), stringFormatCenter);

            e.Graphics.DrawString("Id factura: " + id_factura, font, Brushes.Black, new RectangleF(0, y + 130, ancho, 13));
            e.Graphics.DrawString("Secuencia: " + secuenciaDeFactura, font, Brushes.Black, new RectangleF(0, y + 143, ancho, 13));
            e.Graphics.DrawString("FechaYhora: " + fechaFactura, font, Brushes.Black, new RectangleF(0, y + 156, ancho, 13));
            e.Graphics.DrawString("Empleado: " + nombreEmpleado, font, Brushes.Black, new RectangleF(0, y + 169, ancho, 13));
            e.Graphics.DrawString("Ciudad: " + ciudad, font, Brushes.Black, new RectangleF(0, y + 182, ancho, 13));
            e.Graphics.DrawString("Cliente: " + nombreCliente, font, Brushes.Black, new RectangleF(0, y + 195, ancho, 13));
            e.Graphics.DrawString("IdDeCaja: " + idCajaAbierta, font, Brushes.Black, new RectangleF(0, y + 208, ancho, 13));
            
            e.Graphics.DrawString("FACTURA DE PRODUCTOS", font, Brushes.Black, new RectangleF(0, y + 234, ancho, 14));
            
            e.Graphics.DrawString("Lista de productos", font, Brushes.Black, new RectangleF(0, y + 260, ancho, 14));
            e.Graphics.DrawString(" Cantidad "+" Nombre " + " Detalle "+" Precio ", font, Brushes.Black, new RectangleF(0, y + 274, ancho, 14));
            int r = 0;
            int j = 288;
            foreach (DataGridViewRow fila in dataGridFacturaProductos.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    e.Graphics.DrawString("   "+Convert.ToString(fila.Cells[i].Value) + "    " + Convert.ToString(fila.Cells[i+1].Value) +"   "+ Convert.ToString(fila.Cells[i+2].Value) +"    "+  Convert.ToString(fila.Cells[i+3].Value) +"   "+  Convert.ToString(fila.Cells[i+4].Value), font, Brushes.Black, new RectangleF(0, y + j, ancho, 14));
                    j = j + 14;
                    int x = y + j;
                    r = x;
                    break;
                }
            }
            e.Graphics.DrawString("Total sin redondeo: " + totalSinRedondeo, font, Brushes.Black, new RectangleF(0, r + 30, ancho, 14), stringFormatRight);
            e.Graphics.DrawString("Total con redondeo: " + totalConRedondeo, font, Brushes.Black, new RectangleF(0, r + 44, ancho, 14), stringFormatRight);
            e.Graphics.DrawString("Valor de redondeo: " + valorDeRedondeo, font, Brushes.Black, new RectangleF(0, r + 58, ancho, 14), stringFormatRight);
            e.Graphics.DrawString("Forma de pago: " + formaDePago, font, Brushes.Black, new RectangleF(0, r + 72, ancho, 14), stringFormatRight);

            e.Graphics.DrawString("!Gracias por su compra! ", font, Brushes.Black, new RectangleF(0, r + 98, ancho, 14), stringFormatCenter);
            e.Graphics.DrawString("     Vuelva pronto     ", font, Brushes.Black, new RectangleF(0, r + 112, ancho, 14), stringFormatCenter);
        }
//*************************************************Botones*****************************************************
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            EliminarFactura();
            this.Close();
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
        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            Factura factura = MapearFactura();
            MapearDatosActualesDeFactura(factura);
            facturaService.Guardar(factura);
            ContarProductosVendidos();
            ModificarCashCaja();
            ConsultarCajaAbierta();
            Imprimirfactura();
            EliminarFactura();
            this.Close();
        }

        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormFacturaDeProducto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
