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
    public partial class FormGestionarNevera : Form
    {
        NeveraService neveraService;
        List<Nevera> neveras;
        string estado;
        public FormGestionarNevera()
        {
            neveraService = new NeveraService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarNeveras();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarNeveras_Click(object sender, EventArgs e)
        {
            FormRegistrarNevera frm = new FormRegistrarNevera();
            frm.ShowDialog();
            ConsultarNeveras();
        }

        private void btnEliminarNeveras_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro de eliminar el historial de Neveras registradas?", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            ConsultarNeveras();
        }
        private void ConsultarNeveras()
        {
            if (comboEstado.Text == "Todos")
            {
                ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
                respuesta = neveraService.ConsultarTodos();
                neveras = respuesta.Neveras.ToList();
                if (respuesta.Neveras.Count != 0 && respuesta.Neveras != null)
                {
                    dataGridNeveras.DataSource = respuesta.Neveras;
                    textTotalNeveras.Text = neveraService.Totalizar().Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.Neveras == null || respuesta.Neveras.Count == 0)
                    {
                        labelAdvertencia.Visible = true;
                        dataGridNeveras.DataSource = null;
                    }
                }
            }
        }
        private void BuscarPorEstados()
        {
            ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
            string estado = comboEstado.Text;
            respuesta = neveraService.ConsultaPorEstado(estado);
            neveras = respuesta.Neveras.ToList();
            if (respuesta.Neveras.Count != 0 && respuesta.Neveras != null)
            {
                dataGridNeveras.DataSource = neveras;
                textTotalNeveras.Text = neveraService.Totalizar().Cuenta.ToString();
                labelAdvertencia.Visible = false;
            }
        }
        private void EliminarCaja(string Id)
        {
            string mensaje = neveraService.Eliminar(Id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridNeveras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id;
            if (dataGridNeveras.DataSource != null)
            {
                if (dataGridNeveras.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    Id = Convert.ToString(dataGridNeveras.CurrentRow.Cells["CodigoDeNevera"].Value.ToString());
                    string msg = "Desea eliminar este registro " + Id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarCaja(Id);
                        ConsultarNeveras();
                    }
                }
            }
            else
            {
                if (dataGridNeveras.DataSource == null)
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
            dataGridNeveras.DataSource = dad;
            dataGridNeveras.DataMember = tbl;
        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from NEVERA where Estado='" + comboEstado.Text + "'";
            UpdateGrid(query, "CAJA");
            if (comboEstado.Text == "Todos")
            {
                ConsultarNeveras();
            }
            else
            {
                BuscarPorEstados();
            }
        }

        private void btnSearchNevera_Click(object sender, EventArgs e)
        {
            textSearchNevera.Visible = true;
            btnCloseNevera.Visible = true;
        }

        private void btnCloseNevera_Click(object sender, EventArgs e)
        {
            textSearchNevera.Visible = false;
            btnCloseNevera.Visible = false;
        }

        private void textSearchNevera_Enter(object sender, EventArgs e)
        {
            if (textSearchNevera.Text == "Buscar nombre")
            {
                textSearchNevera.Text = "";
            }
        }

        private void textSearchNevera_TextChanged(object sender, EventArgs e)
        {
            if (textSearchNevera.Text != "Buscar numero" && textSearchNevera.Text != "")
            {
                ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
                string ubicacion = textSearchNevera.Text;
                respuesta = neveraService.ConsultaPorNumeroDeNevera(ubicacion);
                neveras = respuesta.Neveras.ToList();
                if (respuesta.Neveras.Count != 0 && respuesta.Neveras != null)
                {
                    dataGridNeveras.DataSource = neveras;
                    textTotalNeveras.Text = neveraService.Totalizar().Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
            }
        }
        private void EliminarVacios()
        {
            string estado = "Vacio";
            neveraService.EliminarNeveras(estado);
        }
        private void EliminarLlenos()
        {
            string estado = "Lleno";
            neveraService.EliminarNeveras(estado);
        }
        private void EliminarCasiLlenos()
        {
            string estado = "Casi Lleno";
            neveraService.EliminarNeveras(estado);
        }
        private void EliminarMedioLlenos()
        {
            string estado = "Medio Lleno";
            neveraService.EliminarNeveras(estado);
        }
        private void EliminarMedioVacios()
        {
            string estado = "Medio Vacio";
            neveraService.EliminarNeveras(estado);
        }
    }
}
