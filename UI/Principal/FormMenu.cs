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
//se importa la libreria para arrastrar formulario
using System.Runtime.InteropServices;
using System.Threading;

namespace Presentacion
{
    public partial class FormMenu : Form
    {
        EmpleadoService empleadoService;
        IdEmpleadoTxtService idEmpleadoTxtService = new IdEmpleadoTxtService();
        int cantidadFormularios = 2;
        string rutaFacturasVenta;
        string rutaCierreDeCaja;
        public string idEmpleado;
        
        string rol;
        private readonly EventArgs e;
        private readonly object sender;
        public FormMenu()
        {
            empleadoService = new EmpleadoService(ConfigConnection.ConnectionString);
            InitializeComponent();
            customizeDesign();
            AbrirFormulario<FormGestionCaja>();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public void ValidarUsuario()
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            respuesta = empleadoService.BuscarPorIdentificacion(idEmpleado);
            if (respuesta.Empleado != null)
            {
                rol = respuesta.Empleado.Rol;
                if (rol == "Programador")
                {
                    btnGestionUsuarios.Enabled = true;
                    btnEmpleados.Enabled = true;
                    btnAjustes.Enabled = true;
                }
                else
                {
                    if (rol == "Administrador")
                    {
                        btnGestionUsuarios.Enabled = true;
                        btnEmpleados.Enabled = false;
                        btnAjustes.Enabled = false;
                    }
                    else
                    {
                        if (rol == "Empleado")
                        {
                            btnGestionUsuarios.Enabled = false;
                            btnAjustes.Enabled = false;
                        }
                    }
                }
            }
            GuardarIdUsuarioSesion(idEmpleado);
        }
        public void GuardarIdUsuarioSesion(string idEmpleado)
        {
            IdEmpleadoTxt idEmpleadoTxt = new IdEmpleadoTxt(idEmpleado);
            string mensaje = idEmpleadoTxtService.Guardar(idEmpleadoTxt);
        }
        private void AbrirSumadorDelSistema()
        {
            labelHeaderRuta.Text = "Inicio";
            AbrirFormulario<InicioResumen>();
        }
        private void btnOpenSidebar_Click(object sender, EventArgs e)
        {
            panelSidebar.Width = 186;
            btnOpenSidebar.Visible = false;
            btnCloseSidebar.Visible = true;
            labelLogoName.Visible = true;
            btnGestionCaja.Text = "Gestion de Caja";
            btnGestionProductos.Text = "Gestion de Productos";
            btnGestionUsuarios.Text = "Gestion de Usuarios";
            btnGestionFactura.Text = "Gestion de Factura";
            btnAjustes.Text = "Ajustes";
            panelSidebarClose.Visible = false;
        }

        private void btnCloseSidebar_Click(object sender, EventArgs e)
        {
            panelSidebar.Width = 46;
            btnOpenSidebar.Visible = true;
            btnCloseSidebar.Visible = false;
            labelLogoName.Visible = false;
            btnGestionCaja.Text = "";
            btnGestionProductos.Text = "";
            btnGestionUsuarios.Text = "";
            btnGestionFactura.Text = "";
            btnAjustes.Text = "";
            panelSidebarClose.Visible = true;
        }
        private void EliminarIdSesionDeUsuario()
        {
            string mensaje = idEmpleadoTxtService.EliminarHistorial();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            EliminarIdSesionDeUsuario();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnWindowMaximize.Visible = false;
            btnWindowRestore.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnWindowRestore.Visible = false;
            btnWindowMaximize.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void customizeDesign()
        {
            subMenuProductos.Visible = false;
            subMenuUsuarios.Visible = false;
            btnCloseSidebar_Click(sender, e);
            AbrirSumadorDelSistema();
            //AbrirFormulario<FormGestionarCaja>();
        }
        private void hideSubMenu()
        {
            if (subMenuProductos.Visible == true)
                subMenuProductos.Visible = false;
            if (subMenuUsuarios.Visible == true)
                subMenuUsuarios.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (panelSidebar.Width == 186) 
            {
                if (subMenu.Visible == false)
                {
                    hideSubMenu();
                    subMenu.Visible = true;
                }
                else
                {
                    subMenu.Visible = false;
                }
            }
        }
//**********************************************GESTION DE CAJA*********************************************************
        
        private void btnGestionCaja_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Caja Registradora";
            panelSelectionCaja.Location = btnGestionCaja.Location;
            panelSelectionCaja.Visible = true;
            panelSelectionAjustes.Visible = false;
            panelSelectionProducto.Visible = false;
            panelSelectionUsuarios.Visible = false;
            panelSelectionFactura.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionCaja>();
        }

//**********************************************GESTION DE PRODUCTOS****************************************************
        
        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Productos";
            showSubMenu(subMenuProductos);
            panelSelectionProducto.Location = btnGestionProductos.Location;
            panelSelectionCaja.Visible = false;
            panelSelectionAjustes.Visible = false;
            panelSelectionProducto.Visible = true;
            panelSelectionUsuarios.Visible = false;
            panelSelectionFactura.Visible = false;
        }
        private void ProgresCargarDatos()
        {
            
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            Thread cargarDatosProductos = new Thread(ProgresCargarDatos);
            cargarDatosProductos.Start();
            cargarDatosProductos.Join();
            labelHeaderRuta.Text = "Inicio > Gestion Productos > Productos";
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionProducto>();
        }
        private void btnEstantes_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Productos > Estantes";
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionDeEstantes>();
        }
        private void btnNevera_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Productos > Estantes";
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionarNevera>();
        }

        private void btnVitrina_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Productos > Estantes";
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionarVitrina>();
        }

        private void btnBodega_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Productos > Estantes";
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionBodega>();
        }
        //**********************************************GESTION DE USUARIOS*****************************************************

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Usuarios";
            showSubMenu(subMenuUsuarios);
            panelSelectionUsuarios.Location = btnGestionUsuarios.Location;
            panelSelectionCaja.Visible = false;
            panelSelectionAjustes.Visible = false;
            panelSelectionProducto.Visible = false;
            panelSelectionUsuarios.Visible = true;
            panelSelectionFactura.Visible = false;
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Usuarios > Clientes";
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionClientes>();
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Usuarios > Empleados";
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionarEmpleados>();
        }
