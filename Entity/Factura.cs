using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public Factura(
            string id_Factura, int secuenciaDeFactura, DateTime fechaHora, string nombreDeEmpleado,string ciudad, string idCaja, string nombreDeCliente,
            int cantidad, string nombreDeProducto, string detalleDeProducto, string tipo, string via,
            double precioDeProducto, double totalSinRedondeo, double totalConRedondeo, double totalFactura, string formaDePago)
        {
            Id_Factura = id_Factura;
            SecuenciaDeFactura = secuenciaDeFactura;
            FechaHora = fechaHora;
            NombreDeEmpleado = nombreDeEmpleado;
            Ciudad = ciudad;
            IdCaja = idCaja;
            NombreDeCliente = nombreDeCliente;
            TotalSinRedondeo = totalSinRedondeo;
            TotalConRedondeo = totalConRedondeo;
            TotalFactura = totalFactura;
            FormaDePago = formaDePago;
        }
        public Factura()
        {

        }
        //Detalles de Drogueria
        //Detalles de Factura
        public string Id_Factura { get; set; }
        public int SecuenciaDeFactura { get; set; }
        public DateTime FechaHora { get; set; }
        public string NombreDeEmpleado { get; set; }
        public string Ciudad { get; set; }
        public string IdCaja { get; set; }
        public string NombreDeCliente { get; set; }
        //Detalles de producto
        //Total de Factura
        public double TotalSinRedondeo { get; set; }
        public double TotalConRedondeo { get; set; }
        public double ValorDeRedondeo { get; set; }
        public double TotalFactura { get; set; }
        public string FormaDePago { get; set; }
        public void TotalizarFactura()
        {
            TotalConRedondeo = Math.Ceiling(TotalSinRedondeo);
            ValorDeRedondeo = TotalConRedondeo - TotalSinRedondeo;
            TotalFactura = TotalConRedondeo;
        }
        public void GenerarNombrePdf()
        {
            string fechaActual = DateTime.Today.ToString("dd-MM-yyyy");
            string timeAcual = DateTime.Now.ToString("h:mm:ss tt");
            
        }
        public void GenerarIdFactura()
        {
            string a = "#FTA";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(100000, 200000);
            codigo = a + b;
            Id_Factura = codigo;
        }
        public void GenerarFechaYHoraFactura()
        {
            FechaHora = DateTime.Now;
        }
    }
}
