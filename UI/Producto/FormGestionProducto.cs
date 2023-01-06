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
using System.Threading;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FormGestionProducto : Form
    {
        ProductoService productoService;
        DrogueriaService drogueriaService;
        ProductoFacturaTxtService productoTxtService=new ProductoFacturaTxtService();
        ProductoVencidoTxtService productoVencidoTxtService = new ProductoVencidoTxtService();
        List<Producto> productos;
        List<Drogueria> droguerias;
        Producto producto;
        CajaRegistradoraService cajaRegistradoraService;
        int cantidadDrogueria;
        bool cajaAbierta;
        string referenciaProducto;
        int cantidadProducto;
        int cantidadARestar;
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
        int x = 0;
        int cantidad;
        int[] cantidades = new int[1000];

        public FormGestionProducto()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            drogueriaService = new DrogueriaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarYLlenarGridDeProductos();
            ConsultarDroguerias();
            CalcularProvisiones();
            CalculoDeEstadoAutomatico();
        }
        private void CalcularProvisiones()
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            foreach (DataGridViewRow fila in dataGridFarmacos.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (i == 5)
                    {
                        string referencia = Convert.ToString(fila.Cells[5].Value);
                        respuesta = productoService.BuscarPorReferencia(referencia);
                        int cantidad= respuesta.Producto.Cantidad;
                        if (cantidad > 0 && cantidad < 5)
                        {
                            respuesta = productoService.BuscarPorReferencia(referencia);
                            if (respuesta.Producto != null)
                            {
                                labelMedicamentosAgotados.Visible = true;
                                string nombre = respuesta.Producto.Nombre;
                                labelMedicamentosAgotados.Visible = true;
                                labelMedicamentosAgotados.Text = "el medicamento " + nombre + " se esta agotando";
                                Thread.Sleep(2000);
                                labelMedicamentosAgotados.Visible = false;
                            }
                        }
                        else
                        {
                            if (cantidad == 0)
                            {
                                respuesta = productoService.BuscarPorReferencia(referencia);
                                if (respuesta.Producto != null)
                                {
                                    labelMedicamentosAgotados.Visible = true;
                                    string nombre = respuesta.Producto.Nombre;
                                    labelMedicamentosAgotados.Visible = true;
                                    labelMedicamentosAgotados.Text = "el medicamento " + nombre + " se agoto";
                                    Thread.Sleep(2000);
                                    labelMedicamentosAgotados.Visible = false;
                                }
                            }
                        }
                    }
                    i = i + 1;
                }
            }
        } 
        public void CalculoDeEstadoAutomatico()
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            foreach (DataGridViewRow fila in dataGridFarmacos.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (i == 5)
                    {
                        string referencia = Convert.ToString(fila.Cells[5].Value);
                        respuesta = productoService.BuscarPorReferencia(referencia);
                        if (respuesta.Producto != null)
                        {
                            var productos = new List<Producto> { respuesta.Producto };
                            producto = respuesta.Producto;
                            string mensaje = productoService.ModificarEstado(producto);
                            if (producto.Estado == "Vencido")
                            {
                                referenciaProducto = producto.Referencia;
                                cantidadProducto = producto.Cantidad;
                                nombreProducto = producto.Nombre;
                                detalleProducto = producto.Detalle;
                                fechaDeRegistro = producto.FechaDeRegistro;
                                fechaDeVencimiento = producto.FechaDeVencimiento;
                                loteProducto = producto.Lote;
                                laboratorioProducto = producto.Laboratorio;
                                estadoProducto = producto.Estado;
                                tipoProducto = producto.Tipo;
                                viaProducto = producto.Via;
                                precioDeNegocio = producto.PrecioDeNegocio;
                                precioProducto = producto.PrecioDeVenta;
                                porcentajeDeVenta = producto.GananciaPorProducto;
                                ProductoVencidoTxt productoTxt = new ProductoVencidoTxt(
                                    cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, fechaDeRegistro, 
                                    fechaDeVencimiento, loteProducto, laboratorioProducto, estadoProducto, tipoProducto, viaProducto,
                                    precioDeNegocio, precioProducto, porcentajeDeVenta);
                                productoVencidoTxtService.Guardar(productoTxt);
                                productoService.Eliminar(referenciaProducto);
                                ConsultarYLlenarGridDeProductos();
                            }
                        }
                    }
                    i = i + 1;
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
                cajaAbierta = true;
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCash.Text = "Sin definir";
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultarYLlenarGridDeProductos()
        {
            BuscarPorEstado();
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string via = comboFiltroVia.Text;
            string tipo = comboFiltroTipo.Text;
            if (via == "Todos" && tipo == "Todos")
            {
                textTotal.Enabled = true;
                textCuarentena.Enabled = true;
                textVigentes.Enabled = true;
                dataGridFarmacos.DataSource = null;
                respuesta = productoService.ConsultarTodos();
                productos = respuesta.Productos.ToList();
                if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
                {
                    dataGridFarmacos.DataSource = respuesta.Productos;
                    Eliminar.Visible = true;
                    textTotal.Text = productoService.Totalizar().Cuenta.ToString();
                    textVigentes.Text = productoService.TotalizarTipo("Vigente").Cuenta.ToString();
                    textCuarentena.Text = productoService.TotalizarTipo("Cuarentena").Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                    {
                        MostrarAviso();
                        Eliminar.Visible = false;
                        labelAdvertencia.Visible = true;
                    }
                }
            }
        }
        private void MostrarAviso()
        {
            labelAdvertencia.Visible = true;
        }

        private void BuscarPorVia()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string via = comboFiltroVia.Text;
            respuesta = productoService.BuscarPorViaAdminitracion(via);
            if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
            {
                dataGridFarmacos.DataSource = respuesta.Productos;
            }
            else
            {
                if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                {
                    labelAdvertencia.Enabled = true;
                    labelAdvertencia.Text = "No hay medicametos de este tipo";
                    string msg = "¡No se encontró medicamentos asociados!";
                    MessageBox.Show(msg, "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboFiltroVia.Text = "Todos";
                }
            }
        }
        private void BuscarPorTipo()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string tipo = comboFiltroTipo.Text;
            respuesta = productoService.BuscarPorTipo(tipo);
            if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
            {
                dataGridFarmacos.DataSource = respuesta.Productos;
            }
            else
            {
                if (respuesta.Productos == null || respuesta.Productos.Count == 0)
                {
                    labelAdvertencia.Enabled = true;
                    labelAdvertencia.Text = "No hay medicametos de este tipo";
                    string msg = "¡No se encontró medicamentos asociados!";
                    MessageBox.Show(msg, "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboFiltroTipo.Text = "Todos";
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            textSearch.Visible = true;
            btnClose.Visible = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            textSearch.Visible = false;
            btnClose.Visible = false;
        }
        private void dataGridFarmacos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string referencia;
            if (dataGridFarmacos.DataSource != null)
            {
                if (dataGridFarmacos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    referencia = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["Referencia"].Value.ToString());
                    string msg = "Desea eliminar este registro " + referencia + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarProducto(referencia);
                        ConsultarYLlenarGridDeProductos();
                    }
                }
            }
            else
            {
                if (dataGridFarmacos.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ObtenerCantidadDeProducto()
        {
            int i = 0;
            foreach (DataGridViewRow fila in dataGridFarmacos.Rows)
            {
                bool isChecked = Convert.ToBoolean(fila.Cells[0].Value);
                if (isChecked)
                {
                    int j = 0;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (j == 3)
                        {
                            cantidades[i] = Convert.ToInt32(fila.Cells[3].Value);
                            break;
                        }
                        j = j + 1;
                    }
                }
                i = i + 1;
            }
        }
        private void LeerCantidadProducto()
        {
            int e = 0;
            for (int i = x; i < 1000; i++)
            {
                if (cantidades[i] > 0)
                {
                    cantidad = cantidades[i];
                    x = x + 1;
                    e = x;
                }
                x = e;
                break;
            }
        }
        private void MapearMedicamentosFactura(string referencia)
        {
            ObtenerCantidadDeProducto();
            LeerCantidadProducto();
            if (cantidad!=0)
            {
                BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
                respuesta = productoService.BuscarPorReferencia(referencia);
                if (respuesta.Producto != null)
                {
                    var productos = new List<Producto> { respuesta.Producto };
                    referenciaProducto = respuesta.Producto.Referencia;
                    cantidadProducto = respuesta.Producto.Cantidad;
                    cantidadARestar = cantidad;
                    nombreProducto = respuesta.Producto.Nombre;
                    detalleProducto = respuesta.Producto.Detalle;
                    precioProducto = respuesta.Producto.PrecioDeVenta;
                    laboratorioProducto = respuesta.Producto.Laboratorio;
                    fechaDeRegistro = respuesta.Producto.FechaDeRegistro;
                    fechaDeVencimiento = respuesta.Producto.FechaDeVencimiento;
                    loteProducto = respuesta.Producto.Lote;
                    viaProducto = respuesta.Producto.Via;
                    tipoProducto = respuesta.Producto.Tipo;
                    precioDeNegocio = respuesta.Producto.PrecioDeNegocio;
                    porcentajeDeVenta = respuesta.Producto.PorcentajeDeVenta;
                    ProductoFacturaTxt productoTxt = new ProductoFacturaTxt(cantidadARestar, referenciaProducto, nombreProducto, detalleProducto, precioProducto);
                    string mensaje = productoTxtService.Guardar(productoTxt);

                    Producto producto = CalculosDefactura();
                    mensaje = productoService.ModificarCantidad(producto);
                }
                else
                {
                    if (respuesta.Producto == null)
                    {
                        labelAdvertencia.Text = "***";
                    }
                }
            }
        }
        private void ValidarCantidadesIngresadas(string referencia)
        {
            int cantidadADescontar = 0;
            int cantidadEnInventario = 0;
            foreach (DataGridViewRow fila in dataGridFarmacos.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (i == 3)
                    {
                        cantidadADescontar = Convert.ToInt32(fila.Cells[i].Value);
                    }
                    else
                    {
                        if (i == 4)
                        {
                            cantidadEnInventario = Convert.ToInt32(fila.Cells[i].Value);
                            if (cantidadADescontar <= cantidadEnInventario)
                            {
                                MapearMedicamentosFactura(referencia);
                                break;
                            }
                            else
                            {
                                string mensaje = "No puedes superar la cantidad registrada en el inventario";
                                MessageBox.Show(mensaje, "Error de digitacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    i = i + 1;
                }
                break;
            }
        }
        private void ConsultarDroguerias()
        {
            ConsultaDrogueriaRespuesta respuesta = new ConsultaDrogueriaRespuesta();
            respuesta = drogueriaService.ConsultarTodos();
            droguerias = respuesta.Droguerias.ToList();
            if (respuesta.Droguerias.Count != 0 && respuesta.Droguerias != null)
            {
                cantidadDrogueria=drogueriaService.Totalizar().Cuenta;
            }
            else
            {
                if (respuesta.Droguerias == null || respuesta.Droguerias.Count == 0)
                {
                    
                }
            }
        }
        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            int TotalSeleccion = dataGridFarmacos.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Column1"].Value)).Count();
            string referencia;
            if (TotalSeleccion >= 1)
            {
                if (cajaAbierta == true)
                {
                    if (cantidadDrogueria == 1)
                    {
                        foreach (DataGridViewRow row in dataGridFarmacos.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["Column1"].Value) == true)
                            {
                                referencia = Convert.ToString(row.Cells["Referencia"].Value);
                                ValidarCantidadesIngresadas(referencia);
                            }
                        }
                        x = 0;
                        FormFacturaDeProducto frm = new FormFacturaDeProducto();
                        frm.ShowDialog();
                        ConsultarYLlenarGridDeProductos();
                    }
                    else
                    {
                        string mensaje = "No se ha registrado datos de drogueria, asi que no se puede generar factura";
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string mensaje = "No hay caja abierta, asi que no se puede cargar productos a la factura";
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (TotalSeleccion == 0)
                {
                    string mensaje = "No se ha cargado los productos para la factura";
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void EliminarProducto(string referencia)
        {
            string mensaje = productoService.Eliminar(referencia);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Eliminar.Visible = false;
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormRegistrarProducto frm = new FormRegistrarProducto();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos();
            CalculoDeEstadoAutomatico();
        }
        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            FormProductosVendidos frm = new FormProductosVendidos();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos();
            CalculoDeEstadoAutomatico();
        }
        private void btnFarmacosVencidos_Click(object sender, EventArgs e)
        {
            FormProductosVencidos frm = new FormProductosVencidos();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos();
            CalculoDeEstadoAutomatico();
        }
        private Producto CalculosDefactura()
        {
            producto = new Producto();
            producto.Cantidad= cantidadProducto-cantidadARestar;
            producto.Referencia = referenciaProducto;
            producto.Nombre = nombreProducto;
            producto.Lote = loteProducto;
            producto.Laboratorio = laboratorioProducto;
            producto.FechaDeRegistro = fechaDeRegistro;
            producto.FechaDeVencimiento = fechaDeVencimiento;
            producto.Detalle = detalleProducto;
            producto.Tipo = tipoProducto;
            producto.Via = viaProducto;
            producto.PrecioDeNegocio = precioDeNegocio;
            producto.PorcentajeDeVenta = porcentajeDeVenta;
            return producto;
        }
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            FormRegistrarProducto frm = new FormRegistrarProducto();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos();
        }

        private void UpdateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.AdminPharmConnectionString));
            DataSet dad = new DataSet();
            ada.Fill(dad, tbl);
            dataGridFarmacos.DataSource = dad;
            dataGridFarmacos.DataMember = tbl;
        }
        private void comboFiltroVia_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from PRODUCTO where Via='" + comboFiltroVia.Text + "'";
            UpdateGrid(query, "PRODUCTO");
            if (comboFiltroVia.Text == "Todos")
            {
                ConsultarYLlenarGridDeProductos();
                textTotal.Enabled = true;
                textVigentes.Enabled = true;
                textCuarentena.Enabled = true;
            }
            else
            {
                BuscarPorVia();
            }
        }
        private void comboFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from PRODUCTO where Tipo='" + comboFiltroTipo.Text + "'";
            UpdateGrid(query, "PRODUCTO");
            if (comboFiltroTipo.Text == "Todos")
            {
                ConsultarYLlenarGridDeProductos();
                textTotal.Enabled = true;
                textVigentes.Enabled = true;
                textCuarentena.Enabled = true;
            }
            else
            {
                BuscarPorTipo();
            }
        }
        private void textSearch_Enter(object sender, EventArgs e)
        {
            if(textSearch.Text=="Buscar nombre")
            {
                textSearch.Text = "";
            }
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != "")
            {
                dataGridFarmacos.CurrentCell = null;
                foreach(DataGridViewRow fila in dataGridFarmacos.Rows)
                {
                    fila.Visible = false;
                }
                foreach(DataGridViewRow fila in dataGridFarmacos.Rows)
                {
                    int i = 0;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (i >= 4)
                        {
                            if ((celda.Value.ToString().ToUpper()).IndexOf(textSearch.Text.ToUpper()) == 0)
                            {
                                fila.Visible = true;
                                break;
                            }
                        }
                        i = i + 1;
                    }
                }
            }
            else
            {
                ConsultarYLlenarGridDeProductos();
            }
        }
    }
}