//**********************************************GESTION DE FACTURA******************************************************
        private void btnGestionFactura_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Gestion Factura";
            panelSelectionFactura.Location = btnGestionFactura.Location;
            panelSelectionFactura.Visible = true;
            panelSelectionCaja.Visible = false;
            panelSelectionProducto.Visible = false;
            panelSelectionUsuarios.Visible = false;
            panelSelectionAjustes.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<FormGestionFacturas>();
        }
//**********************************************GESTION DE AJUSTES******************************************************
        private void btnAjustes_Click(object sender, EventArgs e)
        {
            labelHeaderRuta.Text = "Inicio > Ajustes";
            panelSelectionAjustes.Location = btnAjustes.Location;
            panelSelectionAjustes.Visible = true;
            panelSelectionCaja.Visible = false;
            panelSelectionProducto.Visible = false;
            panelSelectionUsuarios.Visible = false;
            panelSelectionFactura.Visible = false;
            CerrarFormulariosCiclo();
            AbrirFormulario<FormAjustes>();
        }
//**********************************************************************************************************************
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            btnModeDark.Visible = false;
            iconThemeMoon.Visible = false;
            btnModeLight.Visible = true;
            iconThemeSun.Visible = true;
        }
        private void btnLightMode_Click(object sender, EventArgs e)
        {
            btnModeLight.Visible = false;
            iconThemeSun.Visible = false;
            btnModeDark.Visible = true;
            iconThemeMoon.Visible = true;
        }
        //funcion Abrir Formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedorInterno.Controls.Add(formulario);
                panelContenedorInterno.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        //Funcion cerrar Formularios
        private void CerrarFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorInterno.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario != null)
            {
                formulario.Close();
            }
        }
        private void CerrarFormularioSwicth(int FormularioCerrar)
        {
            switch (FormularioCerrar)
            {
                case 1:
                    CerrarFormulario<FormGestionCaja>();
                    break;
                case 2:
                    CerrarFormulario<FormGestionDeEstantes>();
                    break;
                case 3:
                    CerrarFormulario<FormGestionarVitrina>();
                    break;
                case 4:
                    CerrarFormulario<FormGestionarNevera>();
                    break;
                case 5:
                    CerrarFormulario<FormGestionBodega>();
                    break;
                case 6:
                    CerrarFormulario<FormGestionClientes>();
                    break;
                case 7:
                    CerrarFormulario<FormGestionarEmpleados>();
                    break;
                case 8:
                    CerrarFormulario<FormGestionFacturas>();
                    break;
                case 9:
                    CerrarFormulario<FormAjustes>();
                    break;
            }
        }
        //Cerrar los formularios abiertos
        private void CerrarFormulariosCiclo()
        {
            for (int i = 1; i <= cantidadFormularios; i++)
            {
                CerrarFormularioSwicth(i);
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeaderbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogoContainer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnVerLicencia_Click(object sender, EventArgs e)
        {
            FormActivador formActivador = new FormActivador();
            formActivador.ShowDialog();
        }
    }
}
