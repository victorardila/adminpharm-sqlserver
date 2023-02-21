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
using BLL;
using Entity;
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormRegistrarProducto : Form
    {
        ProductoService productoService;
        EstanteService estanteService;
        VitrinaService vitrinaService;
        NeveraService neveraService;
        List<Producto> productos;
        List<Estante> estantes;
        List<Vitrina> vitrinas;
        List<Nevera> neveras;
        Producto producto;
        Estante estante;
        double precioDeNegocio;
        string cantidadDelContenedor;
        int cantidadSumatoriaTotal;
        int cantidadAlmacenada;
        int cantidadASumar;
        int cantidadEstantes;
        int cantidadVitrinas;
        int cantidadNeveras;
        string ubicacion;
        string codigo;
        string numeroEstante;
        int cantidadProductoPorEstante;

        public FormRegistrarProducto()
        {
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            estanteService = new EstanteService(ConfigConnection.ConnectionString);
            vitrinaService = new VitrinaService(ConfigConnection.ConnectionString);
            neveraService = new NeveraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarLaboratorios();
            ConsultarEstantes();
            ConsultarVitrinas();
            ConsultarNeveras();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Producto MapearProducto()
        {
            producto = new Producto();

            cantidadASumar = int.Parse(textCantidad.Text);
            cantidadSumatoriaTotal = cantidadAlmacenada + cantidadASumar;

            producto.Cantidad = cantidadSumatoriaTotal;
            producto.Referencia = textReferencia.Text;
            producto.Nombre = textNombreFarmaceutico.Text;
            producto.FechaDeRegistro = dateTimeFechaRegistro.Value;
            producto.FechaDeVencimiento = dateTimeFechaVencimiento.Value;
            producto.Lote = textLote.Text;
            producto.Laboratorio = comboLaboratorio.Text;
            producto.Detalle = textDetalle.Text;
            producto.Via = comboVia.Text;
            producto.PrecioDeNegocio = int.Parse(textPrecioNegocio.Text);
            producto.ValorPorUnidad = int.Parse(textPrecioUnidad.Text);
            producto.ValorPorBlister = int.Parse(textPrecioBlister.Text);
            producto.ValorPorPaquete = int.Parse(textPrecioCaja.Text);
            producto.Tipo = comboTipo.Text;
            producto.Ubicacion = comboUbicacion.Text;
            return producto;
        }
        private void BuscarReferencia(string referencia)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            respuesta = productoService.BuscarPorReferencia(referencia);
            if (respuesta.Producto != null)
            {
                for(int i = 2; i < 1000; i++)
                {
                    string newReferencia = respuesta.Producto.Referencia + "-"+i;
                    respuesta = productoService.BuscarPorReferencia(newReferencia);
                    if (respuesta.Producto == null)
                    {
                        textReferencia.Text = newReferencia;
                        Producto producto = MapearProducto();
                        producto.Referencia = newReferencia;
                        productoService.Guardar(producto);
                        break;
                    }
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            textSearch.Visible = true;
            btnClose.Visible = true;
            labelTitle.Text = "Modificar Producto";
            if (textSearch.Text != ""&& textSearch.Text != "Buscar referencia")
            {
                BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
                string referencia = textSearch.Text;
                respuesta = productoService.BuscarPorReferencia(referencia);
                if (respuesta.Producto != null)
                {
                    btnModificar.Enabled = true;
                    btnRegistrar.Enabled = false;
                    labelAdvertencia.Visible = false;
                    var productos = new List<Producto> { respuesta.Producto };
                    textReferencia.Text = respuesta.Producto.Referencia;
                    referencia = respuesta.Producto.Referencia;
                    textNombreFarmaceutico.Text = respuesta.Producto.Nombre;
                    textDetalle.Text = respuesta.Producto.Detalle;
                    dateTimeFechaRegistro.Text = respuesta.Producto.FechaDeRegistro.ToString();
                    dateTimeFechaVencimiento.Text = respuesta.Producto.FechaDeVencimiento.ToString();
                    textLote.Text = respuesta.Producto.Lote;
                    comboLaboratorio.Text = respuesta.Producto.Laboratorio;
                    comboTipo.Text = respuesta.Producto.Tipo;
                    comboVia.Text = respuesta.Producto.Via;
                    textPrecioNegocio.Text = respuesta.Producto.PrecioDeNegocio.ToString();
                    textPrecioUnidad.Text = respuesta.Producto.ValorPorUnidad.ToString();
                    textPrecioBlister.Text = respuesta.Producto.ValorPorBlister.ToString();
                    textPrecioCaja.Text = respuesta.Producto.ValorPorPaquete.ToString();
                    textCantidad.Text = respuesta.Producto.Cantidad.ToString();
                    comboUbicacion.Text = respuesta.Producto.Ubicacion;
                    numeroEstante = comboUbicacion.Text;
                    
                }
                else
                {
                    if (respuesta.Producto == null)
                    {
                        labelAdvertencia.Visible = true;
                        labelAdvertencia.Text = "No existe producto con esta referencia";
                    }
                }
            }
        }
        private void LlenarComboEstante(int cantidad)
        {
            for(int i = 1; i <= cantidad; i = i + 1)
            {
                string vitrina = "Estante " + i;
                comboUbicacion.Items.Add(vitrina);
            }
        }
        private void LlenarComboVitrina(int cantidad)
        {
            for (int i = 1; i <= cantidad; i = i + 1)
            {
                string vitrina = "Vitrina " + i;
                comboUbicacion.Items.Add(vitrina);
            }
        }
        private void LlenarComboNevera(int cantidad)
        {
            for (int i = 1; i <= cantidad; i = i + 1)
            {
                string nevera = "Nevera " + i;
                comboUbicacion.Items.Add(nevera);
            }
        }
        private Estante MapearEstante()
        {
            estante = new Estante();
            estante.CodigoDeEstante = codigo;
            estante.NumeroDeEstante = numeroEstante;
            estante.CantidadDeProductos = cantidadProductoPorEstante + 1;
            return estante;
        }
        private void BuscarEstante()
        {
            BusquedaEstanteRespuesta respuesta = new BusquedaEstanteRespuesta();
            ubicacion = comboUbicacion.Text;
            respuesta = estanteService.BuscarPorNumeroDeEstante(ubicacion);
            if (respuesta.Estante != null)
            {
                codigo = respuesta.Estante.CodigoDeEstante;
                numeroEstante = respuesta.Estante.NumeroDeEstante;
                cantidadProductoPorEstante = respuesta.Estante.CantidadDeProductos;
            }
        }
        private void BuscarVitrina()
        {
            BusquedaEstanteRespuesta respuesta = new BusquedaEstanteRespuesta();
            ubicacion = comboUbicacion.Text;
            respuesta = estanteService.BuscarPorNumeroDeEstante(ubicacion);
            if (respuesta.Estante != null)
            {
                codigo = respuesta.Estante.CodigoDeEstante;
                numeroEstante = respuesta.Estante.NumeroDeEstante;
                cantidadProductoPorEstante = respuesta.Estante.CantidadDeProductos;
            }
        }
        private void BuscarNevera()
        {
            BusquedaEstanteRespuesta respuesta = new BusquedaEstanteRespuesta();
            ubicacion = comboUbicacion.Text;
            respuesta = estanteService.BuscarPorNumeroDeEstante(ubicacion);
            if (respuesta.Estante != null)
            {
                codigo = respuesta.Estante.CodigoDeEstante;
                numeroEstante = respuesta.Estante.NumeroDeEstante;
                cantidadProductoPorEstante = respuesta.Estante.CantidadDeProductos;
            }
        }
        private void ConsultarEstantes()
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            respuesta = estanteService.ConsultarTodos();
            estantes = respuesta.Estantes.ToList();
            if (respuesta.Estantes.Count != 0 && respuesta.Estantes != null)
            {
                cantidadEstantes = estanteService.Totalizar().Cuenta;
                labelNumeroEstantes.Text = cantidadEstantes.ToString();
                btnRegistrar.Enabled = true;
            }
            else
            {
                if (respuesta.Estantes == null || respuesta.Estantes.Count == 0)
                {
                    labelAdvertencia.Text = "No ha registrado ningun estante";
                    labelAdvertencia.Visible = true;
                    if (cantidadEstantes == 0)
                    {
                        cantidadEstantes = estanteService.Totalizar().Cuenta;
                        labelNumeroEstantes.Text = cantidadEstantes.ToString();
                        checkedEstante.Enabled = false;
                    }
                }
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
                labelNumeroVitrinas.Text = cantidadVitrinas.ToString();
                btnRegistrar.Enabled = true;
            }
            else
            {
                if (respuesta.Vitrinas == null || respuesta.Vitrinas.Count == 0)
                {
                    labelAdvertencia.Text = "No ha registrado ningun vitrina";
                    labelAdvertencia.Visible = true;
                    if (cantidadVitrinas == 0)
                    {
                        cantidadVitrinas = vitrinaService.Totalizar().Cuenta;
                        labelNumeroVitrinas.Text = cantidadVitrinas.ToString();
                        checkedVitrina.Enabled = false;
                    }
                }
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
                labelNumeroNeveras.Text = cantidadNeveras.ToString();
                LlenarComboNevera(cantidadNeveras);
                btnRegistrar.Enabled = true;
            }
            else
            {
                if (respuesta.Neveras == null || respuesta.Neveras.Count == 0)
                {
                    labelAdvertencia.Text = "No ha registrado ningun nevera";
                    labelAdvertencia.Visible = true;
                    if (cantidadNeveras == 0)
                    {
                        cantidadNeveras = neveraService.Totalizar().Cuenta;
                        labelNumeroNeveras.Text = cantidadNeveras.ToString();
                        checkedNevera.Enabled = false;
                    }
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            textSearch.Visible = false;
            textSearch.Text = "Buscar referencia";
            btnRegistrar.Enabled = true;
            btnClose.Visible = false;
            labelTitle.Text = "Registrar Producto";
            labelAdvertencia.Visible = false;
        }
        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == "Buscar referencia")
            {
                textSearch.Text = "";
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cantidadEstantes > 0)
            {
                var respuesta = MessageBox.Show("Está seguro de Modificar el producto", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Producto producto = MapearProducto();
                    string mensaje = productoService.Modificar(producto);
                    MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string referencia = textReferencia.Text;
            if (cantidadEstantes > 0)
            {
                if (comboUbicacion.Text != "0")
                {
                    BuscarReferencia(referencia);
                    string mensaje = "Producto registrado correctamente";
                    MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (mensaje == "Producto registrado correctamente")
                    {
                        Estante estante = MapearEstante();
                        estanteService.Modificar(estante);
                        string msg = "¡Se agrego el producto correctamente!";
                        MessageBox.Show(msg, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    string mensaje = "No se han cargado datos de la ubicacion del producto";
                    MessageBox.Show(mensaje, "Mensaje de de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private void comboNumeroEstante_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarEstante();
        }

        private void menuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegistroDeProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ConsultarLaboratorios()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            string estado = "Vigente";
            respuesta = productoService.BuscarPorEstado(estado);
            int cantidadLaboratorio = respuesta.Productos.Count;
            if (respuesta.Productos != null && respuesta.Productos.Count != 0)
            {
                for(int i=0; i < 100; i++)
                {
                    for(int j = 0; j < 100; j++)
                    {
                        if(respuesta.Productos[j].Laboratorio!="Sin definir")
                        {
                            if (respuesta.Productos[i] != respuesta.Productos[j])
                            {
                                Producto producto = respuesta.Productos[j];
                                comboLaboratorio.AutoCompleteCustomSource.Add(producto.Laboratorio);
                                comboLaboratorio.Items.Add(producto.Laboratorio);
                            }
                        }
                    }
                }
            }
        }
        private void BuscarReferenciaEscaneada()
        {
            string referencia = textReferencia.Text;
            var respuesta = productoService.BuscarPorReferencia(referencia);
            if (respuesta.Producto != null)
            {
                labelAdvertencia.Text = "Producto existente se sumará a: " + respuesta.Producto.Nombre;
                cantidadAlmacenada = respuesta.Producto.Cantidad;
                textReferencia.ForeColor = Color.Maroon;

                textNombreFarmaceutico.Text = respuesta.Producto.Nombre;
                textDetalle.Text = respuesta.Producto.Detalle;
                dateTimeFechaRegistro.Value = respuesta.Producto.FechaDeRegistro;
                textLote.Text = respuesta.Producto.Lote;
                dateTimeFechaVencimiento.Value = respuesta.Producto.FechaDeVencimiento;
                comboLaboratorio.Text = respuesta.Producto.Laboratorio;
                comboTipo.Text = respuesta.Producto.Tipo;
                comboVia.Text = respuesta.Producto.Via;
                textPrecioNegocio.Text = respuesta.Producto.PrecioDeNegocio.ToString();
                textPrecioUnidad.Text = respuesta.Producto.ValorPorUnidad.ToString();
                textPrecioBlister.Text = respuesta.Producto.ValorPorBlister.ToString();
                textPrecioCaja.Text = respuesta.Producto.ValorPorPaquete.ToString();
                comboUbicacion.Text = respuesta.Producto.Ubicacion.ToString();
            }
            else
            {
                if (respuesta.Producto == null)
                {

                }
            }
        }
        private void textReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarReferenciaEscaneada();
            }
        }

        private void textCantidad_Enter(object sender, EventArgs e)
        {
            if (textCantidad.Text == "0")
            {
                textCantidad.Text = "";
            }
        }

        private void textCantidad_Leave(object sender, EventArgs e)
        {
            if (textCantidad.Text == "")
            {
                textCantidad.Text = "0";
            }
        }

        private void textPrecioCaja_Enter(object sender, EventArgs e)
        {
            if (textPrecioCaja.Text == "0")
            {
                textPrecioCaja.Text = "";
            }
        }

        private void textPrecioCaja_Leave(object sender, EventArgs e)
        {
            if (textPrecioCaja.Text == "")
            {
                textPrecioCaja.Text = "0";
            }
        }

        private void textPrecioBlister_Enter(object sender, EventArgs e)
        {
            if (textPrecioBlister.Text == "0")
            {
                textPrecioBlister.Text = "";
            }
        }

        private void textPrecioBlister_Leave(object sender, EventArgs e)
        {
            if (textPrecioBlister.Text == "")
            {
                textPrecioBlister.Text = "0";
            }
        }

        private void textPrecioUnidad_Enter(object sender, EventArgs e)
        {
            if (textPrecioUnidad.Text == "0")
            {
                textPrecioUnidad.Text = "";
            }
        }

        private void textPrecioUnidad_Leave(object sender, EventArgs e)
        {
            if (textPrecioUnidad.Text == "")
            {
                textPrecioUnidad.Text = "0";
            }
        }

        private void textPrecioNegocio_Enter(object sender, EventArgs e)
        {
            if (textPrecioNegocio.Text == "0")
            {
                textPrecioNegocio.Text = "";
            }
        }

        private void textPrecioNegocio_Leave(object sender, EventArgs e)
        {
            if (textPrecioNegocio.Text == "")
            {
                textPrecioNegocio.Text = "0";
            }
        }

        private void checkedEstante_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedVitrina.Focus();
            if (checkedEstante.CheckedItems.Count != 0)
            {
                checkedVitrina.Enabled = false;
                checkedNevera.Enabled = false;
                string s = "";
                for (int x = 0; x < checkedEstante.CheckedItems.Count; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedEstante.CheckedItems[x].ToString() + "\n";
                }
                comboUbicacion.Text = "";
                LlenarComboEstante(cantidadEstantes);
            }
            else
            {
                if (checkedEstante.CheckedItems.Count == 0)
                {
                    comboUbicacion.Items.Clear();
                    checkedNevera.Enabled = true;
                    checkedVitrina.Enabled = true;
                }
            }
        }

        private void checkedVitrina_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedVitrina.Focus();
            if (checkedVitrina.CheckedItems.Count != 0)
            {
                checkedEstante.Enabled = false;
                checkedNevera.Enabled = false;
                string s = "";
                for (int x = 0; x < checkedEstante.CheckedItems.Count; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedEstante.CheckedItems[x].ToString() + "\n";
                }
                comboUbicacion.Text = "";
                LlenarComboVitrina(cantidadVitrinas);
            }
            else
            {
                if (checkedVitrina.CheckedItems.Count == 0)
                {
                    comboUbicacion.Items.Clear();
                    checkedNevera.Enabled = true;
                    checkedEstante.Enabled = true;
                }
            }
        }

        private void checkedNevera_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedVitrina.Focus();
            if (checkedNevera.CheckedItems.Count != 0)
            {
                checkedEstante.Enabled = false;
                checkedVitrina.Enabled = false;
                string s = "";
                for (int x = 0; x < checkedEstante.CheckedItems.Count; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedEstante.CheckedItems[x].ToString() + "\n";
                }
                comboUbicacion.Text = "";
                LlenarComboNevera(cantidadNeveras);
            }
            else
            {
                if (checkedNevera.CheckedItems.Count == 0)
                {
                    comboUbicacion.Items.Clear();
                    checkedVitrina.Enabled = true;
                    checkedEstante.Enabled = true;
                }
            }
        }
    }
}
