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
    public partial class FormGestionClientes : Form
    {
        ClienteService clienteService;
        List<Cliente> clientes;
        Cliente cliente;
        public FormGestionClientes()
        {
            clienteService = new ClienteService(ConfigConnection.ConnectionString);
            InitializeComponent();
            ConsultarListaDeClientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultarListaDeClientes()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            string sexo = comboSexo.Text;
            if (sexo == "Todos")
            {
                dataGridClientes.DataSource = null;
                respuesta = clienteService.ConsultarTodos();
                clientes = respuesta.Clientes.ToList();
                if (respuesta.Clientes.Count != 0 && respuesta.Clientes != null)
                {
                    dataGridClientes.DataSource = respuesta.Clientes;
                    Eliminar.Visible = true;
                    textTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                    textTotalHombres.Text = clienteService.TotalizarTipo("H").Cuenta.ToString();
                    textTotalMujeres.Text = clienteService.TotalizarTipo("M").Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.Clientes == null || respuesta.Clientes.Count == 0)
                    {
                        MostrarAviso();
                        Eliminar.Visible = false;
                        labelAdvertencia.Visible = true;
                    }
                }
            }
        }
        private void MostrarAviso()
        {
            labelAdvertencia.Visible = true;
        }

        private void btnSearchCliente_Click(object sender, EventArgs e)
        {
            textSearchCliente.Visible = true;
            btnCloseCliente.Visible = true;
        }

        private void btnCloseCliente_Click(object sender, EventArgs e)
        {
            textSearchCliente.Visible = false;
            btnCloseCliente.Visible = false;
            labelAdvertenciaCliente.Visible = false;
            comboSexo.Text = "Todos";
            ConsultarListaDeClientes();
            textNombre.Text = "";
            textApellido.Text = "";
            textIdentificacion.Text = "";
            comboTipoDeId.Text = "";
            dateTimeFechaDeNacimiento.Value = DateTime.Now;
            comboSexoCliente.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textCorreo.Text = "";
        }
        private void textSearchCliente_Enter(object sender, EventArgs e)
        {
            if (textSearchCliente.Text == "Buscar identificacion")
            {
                textSearchCliente.Text = "";
            }
        }
        private void textSearchCliente_Leave(object sender, EventArgs e)
        {
            if (textSearchCliente.Text == "")
            {
                textSearchCliente.Text = "Buscar identificacion";
            }
        }
        private void textSearchCliente_TextChanged(object sender, EventArgs e)
        {
            if (textSearchCliente.Text != "")
            {
                BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
                dataGridClientes.DataSource = null;
                string Id_Cliente = textSearchCliente.Text;
                respuesta = clienteService.BuscarPorIdentificacion(Id_Cliente);
                if (respuesta.Cliente != null)
                {
                    var clientes = new List<Cliente> { respuesta.Cliente };
                    var cliente = respuesta.Cliente;
                    dataGridClientes.DataSource = clientes;
                    //Mapeamos para modificar
                    textNombre.Text = cliente.Nombres;
                    textApellido.Text = cliente.Apellidos;
                    textIdentificacion.Text = cliente.Apellidos;
                    textIdentificacion.Text = cliente.Identificacion;
                    comboTipoDeId.Text = cliente.TipoDeIdentificacion;
                    dateTimeFechaDeNacimiento.Value = cliente.FechaDeNacimiento;
                    comboSexo.Text = cliente.Sexo;
                    textDireccion.Text = cliente.Direccion;
                    textTelefono.Text = cliente.Telefono.ToString();
                    textCorreo.Text = cliente.CorreoElectronico;
                    labelCodigoCliente.Text = cliente.CodigoCliente;
                    labelAdvertenciaCliente.Visible = false;
                }
                else
                {
                    if (respuesta.Cliente == null)
                    {
                        labelAdvertenciaCliente.Visible = true;
                    }
                }
            }
        }
        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.Nombres = textNombre.Text;
            cliente.Apellidos = textApellido.Text;
            cliente.Identificacion = textIdentificacion.Text;
            cliente.TipoDeIdentificacion = comboTipoDeId.Text;
            cliente.FechaDeNacimiento =DateTime.Parse(dateTimeFechaDeNacimiento.Text);
            cliente.Sexo = comboSexoCliente.Text;
            cliente.Direccion = textDireccion.Text;
            cliente.Telefono = textTelefono.Text;
            cliente.CorreoElectronico = textCorreo.Text;
            return cliente;
        }

        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            string sexo = comboSexo.Text;
            if (sexo != "Todos")
            {
                dataGridClientes.DataSource = null;
                respuesta = clienteService.BuscarPorSexo(sexo);
                clientes = respuesta.Clientes.ToList();
                dataGridClientes.DataSource = null;
                if (respuesta.Clientes.Count != 0 && respuesta.Clientes != null)
                {
                    dataGridClientes.DataSource = respuesta.Clientes;
                    Eliminar.Visible = true;
                    textTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                    textTotalHombres.Text = clienteService.TotalizarTipo("H").Cuenta.ToString();
                    textTotalMujeres.Text = clienteService.TotalizarTipo("M").Cuenta.ToString();
                    labelAdvertencia.Visible = false;
                }
                else
                {
                    if (respuesta.Clientes == null || respuesta.Clientes.Count == 0)
                    {
                        MostrarAviso();
                        Eliminar.Visible = false;
                        labelAdvertencia.Visible = true;
                    }
                }
            }
            else
            {
                if (sexo == "Todos")
                {
                    ConsultarListaDeClientes();
                }
            }
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGridClientes.DataSource != null)
            {
                if (dataGridClientes.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    id = Convert.ToString(dataGridClientes.CurrentRow.Cells["Identificacion"].Value.ToString());
                    string msg = "Desea eliminar este registro " + id + "?";
                    var respuesta = MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.OK)
                    {
                        EliminarEmpleado(id);
                        ConsultarListaDeClientes();
                    }
                }
            }
            else
            {
                if (dataGridClientes.DataSource == null)
                {
                    string msg = "No hay registros disponibles";
                    MessageBox.Show(msg, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void EliminarEmpleado(string id)
        {
            string mensaje = clienteService.Eliminar(id);
            MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Eliminar.Visible = false;
            ConsultarListaDeClientes();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
            var msg = clienteService.Guardar(cliente);
            MessageBox.Show(msg, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ConsultarListaDeClientes();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar el producto", "Mensaje de Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Cliente cliente = MapearCliente();
                string mensaje = clienteService.Modificar(cliente);
                MessageBox.Show(mensaje, "Mensaje de campos", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ConsultarListaDeClientes();
            }
        }
    }
}
