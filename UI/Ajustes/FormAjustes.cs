using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FormAjustes : Form
    {
        DrogueriaService drogueriaService;
        Drogueria drogueria;
        List<Drogueria> droguerias;
        string idDrogueria = "#Drog";
        public FormAjustes()
        {
            drogueriaService = new DrogueriaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            BuscarPorId();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BuscarPorId()
        {
            BusquedaDrogueriaRespuesta respuesta = new BusquedaDrogueriaRespuesta();
            respuesta = drogueriaService.BuscarPorId(idDrogueria);
            if (respuesta.Drogueria != null)
            {
                var droguerias = new List<Drogueria> { respuesta.Drogueria };
                dataGridInfoDrogueria.DataSource = droguerias;
                textNombreDrogueria.Text = respuesta.Drogueria.NombreDrogueria;
                textNIT.Text= respuesta.Drogueria.NIT;
                textCamaraDeComercio.Text = respuesta.Drogueria.CodigoDeCamara;
                textFraseDistintiva.Text= respuesta.Drogueria.FraseDistintiva;
                comboRegimen.Text= respuesta.Drogueria.Regimen;
                textPBX.Text= respuesta.Drogueria.PBX;
                textDireccion.Text = respuesta.Drogueria.Direccion;
                textTelefono.Text= respuesta.Drogueria.Telefono;
                labelAdvertencia.Visible = false;
                btnRegistrarInfo.Enabled = false;
            }
            else
            {
                if (respuesta.Drogueria == null)
                {
                    labelAdvertencia.Visible = true;
                    btnRegistrarInfo.Enabled = true;
                }
            }
        }
        private void Limpiar()
        {
            dataGridInfoDrogueria.DataSource = null;
            textNombreDrogueria.Text = "";
            textNIT.Text = "";
            textFraseDistintiva.Text = "";
            comboRegimen.Text = "";
            textPBX.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
        } 
        private Drogueria MapearDrogueria()
        {
            drogueria = new Drogueria();
            drogueria.IdDrogueria = "#Drog";
            drogueria.NombreDrogueria = textNombreDrogueria.Text;
            drogueria.NIT = textNIT.Text;
            drogueria.CodigoDeCamara = textCamaraDeComercio.Text;
            drogueria.FraseDistintiva = textFraseDistintiva.Text;
            drogueria.Regimen = comboRegimen.Text;
            drogueria.PBX = textPBX.Text;
            drogueria.Direccion = textDireccion.Text;
            drogueria.Telefono = textTelefono.Text;
            return drogueria;
        }

        private void btnRegistrarInfo_Click(object sender, EventArgs e)
        {
            Drogueria drogueria = MapearDrogueria();
            string mensaje = drogueriaService.Guardar(drogueria);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            BuscarPorId();
        }
        private void btnEliminarInfo_Click(object sender, EventArgs e)
        {
            string mensaje = drogueriaService.Eliminar(idDrogueria);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private void btnModificarInfo_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Drogueria drogueria = MapearDrogueria();
                string mensaje = drogueriaService.Modificar(drogueria);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                BuscarPorId();
            }
        }
    }
}
