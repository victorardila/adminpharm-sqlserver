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
            string nombreDrogueria, string nit, string fraseDistintiva, string regimen, 
            string pbx, string direccion, string telefono, string id_Factura, string secuenciaDeFactura, 
            DateTime fechaHora, string nombreDeEmpleado,string ciudad, string numeroDeCaja,string nombreDeCliente,
            int cantidad, string nombreDeProducto, string detalleDeProducto, string presentacion, string administracion,
            double precioDeProducto, double totalSinRedondeo, double totalConRedondeo, double totalFactura, string formaDePago)
        {
            NombreDrogueria = nombreDrogueria;
            NIT = nit;
            FraseDistintiva = fraseDistintiva;
            Regimen = regimen;
            PBX = pbx;
            Direccion = direccion;
            Telefono = telefono;
            Id_Factura = id_Factura;
            SecuenciaDeFactura = secuenciaDeFactura;
            FechaHora = fechaHora;
            NombreDeEmpleado = nombreDeEmpleado;
            Ciudad = ciudad;
            NumeroDeCaja = numeroDeCaja;
            NombreDeCliente = nombreDeCliente;
            Cantidad = cantidad;
            NombreDeProducto = nombreDeProducto;
            DetalleDeProducto = detalleDeProducto;
            Presentacion = presentacion;
            Administracion = administracion;
            PrecioDeProducto = precioDeProducto;
            TotalSinRedondeo = totalSinRedondeo;
            TotalConRedondeo = totalConRedondeo;
            TotalFactura = totalFactura;
            FormaDePago = formaDePago;
        }
        public Factura()
        {

        }
        //Detalles de Drogueria
        public string NombreDrogueria { get; set; }
        public string NIT { get; set; }
        public string FraseDistintiva { get; set; }
        public string Regimen { get; set; }
        public string PBX { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        //Detalles de Factura
        public string Id_Factura { get; set; }
        public string SecuenciaDeFactura { get; set; }
        public DateTime FechaHora { get; set; }
        public string NombreDeEmpleado { get; set; }
        public string Ciudad { get; set; }
        public string NumeroDeCaja { get; set; }
        public string NombreDeCliente { get; set; }
        //Detalles de producto
        public int Cantidad { get; set; }
        public string NombreDeProducto { get; set; }
        public string DetalleDeProducto { get; set; }
        public string Presentacion { get; set; }
        public string Administracion { get; set; }
        public double PrecioDeProducto { get; set; }
        //Total de Factura
        public double TotalSinRedondeo { get; set; }
        public double TotalConRedondeo { get; set; }
        public double TotalFactura { get; set; }
        public string FormaDePago { get; set; }
    }
}
