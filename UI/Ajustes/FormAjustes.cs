using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Xml;

namespace Presentacion
{
    public partial class FormAjustes : Form
    {
        CadenaConexionXMLService cadenaConexionService = new CadenaConexionXMLService();
        RutasTxtService rutasTxtService = new RutasTxtService();
        RutasTxt rutasTxt = new RutasTxt();
        CadenaConexionXML cadenaConexion = new CadenaConexionXML();
        DrogueriaService drogueriaService;
        Drogueria drogueria;
        List<Drogueria> droguerias;
        string idDrogueria = "#Drog";
        string Server;
        string newServer;
        string connectionString;
        string originalConnection;
        string primeraCadena;
        string segundaCadenaModificada;
        string segundaCadenaOriginal;
        string RutaFacturasVenta;
        string RutaCierreDeCaja;
        string RutaProductosVendidos;
        public FormAjustes()
        {
            drogueriaService = new DrogueriaService(ConfigConnection.ConnectionString);
            InitializeComponent();
            BuscarPorId();
            EncontrarCadenaDeConexion();
            EstablecerCarpetasRaiz(rutasTxtService);
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
        private void EstablecerCarpetasRaiz(RutasTxtService rutasTxtService)
        {
            RutasTxtConsultaResponse rutasTxtConsultaResponse = rutasTxtService.Consultar();
            if (rutasTxtConsultaResponse.RutasTxts.Count > 0)
            {
                foreach (var item in rutasTxtConsultaResponse.RutasTxts)
                {
                    textRutaCierreDeCaja.Text = item.RutaCierreDeCaja;
                    textRutaFacturaVentas.Text = item.RutaFacturasVenta;
                    textRutaVendido.Text=item.RutaProductosVendidos;
                    RutaCierreDeCaja = textRutaCierreDeCaja.Text;
                    RutaFacturasVenta = textRutaFacturaVentas.Text;
                    RutaProductosVendidos = textRutaVendido.Text;
                }
            }
            else
            {
                if (rutasTxtConsultaResponse.RutasTxts.Count == 0)
                {
                    if (textRutaCierreDeCaja.Text != "" && textRutaFacturaVentas.Text != "")
                    {
                        RutaCierreDeCaja = textRutaCierreDeCaja.Text;
                        RutaFacturasVenta = textRutaFacturaVentas.Text;
                        RutaProductosVendidos = textRutaVendido.Text;
                        rutasTxt.Referencia = 1;
                        rutasTxt.RutaCierreDeCaja = RutaCierreDeCaja;
                        rutasTxt.RutaFacturasVenta = RutaFacturasVenta;
                        rutasTxt.RutaProductosVendidos = RutaProductosVendidos;
                        rutasTxtService.Guardar(rutasTxt);
                    }
                }
            }
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
            ModificarCadenaConexion();
            EstablecerCarpetasRaiz(rutasTxtService);
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
                ModificarCadenaConexion();
                EstablecerCarpetasRaiz(rutasTxtService);
            }
        }

        private void btnBuscarRutaFacturaVenta_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textRutaFacturaVentas.Text = ruta;
            }
        }

        private void btnBuscarRutaCierreCaja_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textRutaCierreDeCaja.Text = ruta;
            }
        }

        private void btnBuscarCadenaConexion_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textCadenaConexion.Text = ruta;
            }
        }
        private void btnBuscarRutaVendido_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string ruta = dialog.SelectedPath;
                textRutaVendido.Text = ruta;
            }
        }
        private void ModificarCadenaConexion()
        {
            if (textCadenaConexion.Text != "")
            {
                primeraCadena = "        <add name=" + '"' + "conexion" + '"' + " connectionString=" + '"';
                segundaCadenaModificada = "Server=" + newServer + ";Database=AdminPharm;Trusted_Connection = True; MultipleActiveResultSets = true" + '"' + " />";
                segundaCadenaOriginal = Server + '"' + " />";

                cadenaConexion.Cadena = primeraCadena + segundaCadenaModificada;
                originalConnection = primeraCadena + segundaCadenaOriginal;
                cadenaConexionService.Modificar(cadenaConexion, originalConnection);
            }
        }
        private void EncontrarCadenaDeConexion()
        {
            connectionString = ConfigurationManager.ConnectionStrings ["conexion"].ConnectionString;
            labelConnectionString.Text = connectionString;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach(XmlElement xmlElement in xmlDocument.DocumentElement)
            {
                if (xmlElement.Name.Equals("connectionStrings"))
                {
                    foreach(XmlNode node in xmlElement.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "conexion")
                        {
                            Server = node.Attributes[1].Value;
                        }
                    }
                }
            }
        }

        private void textCadenaConexion_TextChanged(object sender, EventArgs e)
        {
            newServer = textCadenaConexion.Text;
        }
    }
}
