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
    public partial class FormRegistrarUsuario : Form
    {
        EmpleadoService empleadoService;
        List<Empleado> empleados;
        Empleado empleado;
        public FormRegistrarUsuario()
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormRegistrarUsuario_MouseDown(object sender, MouseEventArgs e)
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
        private Empleado MapearEmpleado()
        {
            empleado = new Empleado();
            empleado.Nombres = textNombre.Text;
            empleado.Apellidos = textApellido.Text;
            empleado.Identificacion = textIdentificacion.Text;
            empleado.TipoDeIdentificacion = comboTipoDeId.Text;
            empleado.FechaDeNacimiento = DateTime.Parse(dateTimeFechaDeNacimiento.Text);
            empleado.Sexo = comboSexo.Text;
            empleado.Direccion = textDireccion.Text;
            empleado.Telefono = textTelefono.Text;
            empleado.Rol = comboRol.Text;
            empleado.CorreoElectronico = textCorreo.Text;
            empleado.Usuario = textUsuario.Text;
            empleado.Contraseña = textContraseña.Text;
            return empleado;
        }
        private void Limpiar()
        {
            textCorreo.Text = "";
            textUsuario.Text = "";
            textContraseña.Text = "";
            textIdentificacion.Text = "";
            comboTipoDeId.Text = "CC";
            comboRol.Text = "Administrador";
            textNombre.Text = "";
            textApellido.Text = "";
            dateTimeFechaDeNacimiento.Value = DateTime.Now;
            comboSexo.Text = "M";
            textDireccion.Text = "";
            textTelefono.Text = "";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearEmpleado();
            var msg = empleadoService.Guardar(empleado);
            MessageBox.Show(msg, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Mayor a 6 caracteres")
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
                textContraseña.Text = "Mayor a 6 caracteres";
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

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "@Bryan10")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.Black;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "@Bryan10";
                textUsuario.ForeColor = Color.Gray;
            }
        }

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Text == "@gmail.com")
            {
                textCorreo.Text = "";
                textCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Text == "")
            {
                textCorreo.Text = "@gmail.com";
                textCorreo.ForeColor = Color.Gray;
            }
        }
    }
}
