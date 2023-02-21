using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        //Constructor
        public Producto(int cantidad, string referencia, string nombre, string detalle, DateTime fechaDeRegistro, DateTime fechaDeVencimiento, string lote, string laboratorio, string estado, string tipo, string via, double valorPorUnidad, double valorPorBlister, double valorPorPaquete, double precioDeVenta, double precioDeNegocio, double gananciaPorProducto, string ubicacion)
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
            ValorPorUnidad = valorPorUnidad;
            ValorPorBlister = valorPorBlister;
            ValorPorPaquete = valorPorPaquete;
            PrecioDeNegocio = precioDeNegocio;
            PrecioDeVenta = precioDeVenta;
            GananciaPorProducto = gananciaPorProducto;
            Ubicacion = ubicacion;
        }
        //Constructor Sobrecargado
        public Producto()
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
        public double ValorPorUnidad { get; set; }
        public double ValorPorBlister { get; set; }
        public double ValorPorPaquete { get; set; }
        public double PorcentajeDeVenta { get; set; }
        public double PrecioDeNegocio { get; set; }
        public double PrecioDeVenta { get; set; }
        public double GananciaPorProducto { get; set; }
        public string Ubicacion { get; set; }
        /*Metodos de la clase*/
        public void calcularEstado()
        {
            int añoActual = DateTime.Now.Year;
            int mesActual = DateTime.Now.Month;
            int mesCuarentena = FechaDeVencimiento.AddDays(-90).Month;
            int añoVencimiento = FechaDeVencimiento.Year;
            int mesVencimiento = FechaDeVencimiento.Month;
            int DiferenciaDeMeses = (12 - mesActual) + mesCuarentena;

            if (añoVencimiento == añoActual)
            {
                if (mesActual == mesVencimiento)
                {
                    Estado = "Vencido";
                }
                else
                {
                    if (mesActual >= mesCuarentena && mesActual < mesVencimiento)
                    {
                        Estado = "Cuarentena";
                    }
                    else
                    {
                        if (mesActual >= mesVencimiento)
                        {
                            Estado = "Vencido";
                        }
                        else
                        {
                            if (mesActual < mesCuarentena)
                            {
                                Estado = "Vigente";
                            }
                        }
                    }
                }
            }
            else
            {
                if (añoVencimiento > añoActual)
                {
                    
                    if (DiferenciaDeMeses>0)
                    {
                        Estado = "Vigente";
                    }
                }
                else
                {
                    if (añoVencimiento < añoActual)
                    {
                        Estado = "Vencido";
                    }
                }
            }
        }
        public void calcularPrecioDeVenta()
        {
            PrecioDeVenta = ValorPorUnidad;
        }
        public void calcularGanancia()
        {
            if (PrecioDeNegocio != 0)
            {
                GananciaPorProducto = PrecioDeVenta - PrecioDeNegocio;
                PorcentajeDeVenta = (GananciaPorProducto * 100) / PrecioDeVenta;
            }
            else
            {
                if (PrecioDeNegocio == 0)
                {
                    GananciaPorProducto = 0;
                    PorcentajeDeVenta =0;
                }
            }
        }
    }
}
