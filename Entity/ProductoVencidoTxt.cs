using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoVencidoTxt
    {
        //Constructor
        public ProductoVencidoTxt(int cantidad, string referencia, string nombre, string detalle, DateTime fechaDeRegistro, DateTime fechaDeVencimiento, string lote, string laboratorio, string estado, string tipo, string via, double porcentajeDeVenta, double precioDeVenta, double precioDeNegocio, double gananciaPorProducto)
        {
            Cantidad = cantidad;
            Referencia = referencia;
            Nombre = nombre;
            Detalle = detalle;
            FechaDeRegistro = fechaDeRegistro;
            FechaDeVencimiento = fechaDeVencimiento;
            Lote = lote;
            Laboratorio = laboratorio;
            Estado = estado;
            Tipo = tipo;
            Via = via;
            PorcentajeDeVenta = porcentajeDeVenta;
            PrecioDeNegocio = precioDeNegocio;
            PrecioDeVenta = precioDeVenta;
            GananciaPorProducto = gananciaPorProducto;
        }
        //Constructor Sobrecargado
        public ProductoVencidoTxt()
        {

        }
        /*Atributos de la clase*/
        public int Cantidad { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public string Lote { get; set; }
        public string Laboratorio { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public string Via { get; set; }
        public double PorcentajeDeVenta { get; set; }
        public double PrecioDeNegocio { get; set; }
        public double PrecioDeVenta { get; set; }
        public double GananciaPorProducto { get; set; }
        public override string ToString()
        {
            return $"\n" +
                   $"- Cantidad: {Cantidad}\n" +
                   $"- Referencia: {Referencia}\n" +
                   $"- Nombre: {Nombre}\n" +
                   $"- FechaDeRegistro: {FechaDeRegistro}\n" +
                   $"- FechaDeVencimiento: {FechaDeVencimiento}\n" +
                   $"- Lote: {Lote}\n" +
                   $"- Laboratorio: {Laboratorio}\n" +
                   $"- Estado: {Estado}\n" +
                   $"- Tipo: {Tipo}\n" +
                   $"- Via: {Via}\n" +
                   $"- PorcentajeDeVenta: {PorcentajeDeVenta}\n" +
                   $"- PrecioDeNegocio: {PrecioDeNegocio}\n" +
                   $"- PrecioDeVenta: {PrecioDeVenta}\n" +
                   $"- GananciaPorProducto: {GananciaPorProducto}\n";
        }
    }
}
