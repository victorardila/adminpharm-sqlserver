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
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FormInicioSesion : Form
    {
        EmpleadoService empleadoService;
        string nombreDeUsuario;
        string contraseña;
        string Id_Empleado;
        bool UsuarioValido;
        public FormInicioSesion()
        {
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            UbicacionesPorDefault();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void iconSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = true;
            iconSeePasword.Visible = false;
            textBoxPasword.UseSystemPasswordChar = true;
        }

        private void iconNoSeePasword_Click(object sender, EventArgs e)
        {
            iconNoSeePasword.Visible = false;
            iconSeePasword.Visible = true;
            textBoxPasword.UseSystemPasswordChar = false;
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "@Usuario")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.Black;
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxUser.Text = "@Usuario";
                textBoxUser.ForeColor = Color.Gray;
            }
        }

        private void textBoxPasword_Enter(object sender, EventArgs e)
        {
            if (textBoxPasword.Text == "Contraseña")
            {
                textBoxPasword.Text = "";
                textBoxPasword.ForeColor = Color.Black;
                textBoxPasword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPasword_Leave(object sender, EventArgs e)
        {
            if (textBoxPasword.Text == "")
            {
                textBoxPasword.Text = "Contraseña";
                textBoxPasword.ForeColor = Color.Gray;
                textBoxPasword.UseSystemPasswordChar = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BuscarPorNombreDeUsuario()
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            respuesta = empleadoService.BuscarPorNombreDeUsuario(nombreDeUsuario);
            if (respuesta.Empleado != null)
            {
                var empleado = new List<Empleado> { respuesta.Empleado };
                contraseña = respuesta.Empleado.Contraseña;
                Id_Empleado = respuesta.Empleado.Identificacion;
                linkLabelRestaurarContraseña.ForeColor = Color.FromArgb(0, 0, 255);
                linkLabelRegistrarUsuario.ForeColor = Color.FromArgb(0, 0, 255);
                ValidarContraseña();
            }
            else
            {
                if (respuesta.Empleado == null)
                {
                    labelAdvertencia.Visible = true;
                    iconAdvertencia.Visible = true;
                    labelAdvertencia.Text = "El nombre de usuario no existe";
                    linkLabelRegistrarUsuario.ForeColor = Color.Maroon;
                    textBoxUser.ForeColor = Color.Maroon;
                    UbicacionesPorAdvertencia();
                }
            }
        }
        private void UbicacionesPorAdvertencia()
        {
            linkLabelRegistrarUsuario.Location = new Point(116, 296);
            linkLabelRestaurarContraseña.Location = new Point(147, 279);
        }
        private void UbicacionesPorDefault()
        {
            linkLabelRegistrarUsuario.Location = linkLabelRestaurarContraseña.Location;
            linkLabelRestaurarContraseña.Location = iconAdvertencia.Location;
        }
        private void ValidarContraseña()
        {
            if (textBoxPasword.Text == contraseña)
            {
                UsuarioValido = true;
            }
            else
            {
                if (textBoxPasword.Text != contraseña)
                {
                    UsuarioValido = false;
                    labelAdvertencia.Visible = true;
                    iconAdvertencia.Visible = true;
                    labelAdvertencia.Text = "Contraseña incorrecta";
                    linkLabelRestaurarContraseña.ForeColor = Color.Maroon;
                    textBoxPasword.ForeColor = Color.Maroon;
                    UbicacionesPorAdvertencia();
                }
            }
        }
        private void MapearDatos()
        {
            nombreDeUsuario = textBoxUser.Text;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MapearDatos();
            BuscarPorNombreDeUsuario();
            if (UsuarioValido == true)
            {
                FormMenu mainMenu = new FormMenu();
                mainMenu.idEmpleado = Id_Empleado;
                mainMenu.ValidarUsuario();
                mainMenu.Show();
                this.Hide();
            }
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                iconAdvertencia.Visible = false;
                labelAdvertencia.Visible = false;
                linkLabelRegistrarUsuario.Location = new Point(147, 279);
                linkLabelRestaurarContraseña.Location = new Point(150, 257);
            }
        }
        private void textBoxPasword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasword.Text == "")
            {
                
            }
        }
        private void linkLabelRestaurarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRestaurarContraseña formRestaurarContraseña = new FormRestaurarContraseña();
            formRestaurarContraseña.Show();
            this.Hide();
        }

        private void linkLabelRegistrarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrarUsuario formRegistrarUsuario = new FormRegistrarUsuario();
            formRegistrarUsuario.Show();
            this.Hide();
        }
    }
}
