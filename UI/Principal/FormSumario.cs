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
        ClienteService clienteService;
        EmpleadoService empleadoService;
        EstanteService estanteService;
        Producto producto;
        Cliente cliente;
        Empleado empleado;
        List<Producto> productos;
        List<Cliente> clientes;
        List<Empleado> empleados;
        List<Estante> estantes;
        public InicioResumen()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            estanteService = new EstanteService(ConfigConnection.ConnectionString);
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
        private void ConsultarEstantes()
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            respuesta = estanteService.ConsultarTodos();
            estantes = respuesta.Estantes.ToList();
            if (respuesta.Estantes.Count != 0 && respuesta.Estantes != null)
            {
                labelEstantes.Text = estanteService.Totalizar().Cuenta.ToString();
            }
            else
            {
                if (respuesta.Estantes == null || respuesta.Estantes.Count == 0)
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
                labelCaja.Text = "$" + respuesta.CajaRegistradora.VentaDelDia.ToString();
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCaja.Text = "Sin definir";
                }
            }
        }
        private void ConsultarDatoDeClientes()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            respuesta = clienteService.ConsultarTodos();
            clientes = respuesta.Clientes.ToList();
            if (respuesta.Clientes.Count != 0 && respuesta.Clientes != null)
            {
                labelClientes.Text = clienteService.Totalizar().Cuenta.ToString();
            }
            else
            {
                if (respuesta.Clientes == null || respuesta.Clientes.Count == 0)
                {
                    labelClientes.Text= "Sin definir";
                }
            }
        }
        private void ConsultarDatoDeEmpleados()
        {
            ConsultaEmpleadoRespuesta respuesta = new ConsultaEmpleadoRespuesta();
            respuesta = empleadoService.ConsultarTodos();
            empleados = respuesta.Empleados.ToList();
            if (respuesta.Empleados.Count != 0 && respuesta.Empleados != null)
            {
                labelEmpleados.Text = empleadoService.Totalizar().Cuenta.ToString();
            }
            else
            {
                if (respuesta.Empleados == null || respuesta.Empleados.Count == 0)
                {
                    labelEmpleados.Text = "Sin definir";
                }
            }
        }
        public void MostrarDatos()
        {
            ConsultarDatoCaja();
            ConsultarDatoDeProductos();
            ConsultarDatoDeClientes();
            ConsultarDatoDeEmpleados();
            ConsultarEstantes();
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
