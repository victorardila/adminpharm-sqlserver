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
        EstanteService estanteService;
        VitrinaService vitrinaService;
        NeveraService neveraService;
        ProductoFacturaTxtService productoTxtService=new ProductoFacturaTxtService();
        ProductoVencidoTxtService productoVencidoTxtService = new ProductoVencidoTxtService();
        RutasTxtService rutasTxtService = new RutasTxtService();
        List<Producto> productos;
        List<Estante> estantes;
        List<Drogueria> droguerias;
        List<Vitrina> vitrinas;
        List<Nevera> neveras;
        Producto producto;
        CajaRegistradoraService cajaRegistradoraService;
        string[] ReferenciasProductosAVender=new string[100];
        int[] CantidadesProductosAVender = new int[100];
        string referencia;
        string rutasVendidos;
        string referenciaBotonDatagrid;
        int TotalSeleccion=1;
        int cantidadDeRegistros=20;
        int totalRegistros;
        int paginaSeleccionada=0;
        int paginaSeleccion;
        int totalPaginas;
        int contador;
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
        double porcentajeDeVenta;
        double precioDeNegocio;
        double gananciaDeProducto;
        int cantidadEstante;
        int cantidadVitrinas;
        int cantidadNeveras;
        int cantidad;
        object sender;
        EventArgs e;
        int x;
        int i=0;

        public FormGestionProducto()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            drogueriaService = new DrogueriaService(ConfigConnection.ConnectionString);
            estanteService = new EstanteService(ConfigConnection.ConnectionString);
            vitrinaService = new VitrinaService(ConfigConnection.ConnectionString);
            neveraService = new NeveraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            IniciarOperaciones();
            ConsultarDroguerias();
            ConsultarEstantes();
            ConsultarVitrinas();
            ConsultarNeveras();
        }
        private void IniciarOperaciones()
        {
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
            Thread calcularEstadoAutomatico = new Thread(CalculoDeEstadoAutomatico);
            calcularEstadoAutomatico.Start();
        }
        private void LlenarComboUbicacionDeEstantes(int cantidad)
        {
            int i = contador;
            for (i = 1; i <= cantidad; i = i + 1)
            {
                string estante = "Estante " + i;
                comboUbicacion.Items.Add(estante);
                contador = i;
            }
        }
        private void LlenarComboUbicacionDeVitrinas(int cantidad)
        {
            int i = contador;
            for (i = 1; i <= cantidad; i = i + 1)
            {
                string vitrina = "Vitrina " + i;
                comboUbicacion.Items.Add(vitrina);
                contador = i;
            }
        }
        private void LlenarComboUbicacionDeNeveras(int cantidad)
        {
            int i = contador;
            for (i = 1; i <= cantidad; i = i + 1)
            {
                string nevera = "Nevera " + i;
                comboUbicacion.Items.Add(nevera);
                contador = i;
            }
        }
        public void CalculoDeEstadoAutomatico()
        {
            string referencia="";
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            foreach (DataGridViewRow fila in dataGridFarmacos.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (i == 6)
                    {
                        referencia = Convert.ToString(fila.Cells[6].Value);
                        respuesta = productoService.BuscarPorReferencia(referencia);
                        if (respuesta.Producto != null)
                        {
                            var producto = respuesta.Producto;
                            string mensaje = productoService.ModificarEstado(producto);
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
                labelCash.Text = respuesta.CajaRegistradora.VentaDelDia.ToString();
                labelBase.Text = respuesta.CajaRegistradora.MontoInicial.ToString();
                cajaAbierta = true;
            }
            else
            {
                if (respuesta.CajaRegistradora == null)
                {
                    labelCash.Text = "Sin definir";
                    labelBase.Text = "Sin definir";
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultarEstantes()
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            respuesta = estanteService.ConsultarTodos();
            estantes = respuesta.Estantes.ToList();
            if (respuesta.Estantes.Count != 0 && respuesta.Estantes != null)
            {
                cantidadEstante = estanteService.Totalizar().Cuenta;
                LlenarComboUbicacionDeEstantes(cantidadEstante);
            }
        }
        private void ConsultarVitrinas()
        {
            ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
            respuesta = vitrinaService.ConsultarTodos();
            vitrinas = respuesta.Vitrinas.ToList();
            if (respuesta.Vitrinas.Count != 0 && respuesta.Vitrinas != null)
            {
                cantidadVitrinas = vitrinaService.Totalizar().Cuenta;
                LlenarComboUbicacionDeVitrinas(cantidadEstante);
            }
        }
        private void ConsultarNeveras()
        {
            ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
            respuesta = neveraService.ConsultarTodos();
            neveras = respuesta.Neveras.ToList();
            if (respuesta.Neveras.Count != 0 && respuesta.Neveras != null)
            {
                cantidadNeveras = neveraService.Totalizar().Cuenta;
                LlenarComboUbicacionDeNeveras(cantidadEstante);
            }
        }
        private void ConsultarYLlenarGridDeProductos(int paginaSelecciona)
        {
            paginaSeleccionada = paginaSelecciona;
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
                    totalRegistros = productoService.Totalizar().Cuenta;
                    totalPaginas = (int)Math.Ceiling(decimal.Parse(totalRegistros.ToString()) / decimal.Parse(cantidadDeRegistros.ToString()));
                    dataGridFarmacos.DataSource = respuesta.Productos.OrderBy(d=>d.Referencia).Skip(paginaSeleccionada*cantidadDeRegistros).Take(cantidadDeRegistros).ToList();
                    textNumeroPagina.Text = paginaSeleccionada.ToString();
                    dataGridFarmacos.ClearSelection();
                    Eliminar.Visible = true;
                    textTotal.Text = productoService.Totalizar().Cuenta.ToString();
                    textVigentes.Text = productoService.TotalizarTipo("Vigente").Cuenta.ToString();
                    textCuarentena.Text = productoService.TotalizarTipo("Cuarentena").Cuenta.ToString();
                    textVencido.Text= productoService.TotalizarTipo("Vencido").Cuenta.ToString();
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
        private void textNumeroPagina_Enter(object sender, EventArgs e)
        {
            if (textNumeroPagina.Text != "")
            {
                textNumeroPagina.Text = "";
            }
        }
        private void textNumeroPagina_Leave(object sender, EventArgs e)
        {
            if (textNumeroPagina.Text == "")
            {
                textNumeroPagina.Text = "0";
            }
        }
        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            paginaSeleccionada = paginaSeleccionada - 1;
            if (paginaSeleccionada <= totalPaginas && paginaSeleccionada >=0)
            {
                textNumeroPagina.Text = paginaSeleccionada.ToString();
                IniciarOperaciones();
                if (paginaSeleccionada < 1)
                {
                    btnPaginaAnterior.Enabled = false;
                    string mensaje = "Llego al inicio de las paginas";
                    MessageBox.Show(mensaje, "Paginado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPaginaAnterior.Enabled = false;
                    paginaSeleccionada = paginaSeleccionada + 1;
                }
            }
        }

        private void btnSiguientePagina_Click(object sender, EventArgs e)
        {
            paginaSeleccionada = paginaSeleccionada + 1;
            if (paginaSeleccionada <= totalPaginas)
            {
                IniciarOperaciones();
                btnPaginaAnterior.Enabled = true;
                if (paginaSeleccion == totalPaginas)
                {
                    string mensaje = "No hay mas paginas para mostrar";
                    MessageBox.Show(mensaje, "Paginado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSiguientePagina.Enabled = false;
                    paginaSeleccionada = paginaSeleccionada - 1;
                }
            }
        }
        private void MostrarAviso()
        {
            labelAdvertencia.Visible = true;
        }
        private void BuscarPorReferencia()
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            string referencia = textSearch.Text;
            respuesta = productoService.BuscarPorReferencia(referencia);
            dataGridFarmacos.DataSource = null;
            if (respuesta.Producto != null)
            {
                dataGridFarmacos.DataSource = respuesta.Producto;
            }
            else
            {
                if (respuesta.Producto == null)
                {
                    labelAdvertencia.Enabled = true;
                    labelAdvertencia.Text = "No hay medicametos de este tipo";
                    textSearch.Text = "";
                    string msg = "¡No se encontró medicamentos asociados!";
                    MessageBox.Show(msg, "Filtro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IniciarOperaciones();
                }
            }
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
        private void BuscarPorUbicacion()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string ubicacion = comboUbicacion.Text;
            respuesta = productoService.BuscarPorUbicacion(ubicacion);
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
            cantidadDeRegistros = int.Parse(textTotal.Text);
            totalPaginas = 0;
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            textSearch.Visible = false;
            textSearch.Text = "Buscar medicamento";
            btnClose.Visible = false;
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }
        private void dataGridFarmacos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string referencia;
            if (dataGridFarmacos.DataSource != null)
            {
                if (dataGridFarmacos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    referencia = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["Referencia"].Value.ToString());
                    string nombre = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["Nombre"].Value.ToString());
                    var respuesta = MessageBox.Show("Desea eliminar el producto " + nombre + "?", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        EliminarProducto(referencia);
                        ConsultarYLlenarGridDeProductos(paginaSeleccionada);
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
        private void GestionVender()
        {
            TotalSeleccion = dataGridFarmacos.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Column1"].Value)).Count();
            if (cantidadDrogueria == 1)
            {
                if (cantidadEstante > 0)
                {
                    if (cajaAbierta == true)
                    {
                        if (TotalSeleccion >= 0)
                        {
                            //Obtener referencias de productos
                            foreach (DataGridViewRow row in dataGridFarmacos.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells["Column1"].Value))
                                {
                                    ReferenciasProductosAVender[i] = Convert.ToString(row.Cells["Referencia"].Value);
                                    CantidadesProductosAVender[i] = Convert.ToInt32(row.Cells["CantidadVenta"].Value);
                                    i = i + 1;
                                }
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
                    else
                    {
                        string mensaje = "No hay caja abierta, asi que no se puede cargar productos a la factura";
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string mensaje = "No hay ubicaciones registradas por lo que tampoco hay productos registrados";
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string mensaje = "No se ha registrado datos de drogueria, asi que no se puede generar factura";
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            MapearMedicamentosFactura();
            FormFacturaDeProducto frm = new FormFacturaDeProducto();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
            VaciarArreglos();
        }
        private void VaciarArreglos()
        {
            for(int i = 0; i < 100; i++)
            {
                ReferenciasProductosAVender[i] = "";
                CantidadesProductosAVender[i] = 0;
            }
        }
        private void ObtenerRutaDeGuardado()
        {
            RutasTxtConsultaResponse rutasTxtConsultaResponse = rutasTxtService.Consultar();
            if (rutasTxtConsultaResponse.RutasTxts.Count > 0)
            {
                foreach (var item in rutasTxtConsultaResponse.RutasTxts)
                {
                    rutasVendidos = item.RutaFacturasVenta;
                }
            }
        }
        private void MapearMedicamentosFactura()
        {
            ObtenerRutaDeGuardado();
            string referenciaARrecorrer;
            int cantidadARecorrer;
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            for (int i = 0; i <= 100; i++)
            {
                referenciaARrecorrer = ReferenciasProductosAVender[i];
                cantidadARecorrer = CantidadesProductosAVender[i];
                bool exixtencia = productoTxtService.FiltroReferencia(referenciaARrecorrer);
                if (exixtencia == false)
                {
                    cantidad = cantidadARecorrer;
                    if (referenciaARrecorrer != null && cantidadARecorrer != 0)
                    {
                        respuesta = productoService.BuscarPorReferencia(referenciaARrecorrer);
                        if (cantidadARecorrer <= respuesta.Producto.Cantidad)
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
                            if (cantidad > respuesta.Producto.Cantidad)
                            {
                                string mensaje = "La cantidad de " + respuesta.Producto.Nombre + " en inventario no es suficiente vuelva a ingresarlo";
                                MessageBox.Show(mensaje, "Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (referenciaARrecorrer == null || cantidadARecorrer == 0)
                        {
                            break;
                        }
                    }
                }
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
        }
        private void EliminarProducto(string referencia)
        {
            string mensaje = productoService.Eliminar(referencia);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Eliminar.Visible = false;
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (cantidadEstante!=0 || cantidadVitrinas!=0 || cantidadNeveras!=0)
            {
                FormRegistrarProducto frm = new FormRegistrarProducto();
                frm.ShowDialog();
                cantidadDeRegistros = 20;
                paginaSeleccionada = 0;
                ConsultarYLlenarGridDeProductos(paginaSeleccionada);
            }
            else
            {
                if (cantidadEstante == 0)
                {
                    string mensaje = "No se han registrado datos de estante por lo que no podra registrar productos";
                    MessageBox.Show(mensaje, "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            FormProductosVendidos frm = new FormProductosVendidos();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }
        private void btnFarmacosVencidos_Click(object sender, EventArgs e)
        {
            FormProductosVencidos frm = new FormProductosVencidos();
            frm.ShowDialog();
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
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
        }
        private void comboFiltroVia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string via = comboFiltroVia.Text;
            if (via != "Todos")
            {
                ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
                respuesta = productoService.BuscarPorViaAdminitracion(via);
                productos = respuesta.Productos.ToList();
                dataGridFarmacos.DataSource = null;
                if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
                {
                    dataGridFarmacos.DataSource = respuesta.Productos;
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
            else
            {
                if (via == "Todos")
                {
                    ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                }
            }
        }
        private void comboFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tipo = comboFiltroTipo.Text;
            if (Tipo != "Todos")
            {
                ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
                respuesta = productoService.BuscarPorTipo(Tipo);
                productos = respuesta.Productos.ToList();
                dataGridFarmacos.DataSource = null;
                if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
                {
                    dataGridFarmacos.DataSource = respuesta.Productos;
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
            else
            {
                if (Tipo == "Todos")
                {
                    ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                }
            }
        }
        private void textSearch_Enter(object sender, EventArgs e)
        {
            if(textSearch.Text=="Buscar medicamento")
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
                        if (i >= 6)
                        {
                            if ((celda.Value.ToString().ToUpper()).IndexOf(textSearch.Text.ToUpper()) == 0)
                            {
                                fila.Visible = true;
                                break;
                            }
                            else
                            {
                                if ((celda.Value.ToString()==(textSearch.Text.ToUpper())))
                                {
                                    fila.Visible = true;
                                    break;
                                }
                            }
                        }
                        i = i + 1;
                    }
                }
            }
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarPorReferencia();
            }
        }

        private void textNumeroPagina_TextChanged(object sender, EventArgs e)
        {
            if (textNumeroPagina.Text !="")
            {
                paginaSeleccionada = int.Parse(textNumeroPagina.Text);
                ConsultarYLlenarGridDeProductos(paginaSeleccionada);
            }
        }

        private void comboUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ubicacion = comboUbicacion.Text;
            if (ubicacion != "Todos")
            {
                ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
                respuesta = productoService.BuscarPorUbicacion(ubicacion);
                productos = respuesta.Productos.ToList();
                dataGridFarmacos.DataSource = null;
                if (respuesta.Productos.Count != 0 && respuesta.Productos != null)
                {
                    dataGridFarmacos.DataSource = respuesta.Productos;
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
            else
            {
                if (ubicacion == "Todos")
                {
                    ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                }
            }
        }

        private void dataGridFarmacos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridFarmacos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock menor a 20
                        if (Convert.ToInt32(e.Value) >= 20)
                        {
                            e.CellStyle.BackColor = Color.DarkGreen;
                            e.CellStyle.ForeColor = Color.White;
                        }
                        //Stock menor a 20
                        if (Convert.ToInt32(e.Value) <= 20)
                        {
                            e.CellStyle.BackColor = Color.LightSalmon;
                            e.CellStyle.ForeColor = Color.Red;
                        }
                        //Stock menor a 10
                        if (Convert.ToInt32(e.Value) <= 10)
                        {
                            e.CellStyle.BackColor = Color.Salmon;
                            e.CellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                if (this.dataGridFarmacos.Columns[e.ColumnIndex].Name == "PrecioDeVenta")
                {
                    if (e.Value != null)
                    {
                        if (e.Value.GetType() != typeof(System.DBNull))
                        {
                            //Toda la columna
                            if (Convert.ToInt32(e.Value) !=0)
                            {
                                e.CellStyle.BackColor = Color.Yellow;
                                e.CellStyle.ForeColor = Color.Black;
                            }
                            //Resaltar casillas en 0
                            if (Convert.ToInt32(e.Value) ==0)
                            {
                                e.CellStyle.BackColor = Color.Salmon;
                                e.CellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
            if (this.dataGridFarmacos.Columns[e.ColumnIndex].Name == "Ubicacion")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Toda la columna
                        if (Convert.ToString(e.Value) !="A")
                        {
                            e.CellStyle.BackColor = Color.Purple;
                            e.CellStyle.ForeColor = Color.White;
                        }
                        
                    }
                }
            }
            if (this.dataGridFarmacos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value!=null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock vencidos
                        if (Convert.ToString(e.Value) =="Vencido")
                        {
                            e.CellStyle.BackColor = Color.DarkRed;
                            e.CellStyle.ForeColor = Color.White;
                        }

                    }
                }
            }
            if (this.dataGridFarmacos.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        //Stock vencidos
                        if (Convert.ToString(e.Value) == "Cuarentena")
                        {
                            e.CellStyle.BackColor = Color.BlueViolet;
                            e.CellStyle.ForeColor = Color.White;
                        }

                    }
                }
            }
        }

        private void dataGridFarmacos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre;
            if (dataGridFarmacos.DataSource != null)
            {
                if (dataGridFarmacos.Columns[e.ColumnIndex].Name == "Cash")
                {
                    referenciaBotonDatagrid = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["Referencia"].Value.ToString());
                    nombre = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["Nombre"].Value.ToString());
                    var respuesta = MessageBox.Show("Desea vender el producto "+nombre+"?", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        TotalSeleccion = 1;
                        CantidadesProductosAVender[0] = 1;
                        ReferenciasProductosAVender[0] = referenciaBotonDatagrid;
                        MapearMedicamentosFactura();
                        btnVenderProducto_Click(sender, e);
                        ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                    }
                }
                else
                {
                    if (dataGridFarmacos.Columns[e.ColumnIndex].Name == "Vencido")
                    {
                        BusquedaProductoRespuesta busqueda = new BusquedaProductoRespuesta();
                        referenciaBotonDatagrid = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["Referencia"].Value.ToString());
                        nombre = Convert.ToString(dataGridFarmacos.CurrentRow.Cells["Nombre"].Value.ToString());
                        var respuesta = MessageBox.Show("Desea Sacar este producto de inventario " + nombre + "?", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            busqueda = productoService.BuscarPorReferencia(referenciaBotonDatagrid);
                            if (busqueda.Producto != null)
                            {
                                string estado = busqueda.Producto.Estado;
                                if (estado == "Vencido")
                                {
                                    referenciaProducto = busqueda.Producto.Referencia;
                                    cantidadProducto = busqueda.Producto.Cantidad;
                                    nombreProducto = busqueda.Producto.Nombre;
                                    detalleProducto = busqueda.Producto.Detalle;
                                    fechaDeRegistro = busqueda.Producto.FechaDeRegistro;
                                    fechaDeVencimiento = busqueda.Producto.FechaDeVencimiento;
                                    loteProducto = busqueda.Producto.Lote;
                                    laboratorioProducto = busqueda.Producto.Laboratorio;
                                    estadoProducto = busqueda.Producto.Estado;
                                    tipoProducto = busqueda.Producto.Tipo;
                                    viaProducto = busqueda.Producto.Via;
                                    porcentajeDeVenta = busqueda.Producto.PorcentajeDeVenta;
                                    precioDeNegocio = busqueda.Producto.PrecioDeNegocio;
                                    precioProducto = busqueda.Producto.PrecioDeVenta;
                                    gananciaDeProducto = busqueda.Producto.GananciaPorProducto;
                                    ProductoVencidoTxt productoTxt = new ProductoVencidoTxt(
                                        cantidadProducto, referenciaProducto, nombreProducto, detalleProducto, fechaDeRegistro,
                                        fechaDeVencimiento, loteProducto, laboratorioProducto, estadoProducto, tipoProducto, viaProducto,
                                        porcentajeDeVenta, precioDeNegocio, precioProducto, gananciaDeProducto);
                                    productoVencidoTxtService.Guardar(productoTxt);
                                    productoService.Eliminar(referenciaProducto);
                                }
                                else
                                {
                                    if (estado != "Vencido")
                                    {
                                        string msg = "Solo se pueden sacar del inventario productos vencidos";
                                        MessageBox.Show(msg, "Vencidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
                        }
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            paginaSeleccionada = 0;
            cantidadDeRegistros = 20;
            CalculoDeEstadoAutomatico();
            ConsultarYLlenarGridDeProductos(paginaSeleccionada);
        }

        private void dataGridFarmacos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int valor = Convert.ToInt32(dataGridFarmacos.CurrentRow.Cells["CantidadVenta"].Value);
            if (valor!=0)
            {
                if (dataGridFarmacos.Columns[e.ColumnIndex].Name == "CantidadVenta")
                {
                    GestionVender();
                }
            }
        }
    }
}

