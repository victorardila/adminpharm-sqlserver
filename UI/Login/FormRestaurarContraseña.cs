using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;
using BLL;
using Entity;

namespace Presentacion
{
    public partial class FormRestaurarContraseña : Form
    {
        EmpleadoService empleadoService;
        List<Empleado> empleados;
        Empleado empleado;
        string nombreDeUsuario;
        string identificacion;
        string tipoId;
        string nombres;
        string apellidos;
        DateTime fechaDeNacimiento;
        string direccion;
        string sexo;
        string telefono;
        string rol;
        string correo;
        string usuario;
        string contraseña;
        string codigoEmpleado;
        bool UsuarioValido;
        bool identificacionValida;
        public FormRestaurarContraseña()
        {
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            InitializeComponent();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormRestaurarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicioSesion login = new FormInicioSesion();
            login.Show();
            this.Hide();
        }
        private void MapearDatos()
        {
            nombreDeUsuario = textUsuario.Text;
            identificacion = textIdentificacion.Text;
        }
        private Empleado MapearDatosDeEmpleado()
        {
            empleado = new Empleado();
            empleado.Identificacion = identificacion;
            empleado.TipoDeIdentificacion = tipoId;
            empleado.Nombres= nombres;
            empleado.Apellidos= apellidos;
            empleado.FechaDeNacimiento = fechaDeNacimiento;
            empleado.Direccion= direccion;
            empleado.Sexo= sexo;
            empleado.Telefono= telefono;
            empleado.Rol= rol;
            empleado.CorreoElectronico= correo;
            empleado.Usuario= usuario;
            empleado.Contraseña= textContraseña.Text;
            empleado.CodigoEmpleado = codigoEmpleado;
            return empleado;
        }
        private void BuscarPorNombreDeUsuario()
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            respuesta = empleadoService.BuscarPorNombreDeUsuario(nombreDeUsuario);
            if (respuesta.Empleado != null)
            {
                var empleado = new List<Empleado> { respuesta.Empleado };
                
                UsuarioValido = true;
                labelAdvertencia.Visible = false;
                BuscarPorIdentificacion();
            }
            else
            {
                if (respuesta.Empleado == null)
                {
                    labelAdvertencia.Text = "El usuario no existe";
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void BuscarPorIdentificacion()
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            respuesta = empleadoService.BuscarPorIdentificacion(identificacion);
            if (respuesta.Empleado != null)
            {
                var empleados = new List<Empleado> { respuesta.Empleado };
                identificacionValida = true;
                labelAdvertencia.Visible = false;
                identificacion = respuesta.Empleado.Identificacion;
                tipoId= respuesta.Empleado.TipoDeIdentificacion;
                nombres= respuesta.Empleado.Nombres;
                apellidos= respuesta.Empleado.Apellidos;
                fechaDeNacimiento= respuesta.Empleado.FechaDeNacimiento;
                direccion= respuesta.Empleado.Direccion;
                sexo= respuesta.Empleado.Sexo;
                telefono= respuesta.Empleado.Telefono;
                rol= respuesta.Empleado.Rol;
                correo= respuesta.Empleado.CorreoElectronico;
                usuario= respuesta.Empleado.Usuario;
                contraseña= respuesta.Empleado.Contraseña;
                codigoEmpleado= respuesta.Empleado.CodigoEmpleado;
            }
            else
            {
                if (respuesta.Empleado == null)
                {
                    labelAdvertencia.Text = "Esta id no es de este usuario";
                    labelAdvertencia.Visible = true;
                }
            }
        }
        private void Limpiar()
        {
            textUsuario.Text = "";
            textContraseña.Text = "";
            textIdentificacion.Text = "";
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearDatosDeEmpleado();
            var msg = empleadoService.Modificar(empleado);
            MessageBox.Show(msg, "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MapearDatos();
            if (textUsuario.Text == "")
            {
                labelAdvertencia.Text = "No ha llenado el campo usuario";
                labelAdvertencia.Visible = true;
            }
            else
            {
                if (textIdentificacion.Text == "")
                {
                    labelAdvertencia.Text = "No ha llenado el campo identificacion";
                    labelAdvertencia.Visible = true;
                }
                else
                {
                    BuscarPorNombreDeUsuario();
                    if (UsuarioValido == true && identificacionValida == true)
                    {
                        labelContraseña.Enabled = true;
                        textContraseña.Enabled = true;
                        btnBuscar.Visible = false;
                        btnRestaurar.Visible = true;
                    }
                }
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Contraseña")
            {
                textContraseña.Text = "";
                textContraseña.ForeColor = Color.Black;
                textContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.Text = "Contraseña";
                textContraseña.ForeColor = Color.Gray;
                textContraseña.UseSystemPasswordChar = false;
            }
        }

        private void iconSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = true;
            iconSeePasword.Visible = false;
            textContraseña.UseSystemPasswordChar = true;
        }

        private void iconNoSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = false;
            iconSeePasword.Visible = true;
            textContraseña.UseSystemPasswordChar = false;
        }
    }
}
