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
        List<Producto> productos;
        Producto producto;
        string referencia;
        public FormRegistrarProducto()
        {
            productoService = new ProductoService(ConfigConnection.ConnectionString);
            InitializeComponent();
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
            return producto;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto producto = MapearProducto();
            string mensaje = productoService.Guardar(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
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
    }
}
