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
using Entity;
using BLL;

namespace Presentacion
{
    public partial class FormGestionFacturas : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        FacturaService facturaService;
        List<Factura> facturas;
        string[] referencias = new string[1000];
        string idCajaLeida;
        public FormGestionFacturas()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            facturaService = new FacturaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarHistorialDeFacturas();
            ConsultarIdCajas();
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
                ConsultarIdCajas();
                int cantidad= facturaService.Totalizar().Cuenta;
                LlenarComboIdCaja(cantidad);
            }
            else
            {
                if (respuesta.Facturas == null || respuesta.Facturas.Count == 0)
                {
                    MostrarAviso();
                    btnEliminarHistorial.Enabled = false;
                    Eliminar.Visible = false;
                }
            }
        }
        private void ConsultarHistorialDeFacturasCombo()
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
                }
            }
        }
        private void MostrarAviso()
        {
            labelAdvertencia.Visible = true;
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
        private void BuscarPorIdFacturas()
        {
            BusquedaFacturaRespuesta respuesta = new BusquedaFacturaRespuesta();
            string idCaja = comboIdCaja.Text;
            respuesta = facturaService.BuscarPorId(idCaja);
            if (respuesta.Factura != null)
            {
                dataGridFacturas.DataSource = null;
                var facturas = new List<Factura> { respuesta.Factura };
                dataGridFacturas.DataSource = facturas;
            }
        }
        private void ConsultarIdCajas()
        {
            foreach (DataGridViewRow fila in dataGridFacturas.Rows)
            {
                int i = 0;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    //Determinamos la cantidad del producto
                    if (i == 6)
                    {
                        referencias[i-6]=Convert.ToString(fila.Cells[i].Value); 
                    }
                    i = i + 1;
                }
            }
        }
        private void LlenarComboIdCaja(int cantidadIdCaja)
        {
            for (int i = 1; i <= cantidadIdCaja; i = i + 1)
            {
                for(int j = 0; j < 1000; j++)
                {
                    string idCaja;
                    idCaja = referencias[j];
                    if (idCajaLeida != idCaja)
                    {
                        if (idCaja != null)
                        {
                            if (j == 0)
                            {
                                comboIdCaja.Items.Add(idCaja);
                                idCajaLeida = idCaja;
                                break;
                            }
                            else
                            {
                                if (j > 0)
                                {
                                    if (idCaja != referencias[j - 1])
                                    {
                                        comboIdCaja.Items.Add(idCaja);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void textSearchFactura_TextChanged(object sender, EventArgs e)
        {
            if (textSearchFactura.Text != "")
            {
                dataGridFacturas.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridFacturas.Rows)
                {
                    fila.Visible = false;
                }
                foreach (DataGridViewRow fila in dataGridFacturas.Rows)
                {
                    int i = 0;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (i > 0)
                        {
                            if ((celda.Value.ToString().ToUpper()).IndexOf(textSearchFactura.Text.ToUpper()) == 0)
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
                ConsultarHistorialDeFacturas();
            }
        }

        private void comboIdCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from FACTURA where Id_Caja='" + comboIdCaja.Text + "'";
            UpdateGrid(query, "FACTURA");
            if (comboIdCaja.Text == "Todos")
            {
                ConsultarHistorialDeFacturasCombo();
            }
            else
            {
                BuscarPorIdFacturas();
            }
        }
        public void UpdateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.AdminPharmConnectionString));
            DataSet dad = new DataSet();
            ada.Fill(dad, tbl);
            dataGridFacturas.DataSource = dad;
            dataGridFacturas.DataMember = tbl;
        }
    }
}
