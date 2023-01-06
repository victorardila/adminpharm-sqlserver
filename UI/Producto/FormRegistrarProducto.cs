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

namespace Presentacion
{
    public partial class FormRegistrarProducto : Form
    {
        ProductoService productoService;
        EstanteService estanteService;
        List<Producto> productos;
        List<Estante> estantes;
        Producto producto;
        Estante estante;
        int cantidad;
        string ubicacion;
        string codigo;
        int numeroEstante;
        int cantidadProductoPorEstante;

        public FormRegistrarProducto()
        {
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            estanteService = new EstanteService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarEstantes();
        }
        private Producto MapearProducto()
        {
            producto = new Producto();
            producto.Cantidad = int.Parse(textCantidad.Text);
            producto.Referencia = textReferencia.Text;
            producto.Nombre = textNombreFarmaceutico.Text;
            producto.FechaDeRegistro = dateTimeFechaRegistro.Value;
            producto.FechaDeVencimiento = dateTimeFechaVencimiento.Value;
            producto.Lote = textLote.Text;
            producto.Laboratorio = comboLaboratorio.Text;
            producto.Detalle = textDetalle.Text;
            producto.Via = comboVia.Text;
            producto.Tipo = comboTipo.Text;
            producto.PrecioDeNegocio = int.Parse(textPrecioDeNegocio.Text);
            producto.PorcentajeDeVenta = int.Parse(textPorcentajeDeVenta.Text);
            producto.NumeroDeEstante = int.Parse(comboNumeroEstante.Text);
            numeroEstante = int.Parse(comboNumeroEstante.Text);
            return producto;
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
                    textPrecioDeNegocio.Text = respuesta.Producto.PrecioDeNegocio.ToString();
                    textPorcentajeDeVenta.Text = respuesta.Producto.PorcentajeDeVenta.ToString();
                    textCantidad.Text = respuesta.Producto.Cantidad.ToString();
                    comboNumeroEstante.Text = respuesta.Producto.NumeroDeEstante.ToString();
                    numeroEstante = int.Parse(comboNumeroEstante.Text);
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
                comboNumeroEstante.Items.Add(i);
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
            ubicacion = comboNumeroEstante.Text;
            respuesta = estanteService.BuscarPorNumeroDeEstante(ubicacion);
            if (respuesta.Estante != null)
            {
                codigo = respuesta.Estante.CodigoDeEstante;
                numeroEstante = respuesta.Estante.NumeroDeEstante;
                cantidadProductoPorEstante = respuesta.Estante.CantidadDeProductos;
            }
            else
            {
                if (respuesta.Estante == null)
                {
                    
                }
            }
        }
        private void ConsultarEstantes()
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            string ubicacion = comboNumeroEstante.Text;
            respuesta = estanteService.ConsultarTodos();
            estantes = respuesta.Estantes.ToList();
            if (respuesta.Estantes.Count != 0 && respuesta.Estantes != null)
            {
                cantidad = estanteService.Totalizar().Cuenta;
                LlenarComboEstante(cantidad);
            }
            else
            {
                if (respuesta.Estantes == null || respuesta.Estantes.Count == 0)
                {
                    labelAdvertencia.Text = "No ha registrado ningun estante";
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            textSearch.Visible = false;
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
            var respuesta = MessageBox.Show("Está seguro de Modificar el producto", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Producto producto = MapearProducto();
                string mensaje = productoService.Modificar(producto);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto producto = MapearProducto();
            string mensaje = productoService.Guardar(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(mensaje== "Producto registrado correctamente")
            {
                Estante estante = MapearEstante();
                estanteService.Modificar(estante);
            }
            this.Close();
        }
        private void comboNumeroEstante_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarEstante();
        }
    }
}
