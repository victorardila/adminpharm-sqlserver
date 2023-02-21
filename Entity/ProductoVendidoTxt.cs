using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoVendidoTxt
    {
        public ProductoVendidoTxt(string fechaDeVenta, int cantidad, string referencia, string nombre, string detalle, double precio)
        {
            FechaDeVenta = fechaDeVenta;
            Cantidad = cantidad;
            Referencia = referencia;
            Nombre = nombre;
            Detalle = detalle;
            Precio = precio;
        }
        //Constructor Sobrecargado
        public ProductoVendidoTxt()
        {

        }
        /*Atributos de la clase*/
        public string FechaDeVenta { get; set; }
        public string Referencia { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public override string ToString()
        {
            return $"\n" +
                   $"- Referencia: {Referencia}\n" +
                   $"- Cantidad: {Cantidad}\n" +
                   $"- Nombre: {Nombre}\n" +
                   $"- Detalle: {Detalle}\n" +
                   $"- Precio: {Precio}\n";
        }
    }
}
