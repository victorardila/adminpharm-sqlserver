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
    public partial class FormGestionCaja : Form
    {
        CajaRegistradoraService cajaRegistradoraService;
        List<Caja> cajasRegistradoras;
        Caja cajaRegistradora;
        string idCajaAbierta;
        string fechaDeApertura;
        string horaDeApertura;
        double montoCaja;
        public FormGestionCaja()
        {
            cajaRegistradoraService = new CajaRegistradoraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarYLlenarGridDeCajas();
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
        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Caja cajaRegistradora = MapearCaja();
                string mensaje = cajaRegistradoraService.Modificar(cajaRegistradora);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ConsultarYLlenarGridDeCajas();
                btnAbrirCaja.Enabled = true;
                btnCerrarCaja.Enabled = false;
                btnHistorial.Enabled = true;
                labelCash.Text = "Sin definir";
            }
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
    }
}
