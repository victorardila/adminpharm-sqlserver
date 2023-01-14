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
using System.Drawing.Printing;
using System.IO;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FormGestionCaja : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        ProductoVendidoTxtService productoVendidoTxtService;
        ProductoVendidoTxt productoVendidoTxt;
        List<ProductoVendidoTxt> productoVendidoTxts;
        List<Caja> cajasRegistradoras;
        Caja cajaRegistradora;
        FacturaService facturaService;
        DrogueriaService drogueriaService;
        //Variables de caja
        string idCajaAbierta;
        string fechaDeApertura;
        string horaDeApertura;
        double montoCaja;
        //Variables de producto
        string referenciaProducto;
        int cantidadARestar;
        int cantidadProducto;
        string nombreProducto;
        string detalleProducto;
        double precioProductos;
        double precioProductosRedondeado;
        //Variables de drogueria
        string idDrogueria = "#Drog";
        string nombreDrogueria;
        string nitDrogueria;
        string fraseDistintiva;
        string regimen;
        string pbx;
        string direccion;
        string telefono;
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
        public FormGestionCaja()
        {
            drogueriaService = new DrogueriaService(ConfigConnection.ConnectionString);
            productoVendidoTxtService = new ProductoVendidoTxtService();
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarYLlenarGridDeCajas();
            BuscararDrogueria();
            BuscarPorEstado();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultarYLlenarGridDeCajas()
        {
            ConsultaCajaRegistradoraRespuesta respuesta = new ConsultaCajaRegistradoraRespuesta();
            string tipo = comboFiltroEstado.Text;
            if (tipo == "Todos")
            {
                textTotalCajas.Enabled = true;
                textTotalCajasAbiertas.Enabled = true;
                textTotalCajasCerradas.Enabled = true;
                dataGridFarmacos.DataSource = null;
                respuesta = cajaRegistradoraService.ConsultarTodos();
                cajasRegistradoras = respuesta.CajasRegistradoras.ToList();
                if (respuesta.CajasRegistradoras.Count != 0 && respuesta.CajasRegistradoras!=null)
                {
                    dataGridFarmacos.DataSource = respuesta.CajasRegistradoras;
                    Eliminar.Visible = true;
                    textTotalCajas.Text = cajaRegistradoraService.Totalizar().Cuenta.ToString();
                    textTotalCajasAbiertas.Text = cajaRegistradoraService.TotalizarTipo("Abierta").Cuenta.ToString();
                    textTotalCajasCerradas.Text = cajaRegistradoraService.TotalizarTipo("Cerrada").Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.CajasRegistradoras == null|| respuesta.CajasRegistradoras.Count == 0)
                    {
                        MostrarAviso();
                        btnHistorial.Enabled = false;
                        Eliminar.Visible = false;
                        labelAdvertencia.Visible = true;
                    }
                }
            }
        }
        private void BuscarPorEstado()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                var cajasRegistradoras = new List<Caja> { respuesta.CajaRegistradora };
                labelCash.Text = respuesta.CajaRegistradora.Monto.ToString();
                btnAbrirCaja.Enabled = false;
                btnCerrarCaja.Enabled = true;
                idCajaAbierta = respuesta.CajaRegistradora.IdCaja;
                fechaDeApertura = respuesta.CajaRegistradora.FechaDeApertura;
                horaDeApertura = respuesta.CajaRegistradora.HoraDeApertura;
                montoCaja = respuesta.CajaRegistradora.Monto;
                ConsultarYLlenarGridDeCajas();
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    btnCerrarCaja.Enabled = false;
                    labelCash.Text = "Sin definir";
                }
            }
        }
        private void MostrarAviso()
        {
            labelAdvertencia.Visible = true;
        }
        private void Limpiar()
        {
            textTotalCajas.Text = "0";
            textTotalCajasAbiertas.Text = "0";
            textTotalCajasCerradas.Text = "0";
        }
        private void comboFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from CAJA where Estado='" + comboFiltroEstado.Text + "'";
            UpdateGrid(query, "CAJA");
            if (comboFiltroEstado.Text == "Todos")
            {
                ConsultarYLlenarGridDeCajas();
                textTotalCajas.Enabled = true;
                textTotalCajasAbiertas.Enabled = true;
                textTotalCajasCerradas.Enabled = true;
            }
            else
            {
                BuscarPorEstado();
            }
        }
        public void UpdateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.AdminPharmConnectionString));
            DataSet dad = new DataSet();
            ada.Fill(dad, tbl);
            dataGridFarmacos.DataSource = dad;
            dataGridFarmacos.DataMember = tbl;
        }
        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            FormAbrirCaja frm = new FormAbrirCaja();
            frm.ShowDialog();
            BuscarPorEstado();
        }
        private Caja MapearCaja()
        {
            cajaRegistradora = new Caja();
            cajaRegistradora.IdCaja = idCajaAbierta;
            cajaRegistradora.FechaDeApertura = fechaDeApertura;
            cajaRegistradora.HoraDeApertura = horaDeApertura;
            cajaRegistradora.Monto = montoCaja;
            return cajaRegistradora;
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
        private void ProductosRegistradosEnCaja()
        {
            productoVendidoTxts = new List<ProductoVendidoTxt>();
            ProductoVendidoTxtConsultaResponse productoTxtConsultaResponse = productoVendidoTxtService.Consultar();
            if (productoTxtConsultaResponse.ProductoTxts.Count > 0)
            {
                foreach (var item in productoTxtConsultaResponse.ProductoTxts)
                {
                    productoVendidoTxt = new ProductoVendidoTxt();
                    productoVendidoTxt.Cantidad = item.Cantidad;
                    productoVendidoTxt.Referencia = item.Referencia;
                    productoVendidoTxt.Nombre = item.Nombre;
                    productoVendidoTxt.Detalle = item.Detalle;
                    productoVendidoTxt.Precio = item.Precio;
                    precioProductos = precioProductos+item.Precio;
                    precioProductosRedondeado = Math.Ceiling(precioProductos);
                    valorDeRedondeo = precioProductosRedondeado - precioProductos;
                    productoVendidoTxts.Add(productoVendidoTxt);
                }
                FacturarProductosVendidosEnCaja();
            }
            else
            {
                if (productoTxtConsultaResponse.ProductoTxts.Count == 0)
                {
                    string mensaje = "No hay productos vendidos";
                    MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private void EliminarProductosVendidos()
        {
            string mensaje = productoVendidoTxtService.EliminarHistorial();
        }
        private void FacturarProductosVendidosEnCaja()
        {
            fechaFactura = DateTime.Now;
            ciudad = "Valledupar, Cesar";
        }
        private void ValidarDatosDeCaja(ProductoVendidoTxtService productoVendidoTxtService)
        {
            ProductoVendidoTxtConsultaResponse productoVendidoTxtConsultaResponse = productoVendidoTxtService.Consultar();
            if (productoVendidoTxtConsultaResponse.ProductoTxts.Count >= 0)
            {
                var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Caja cajaRegistradora = MapearCaja();
                    string mensaje = cajaRegistradoraService.Modificar(cajaRegistradora);
                    MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ProductosRegistradosEnCaja();
                    ImprimirDatoDeVenta();
                    ConsultarYLlenarGridDeCajas();
                    btnAbrirCaja.Enabled = true;
                    btnCerrarCaja.Enabled = false;
                    btnHistorial.Enabled = true;
                    labelCash.Text = "Sin definir";
                }
            }
            else
            {
                if (productoVendidoTxtConsultaResponse.ProductoTxts.Count == 0)
                {
                    string mensaje = "No hay productos vendidos, no puede cerrar la caja";
                    MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            ValidarDatosDeCaja(productoVendidoTxtService);
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            string estado = "Cerrada";
            if (estado != "")
            {
                var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de cajas cerradas?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = cajaRegistradoraService.EliminarHistorial(estado);
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MostrarAviso();
                labelAdvertencia.Text = "No hay cajas cerradas";
            }
            ConsultarYLlenarGridDeCajas();
            Limpiar();
        }
        private void EliminarCaja(string Id)
        {
            string mensaje = cajaRegistradoraService.Eliminar(Id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Eliminar.Visible = false;
            btnAbrirCaja.Enabled = true;
            btnCerrarCaja.Enabled = false;
        }
        private void dataGridFarmacos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id;
            if (dataGridFarmacos.DataSource != null)
            {
                if (btnCerrarCaja.Enabled == false)
                {
                    if (dataGridFarmacos.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        Id = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["IdCaja"].Value.ToString());
                        string msg = "Desea eliminar este registro " + Id + "?";
                        var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (respuesta == DialogResult.OK)
                        {
                            EliminarCaja(Id);
                            ConsultarYLlenarGridDeCajas();
                        }
                    }
                }
                else
                {
                    if (btnCerrarCaja.Enabled == false)
                    {
                        Eliminar.Visible = false;
                    }
                }
            }
            else
            {
                if (dataGridFarmacos .DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ImprimirDatoDeVenta()
        {
            //Proceso de impresion
            string nombreFactura = idCajaAbierta+"ProductosVendidos" + ".pdf";
            string directorio = @"C:\Users\VICTOR PC\Documents\CierreDeCajas\";
            string existingPathName = @"C:\Users\VICTOR PC\Documents\CierreDeCajas";
            string notExistingFileName = directorio + nombreFactura;

            if (Directory.Exists(existingPathName) && !File.Exists(notExistingFileName))
            {
                ImprimirProductosVendidos = new PrintDocument();

                ImprimirProductosVendidos.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                ImprimirProductosVendidos.PrinterSettings.PrintFileName = notExistingFileName;
                ImprimirProductosVendidos.PrinterSettings.PrintToFile = true;
                ImprimirProductosVendidos.PrintPage += Imprimir;
                ImprimirProductosVendidos.Print();
            }
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            EliminarProductosVendidos();
            Font font = new Font("Arial Narrow", 10);
            int ancho = 220;
            int y = 20;
            StringFormat stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;
            stringFormatCenter.LineAlignment = StringAlignment.Center;

            StringFormat stringFormatRight = new StringFormat();
            stringFormatRight.Alignment = StringAlignment.Far;
            stringFormatRight.LineAlignment = StringAlignment.Far;

            e.Graphics.DrawString(nombreDrogueria, font, Brushes.Black, new RectangleF(0, y, ancho, 20), stringFormatCenter);

            e.Graphics.DrawString("NIT: " + nitDrogueria, font, Brushes.Black, new RectangleF(0, y + 40, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString(fraseDistintiva, font, Brushes.Black, new RectangleF(0, y + 53, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("PBX: " + pbx, font, Brushes.Black, new RectangleF(0, y + 66, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("Regimen: " + regimen, font, Brushes.Black, new RectangleF(0, y + 79, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("Direccion: " + direccion, font, Brushes.Black, new RectangleF(0, y + 92, ancho, 13), stringFormatCenter);
            e.Graphics.DrawString("Telefono: " + telefono, font, Brushes.Black, new RectangleF(0, y + 105, ancho, 13), stringFormatCenter);

            e.Graphics.DrawString("FechaYhora: " + fechaFactura, font, Brushes.Black, new RectangleF(0, y + 130, ancho, 13));
            e.Graphics.DrawString("Ciudad: " + ciudad, font, Brushes.Black, new RectangleF(0, y + 143, ancho, 13));
            e.Graphics.DrawString("IdDeCaja: " + idCajaAbierta, font, Brushes.Black, new RectangleF(0, y + 156, ancho, 13));

            e.Graphics.DrawString("CIERRE DE CAJA", font, Brushes.Black, new RectangleF(0, y + 180, ancho, 14));
            e.Graphics.DrawString("Lista de productos", font, Brushes.Black, new RectangleF(0, y + 206, ancho, 14));
            e.Graphics.DrawString(" Cantidad " + " Nombre " + " Detalle " + " Precio ", font, Brushes.Black, new RectangleF(0, y + 220, ancho, 14));
            int r = 0;
            int j = 234;
            int i = 0;
            foreach (var item in productoVendidoTxts)
            {
                e.Graphics.DrawString("   " + Convert.ToString(item.Cantidad) + "    " + Convert.ToString(item.Referencia) + "   " + Convert.ToString(item.Nombre) + "    " + Convert.ToString(item.Detalle) + "   " + Convert.ToString(item.Precio), font, Brushes.Black, new RectangleF(0, y + j, ancho, 14));
                j = j + 14;
                int x = y + j;
                r = x;
            }
            e.Graphics.DrawString("Total sin redondeo: " + precioProductos, font, Brushes.Black, new RectangleF(0, r + 30, ancho, 14), stringFormatRight);
            e.Graphics.DrawString("Total con redondeo: " + precioProductosRedondeado, font, Brushes.Black, new RectangleF(0, r + 44, ancho, 14), stringFormatRight);
            e.Graphics.DrawString("Valor de redondeo: " + valorDeRedondeo, font, Brushes.Black, new RectangleF(0, r + 58, ancho, 14), stringFormatRight);
            

            e.Graphics.DrawString("!Gracias por su compra! ", font, Brushes.Black, new RectangleF(0, r + 72, ancho, 14), stringFormatCenter);
            e.Graphics.DrawString("     Vuelva pronto     ", font, Brushes.Black, new RectangleF(0, r + 98, ancho, 14), stringFormatCenter);
        }
    }
}
