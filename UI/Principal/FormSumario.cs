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
    public partial class InicioResumen : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        ProductoService productoService;
        Producto producto;
        List<Producto> productos;
        public InicioResumen()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            MostrarDatos();
        }

        private void ConsultarDatoDeProductos()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            respuesta = productoService.ConsultarTodos();
            productos = respuesta.Productos.ToList();
            if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
            {
                labelProductos.Text = productoService.Totalizar().Cuenta.ToString();
            }
            else
            {
                if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                {
                    labelProductos.Text = "Sin definir";
                }
            }
        }
        public void ConsultarDatoCaja()
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            string estado = "Abierta";
            respuesta = cajaRegistradoraService.BuscarPorEstado(estado);
            if (respuesta.CajaRegistradora != null)
            {
                var cajasRegistradoras = new List<Caja> { respuesta.CajaRegistradora };
                labelCaja.Text = "$" + respuesta.CajaRegistradora.Monto.ToString();
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCaja.Text = "Sin definir";
                }
            }
        }
        public void MostrarDatos()
        {
            ConsultarDatoCaja();
            ConsultarDatoDeProductos();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            labelRefresh.Visible = true;
            labelPapelera.Visible = false;
        }
        private void iconPapelera_MouseHover(object sender, EventArgs e)
        {
            labelPapelera.Visible = true;
            labelRefresh.Visible = false;
        }
    }
}
