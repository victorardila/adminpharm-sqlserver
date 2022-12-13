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
        public Producto(string referencia, string nombre, string detalle, DateTime fechaDeRegistro, DateTime fechaDeVencimiento, string lote, string estado, double precioDeVenta, double precioDeNegocio)
        {
            Referencia = referencia;
            Nombre = nombre;
            Detalle = detalle;
            FechaDeRegistro = fechaDeRegistro;
            FechaDeVencimiento = fechaDeVencimiento;
            Lote = lote;
            Estado = estado;
            PrecioDeNegocio = precioDeNegocio;
            PrecioDeVenta = precioDeVenta;
        }
        //Constructor Sobrecargado
        public Producto()
        {

        }
        /*Atributos de la clase*/
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public string Lote { get; set; }
        public string Estado { get; set; }
        public double PorcentajeDeVenta { get; set; }
        public double PrecioDeNegocio { get; set; }
        public double PrecioDeVenta { get; set; }
        public double GananciaPorProducto { get; set; }
        /*Metodos de la clase*/
        public void calcularEstado()
        {
            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;
            int mesPreCuarentena=FechaDeVencimiento.Month - 3;
            int añoDeVencimiento = FechaDeVencimiento.Year;
            int mesDeVencimiento = FechaDeVencimiento.Month;
            if(añoActual == añoDeVencimiento)
            {
                if (mesActual < mesPreCuarentena)
                {
                    Estado = "Vigente";
                }
                else
                {
                    if(mesActual>= mesPreCuarentena && mesActual<= mesDeVencimiento)
                    {
                        Estado = "Cuarentena";
                    }
                    else
                    {
                        if (mesActual== mesDeVencimiento)
                        {
                            Estado = "Cuarentena";
                        }
                    }
                }
            }
            else{
                if(añoActual < añoDeVencimiento)
                {
                    int añosAcumulados = añoDeVencimiento - añoActual;
                    if (añosAcumulados > 0)
                    {
                        int mesesRestantes = (12 - mesActual);
                        int diferenciaMeses = (12 - FechaDeVencimiento.Month);
                        int mesesAcumuladosAño = (12 - diferenciaMeses) + mesesRestantes;
                        if (mesesAcumuladosAño > 0)
                        {
                            Estado = "Vigente";
                        }
                        else
                        {
                            if (mesesAcumuladosAño == 0)
                            {
                                Estado = "Cuarentena";
                            }
                        }
                    }
                }
            }
        }
        public void calcularPrecioDeVenta()
        {
            PorcentajeDeVenta = (PorcentajeDeVenta / 100)* PrecioDeNegocio;
            PrecioDeVenta = PorcentajeDeVenta + PrecioDeNegocio;
        }
        public void calcularGanancia()
        {
            GananciaPorProducto = PrecioDeVenta - PrecioDeNegocio;
        }
    }
}
