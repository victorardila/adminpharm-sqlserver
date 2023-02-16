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
using System.Threading;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FormGestionarEmpleados : Form
    {
        EmpleadoService empleadoService;
        List<Empleado> empleados;
        Empleado empleado;
        public FormGestionarEmpleados()
        {
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarListaDeEmpleados();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultarListaDeEmpleados() 
        {
            ConsultaEmpleadoRespuesta respuesta = new ConsultaEmpleadoRespuesta();
            string sexo = comboSexo.Text;
            if (sexo == "Todos")
            {
                respuesta = empleadoService.ConsultarTodos();
                empleados = respuesta.Empleados.ToList();
                if (respuesta.Empleados.Count != 0 && respuesta.Empleados != null)
                {
                    dataGridEmpleados.DataSource = respuesta.Empleados;
                    Eliminar.Visible = true;
                    textTotal.Text = empleadoService.Totalizar().Cuenta.ToString();
                    textTotalHombres.Text = empleadoService.TotalizarTipo("H").Cuenta.ToString();
                    textTotalMujeres.Text = empleadoService.TotalizarTipo("M").Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
            }
            else
            {
                if (respuesta.Empleados == null || respuesta.Empleados.Count == 0)
                {
                    MostrarAviso();
                    Eliminar.Visible = false;
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void MostrarAviso()
        {
            labelAdvertencia.Visible = true;
        }

        private void textSearchEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (textSearchEmpleado.Text != "")
            {
                BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
                dataGridEmpleados.DataSource = null;
                string Id_Empleado = textSearchEmpleado.Text;
                respuesta = empleadoService.BuscarPorIdentificacion(Id_Empleado);
                if (respuesta.Empleado != null)
                {
                    var empleados = new List<Empleado> { respuesta.Empleado };
                    var empleado = respuesta.Empleado;
                    dataGridEmpleados.DataSource = empleados;
                    //Mapeamos para modificar
                    textNombre.Text = empleado.Nombres;
                    textApellido.Text = empleado.Apellidos;
                    textIdentificacion.Text = empleado.Apellidos;
                    textIdentificacion.Text = empleado.Identificacion;
                    comboTipoDeId.Text = empleado.TipoDeIdentificacion;
                    dateTimeFechaDeNacimiento.Value = empleado.FechaDeNacimiento;
                    comboSexo.Text = empleado.Sexo;
                    textDireccion.Text = empleado.Direccion;
                    textTelefono.Text = empleado.Telefono.ToString();
                    textCorreo.Text = empleado.CorreoElectronico;
                    textContraseña.Text = empleado.Contraseña;
                    labelCodigoEmpleado.Text = empleado.CodigoEmpleado;
                    labelAdvertenciaEmpleado.Visible = false;
                }
                else
                {
                    if (respuesta.Empleado == null)
                    {
                        labelAdvertenciaEmpleado.Visible = true;
                    }
                }
            }
        }

        private void btnSearchEmpleado_Click(object sender, EventArgs e)
        {
            textSearchEmpleado.Visible = true;
            btnCloseEmpleado.Visible = true;
        }

        private void btnCloseEmpleado_Click(object sender, EventArgs e)
        {
            textSearchEmpleado.Visible = false;
            btnCloseEmpleado.Visible = false;
            labelAdvertenciaEmpleado.Visible = false;
            comboSexo.Text = "Todos";
            ConsultarListaDeEmpleados();
            textNombre.Text="";
            textApellido.Text="";
            textIdentificacion.Text="";
            comboTipoDeId.Text="";
            dateTimeFechaDeNacimiento.Value = DateTime.Now;
            comboSexoEmpleado.Text="";
            textDireccion.Text="";
            textTelefono.Text="";
            textCorreo.Text="";
            textContraseña.Text="";
        }
        private void textSearchEmpleado_Enter(object sender, EventArgs e)
        {
            if (textSearchEmpleado.Text == "Buscar identificacion")
            {
                textSearchEmpleado.Text = "";
            }
        }
        private void textSearchEmpleado_Leave(object sender, EventArgs e)
        {
            if (textSearchEmpleado.Text == "")
            {
                textSearchEmpleado.Text = "Buscar identificacion";
            }
        }
        private Empleado MapearEmpleado()
        {
            empleado = new Empleado();
            empleado.Nombres = textNombre.Text;
            empleado.Apellidos = textApellido.Text;
            empleado.Identificacion = textIdentificacion.Text;
            empleado.TipoDeIdentificacion = comboTipoDeId.Text;
            empleado.FechaDeNacimiento = DateTime.Parse(dateTimeFechaDeNacimiento.Text);
            empleado.Sexo = comboSexoEmpleado.Text;
            empleado.Direccion = textDireccion.Text;
            empleado.Telefono = textTelefono.Text;
            empleado.CorreoElectronico = textCorreo.Text;
            empleado.Contraseña = textContraseña.Text;
            return empleado;
        }
        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultaEmpleadoRespuesta respuesta = new ConsultaEmpleadoRespuesta();
            string sexo = comboSexo.Text;
            if (sexo != "Todos")
            {
                respuesta = empleadoService.BuscarPorSexo(sexo);
                empleados = respuesta.Empleados.ToList();
                dataGridEmpleados.DataSource = null;
                if (respuesta.Empleados.Count != 0 && respuesta.Empleados != null)
                {
                    dataGridEmpleados.DataSource = respuesta.Empleados;
                    Eliminar.Visible = true;
                    textTotal.Text = empleadoService.Totalizar().Cuenta.ToString();
                    textTotalHombres.Text = empleadoService.TotalizarTipo("H").Cuenta.ToString();
                    textTotalMujeres.Text = empleadoService.TotalizarTipo("M").Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.Empleados == null || respuesta.Empleados.Count == 0)
                    {
                        MostrarAviso();
                        Eliminar.Visible = false;
                        labelAdvertencia.Visible = true;
                    }
                }
            }
            else
            {
                if (sexo=="Todos")
                {
                    ConsultarListaDeEmpleados();
                }
            }
        }
        private void dataGridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGridEmpleados.DataSource != null)
            {
                if (dataGridEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    id = Convert.ToString(dataGridEmpleados.CurrentRow.Cells["Identificacion"].Value.ToString());
                    string msg = "Desea eliminar este registro " + id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarEmpleado(id);
                        ConsultarListaDeEmpleados();
                    }
                }
            }
            else
            {
                if (dataGridEmpleados.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void EliminarEmpleado(string id)
        {
            string mensaje = empleadoService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Eliminar.Visible = false;
            ConsultarListaDeEmpleados();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearEmpleado();
            var msg = empleadoService.Guardar(empleado);
            MessageBox.Show(msg, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConsultarListaDeEmpleados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar el producto", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Empleado empleado = MapearEmpleado();
                string mensaje = empleadoService.Modificar(empleado);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ConsultarListaDeEmpleados();
            }
        }
    }
}
