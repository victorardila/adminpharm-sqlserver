using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Presentacion
{
    public partial class FormGestionFacturas : Form
    {
        FacturaService facturaService;
        List<Factura> facturas;
        public FormGestionFacturas()
        {
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarHistorialDeFacturas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultarHistorialDeFacturas()
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            dataGridFacturas.DataSource = null;
            respuesta = facturaService.ConsultarTodos();
            facturas = respuesta.Facturas.ToList();
            if (respuesta.Facturas.Count != 0 && respuesta.Facturas != null)
            {
                dataGridFacturas.DataSource = respuesta.Facturas;
                Eliminar.Visible = true;
                textTotalFacturas.Text = facturaService.Totalizar().Cuenta.ToString();
                textTotalEfectivo.Text = facturaService.TotalizarTipo("Efectivo").Cuenta.ToString();
                textTotalTarjeta.Text = facturaService.TotalizarTipo("Tarjeta").Cuenta.ToString();
                labelAdvertencia.Visible = false;
            }
            else
            {
                if (respuesta.Facturas == null || respuesta.Facturas.Count == 0)
                {
                    MostrarAviso();
                    btnEliminarHistorial.Enabled = false;
                    Eliminar.Visible = false;
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void MostrarAviso()
        {

        }

        private void btnSearchFactura_Click(object sender, EventArgs e)
        {
            btnCloseFactura.Visible = true;
            textSearchFactura.Visible = true;
        }

        private void btnCloseFactura_Click(object sender, EventArgs e)
        {
            btnCloseFactura.Visible = false;
            textSearchFactura.Visible = false;
            textSearchFactura.Text = "Buscar secuencia de factura";
        }

        private void textSearchFactura_Enter(object sender, EventArgs e)
        {
            if(textSearchFactura.Text== "Buscar secuencia de factura")
            {
                textSearchFactura.Text = "";
            }
        }
        private void EliminarPorEfectivo()
        {
            string FormaDePago = "Efectivo";
            facturaService.EliminarHistorial(FormaDePago);
        }
        private void EliminarPorTarjeta()
        {
            string FormaDePago = "Tarjeta";
            facturaService.EliminarHistorial(FormaDePago);
        }
        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de facturas?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                EliminarPorEfectivo();
                EliminarPorTarjeta();
                ConsultarHistorialDeFacturas();
            }
        }
    }
}
