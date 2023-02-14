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
    public partial class FormGestionarVitrina : Form
    {
        VitrinaService vitrinaService;
        List<Vitrina> vitrinas;
        string estado;
        public FormGestionarVitrina()
        {
            vitrinaService = new VitrinaService(ConfigConnection.ConnectionString);
            InitializeComponent();
        }
        private void ConsultarVitrinas()
        {
            if (comboEstado.Text == "Todos")
            {
                ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
                respuesta = vitrinaService.ConsultarTodos();
                vitrinas = respuesta.Vitrinas.ToList();
                if (respuesta.Vitrinas.Count != 0 && respuesta.Vitrinas != null)
                {
                    dataGridVitrinas.DataSource = respuesta.Vitrinas;
                    textTotalVitrinas.Text = vitrinaService.Totalizar().Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.Vitrinas == null || respuesta.Vitrinas.Count == 0)
                    {
                        labelAdvertencia.Visible = true;
                        dataGridVitrinas.DataSource = null;
                    }
                }
            }
        }
        private void BuscarPorEstados()
        {
            ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
            string estado = comboEstado.Text;
            respuesta = vitrinaService.ConsultaPorEstado(estado);
            vitrinas = respuesta.Vitrinas.ToList();
            if (respuesta.Vitrinas.Count != 0 && respuesta.Vitrinas != null)
            {
                dataGridVitrinas.DataSource = vitrinas;
                textTotalVitrinas.Text = vitrinaService.Totalizar().Cuenta.ToString();
                labelAdvertencia.Visible = false;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EliminarVacios()
        {
            string estado = "Vacio";
            vitrinaService.EliminarVitrinas(estado);
        }
        private void EliminarLlenos()
        {
            string estado = "Lleno";
            vitrinaService.EliminarVitrinas(estado);
        }
        private void EliminarCasiLlenos()
        {
            string estado = "Casi Lleno";
            vitrinaService.EliminarVitrinas(estado);
        }
        private void EliminarMedioLlenos()
        {
            string estado = "Medio Lleno";
            vitrinaService.EliminarVitrinas(estado);
        }
        private void EliminarMedioVacios()
        {
            string estado = "Medio Vacio";
            vitrinaService.EliminarVitrinas(estado);
        }
        private void btnRegistrarVitrinas_Click(object sender, EventArgs e)
        {
            FormRegistrarVitrina frm = new FormRegistrarVitrina();
            frm.ShowDialog();
            ConsultarVitrinas();
        }

        private void btnEliminarVitrinas_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de vitrinas registrados?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                EliminarVacios();
                EliminarLlenos();
                EliminarCasiLlenos();
                EliminarMedioLlenos();
                EliminarMedioVacios();
                string mensaje = "Se han eliminado los vitrinas correctamente";
                MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ConsultarVitrinas();
        }

        private void textSearchVitrina_TextChanged(object sender, EventArgs e)
        {
            if (textSearchVitrina.Text != "Buscar numero" && textSearchVitrina.Text != "")
            {
                ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
                string ubicacion = textSearchVitrina.Text;
                respuesta = vitrinaService.ConsultaPorNumeroDeVitrina(ubicacion);
                vitrinas = respuesta.Vitrinas.ToList();
                if (respuesta.Vitrinas.Count != 0 && respuesta.Vitrinas != null)
                {
                    dataGridVitrinas.DataSource = vitrinas;
                    textTotalVitrinas.Text = vitrinaService.Totalizar().Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
            }
        }

        private void textSearchVitrina_Enter(object sender, EventArgs e)
        {
            if (textSearchVitrina.Text == "Buscar nombre")
            {
                textSearchVitrina.Text = "";
            }
        }

        private void btnSearchVitrina_Click(object sender, EventArgs e)
        {
            textSearchVitrina.Visible = true;
            btnCloseVitrina.Visible = true;
        }

        private void btnCloseVitrina_Click(object sender, EventArgs e)
        {
            textSearchVitrina.Visible = false;
            btnCloseVitrina.Visible = false;
        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from ESTANTE where Estado='" + comboEstado.Text + "'";
            UpdateGrid(query, "CAJA");
            if (comboEstado.Text == "Todos")
            {
                ConsultarVitrinas();
            }
            else
            {
                BuscarPorEstados();
            }
        }
        public void UpdateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.AdminPharmConnectionString));
            DataSet dad = new DataSet();
            ada.Fill(dad, tbl);
            dataGridVitrinas.DataSource = dad;
            dataGridVitrinas.DataMember = tbl;
        }
        private void EliminarVitrina(string Id)
        {
            string mensaje = vitrinaService.Eliminar(Id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridVitrinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id;
            if (dataGridVitrinas.DataSource != null)
            {
                if (dataGridVitrinas.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    Id = Convert.ToString(dataGridVitrinas.CurrentRow.Cells["CodigoDeVitrina"].Value.ToString());
                    string msg = "Desea eliminar este registro " + Id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarVitrina(Id);
                        ConsultarVitrinas();
                    }
                }
            }
            else
            {
                if (dataGridVitrinas.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
