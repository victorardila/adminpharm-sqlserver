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
    public partial class FormGestionDeEstantes : Form
    {
        EstanteService estanteService;
        List<Estante> estantes;
        string estado;
        public FormGestionDeEstantes()
        {
            estanteService = new EstanteService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarEstantes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegistrarEstantes_Click(object sender, EventArgs e)
        {
            FormRegistrarEstante frm = new FormRegistrarEstante();
            frm.ShowDialog();
            ConsultarEstantes();
        }
        private void ConsultarEstantes()
        {
            if (comboEstado.Text == "Todos")
            {
                ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
                respuesta = estanteService.ConsultarTodos();
                estantes = respuesta.Estantes.ToList();
                if (respuesta.Estantes.Count != 0 && respuesta.Estantes != null)
                {
                    dataGridEstantes.DataSource = respuesta.Estantes;
                    textTotalEstantes.Text = estanteService.Totalizar().Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.Estantes == null || respuesta.Estantes.Count == 0)
                    {
                        labelAdvertencia.Visible = true;
                        dataGridEstantes.DataSource = null;
                    }
                }
            }
        }
        private void BuscarPorEstados()
        {
            ConsultaEstanteRespuesta respuesta= new ConsultaEstanteRespuesta();
            string estado = comboEstado.Text;
            respuesta = estanteService.ConsultaPorEstado(estado);
            estantes = respuesta.Estantes.ToList();
            if (respuesta.Estantes.Count != 0 && respuesta.Estantes != null)
            {
                dataGridEstantes.DataSource = estantes;
                textTotalEstantes.Text = estanteService.Totalizar().Cuenta.ToString();
                labelAdvertencia.Visible = false;
            }
        }
        private void EliminarCaja(string Id)
        {
            string mensaje = estanteService.Eliminar(Id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridEstantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id;
            if (dataGridEstantes.DataSource != null)
            {
                if (dataGridEstantes.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    Id = Convert.ToString(dataGridEstantes.CurrentRow.Cells["CodigoDeEstante"].Value.ToString());
                    string msg = "Desea eliminar este registro " + Id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarCaja(Id);
                        ConsultarEstantes();
                    }
                }
            }
            else
            {
                if (dataGridEstantes.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void UpdateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.AdminPharmConnectionString));
            DataSet dad = new DataSet();
            ada.Fill(dad, tbl);
            dataGridEstantes.DataSource = dad;
            dataGridEstantes.DataMember = tbl;
        }
        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from ESTANTE where Estado='" + comboEstado.Text + "'";
            UpdateGrid(query, "CAJA");
            if (comboEstado.Text == "Todos")
            {
                ConsultarEstantes();
            }
            else
            {
                BuscarPorEstados();
            }
        }

        private void btnSearchCliente_Click(object sender, EventArgs e)
        {
            textSearchEstante.Visible = true;
            btnCloseEstante.Visible = true;
        }

        private void btnCloseCliente_Click(object sender, EventArgs e)
        {
            textSearchEstante.Visible = false;
            btnCloseEstante.Visible = false;
        }

        private void textSearchCliente_Enter(object sender, EventArgs e)
        {
            if (textSearchEstante.Text == "Buscar nombre")
            {
                textSearchEstante.Text = "";
            }
        }

        private void textSearchEstante_TextChanged(object sender, EventArgs e)
        {
            if(textSearchEstante.Text!= "Buscar numero" && textSearchEstante.Text != "")
            {
                ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
                string ubicacion = textSearchEstante.Text;
                respuesta = estanteService.ConsultaPorNumeroDeEstante(ubicacion);
                estantes = respuesta.Estantes.ToList();
                if (respuesta.Estantes.Count != 0 && respuesta.Estantes != null)
                {
                    dataGridEstantes.DataSource = estantes;
                    textTotalEstantes.Text = estanteService.Totalizar().Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
            }
        }
        private void EliminarVacios()
        {
            string estado = "Vacio";
            estanteService.EliminarEstantes(estado);
        }
        private void EliminarLlenos()
        {
            string estado = "Lleno";
            estanteService.EliminarEstantes(estado);
        }
        private void EliminarCasiLlenos()
        {
            string estado = "Casi Lleno";
            estanteService.EliminarEstantes(estado);
        }
        private void EliminarMedioLlenos()
        {
            string estado = "Medio Lleno";
            estanteService.EliminarEstantes(estado);
        }
        private void EliminarMedioVacios()
        {
            string estado = "Medio Vacio";
            estanteService.EliminarEstantes(estado);
        }

        private void btnRegistrarEstantes_Click_1(object sender, EventArgs e)
        {
            FormRegistrarEstante frm = new FormRegistrarEstante();
            frm.ShowDialog();
            ConsultarEstantes();
        }
        private void btnEliminarEstantes_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de estantes registrados?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                EliminarVacios();
                EliminarLlenos();
                EliminarCasiLlenos();
                EliminarMedioLlenos();
                EliminarMedioVacios();
                string mensaje = "Se han eliminado los estantes correctamente";
                MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ConsultarEstantes();
        }
    }
}
