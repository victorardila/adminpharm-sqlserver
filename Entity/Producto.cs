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
        public Producto(int cantidad, string referencia, string nombre, string detalle, DateTime fechaDeRegistro, DateTime fechaDeVencimiento, string lote, string laboratorio, string estado, string tipo, string via, double precioDeVenta, double precioDeNegocio, double gananciaPorProducto)
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
            PrecioDeNegocio = precioDeNegocio;
            PrecioDeVenta = precioDeVenta;
            GananciaPorProducto = gananciaPorProducto;
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
        public double PorcentajeDeVenta { get; set; }
        public double PrecioDeNegocio { get; set; }
        public double PrecioDeVenta { get; set; }
        public double GananciaPorProducto { get; set; }
        /*Metodos de la clase*/
        public void calcularEstado()
        {
            
            int añoActual = DateTime.Now.Year;
            int añoDeVencimiento = FechaDeVencimiento.Year;
            
            if(añoActual == añoDeVencimiento)
            {
                //Variables fecha actual
                int mesActual = DateTime.Now.Month;
                //Variables fecha de cuarentena
                DateTime Cuarentena = FechaDeVencimiento.AddDays(-40);
                int mesCuarentena = Cuarentena.Month;
                //Variables fecha de vencimiento
                int mesDeVencimiento = FechaDeVencimiento.Month;
                if (mesActual < mesCuarentena)
                {
                    Estado = "Vigente";
                }
                else
                {
                    if(mesActual== mesCuarentena)
                    {
                        Estado = "Cuarentena";
                    }
                    else
                    {
                        if (mesActual== mesDeVencimiento)
                        {
                            Estado = "Vencido";
                        }
                    }
                }
            }
            else{
                if(añoActual < añoDeVencimiento)
                {
                    int añosAcumulados = añoDeVencimiento - añoActual;
                    int mesActual = DateTime.Now.Month;
                    if (añosAcumulados > 0)
                    {
                        int mesesRestantes = (12 - mesActual);
                        int diferenciaMeses = (12 - FechaDeVencimiento.Month);
                        int mesesAcumuladosAño = (12 - diferenciaMeses) + mesesRestantes;
                        if (mesesAcumuladosAño >= 3)
                        {
                            Estado = "Vigente";
                        }
                        else
                        {
                            if (mesesAcumuladosAño > 0 && mesesAcumuladosAño <= 2)
                            {
                                Estado = "Cuarentena";
                            }
                            else
                            {
                                if (diferenciaMeses == 0)
                                {
                                    Estado = "Vencido";
                                }
                            }
                        }
                    }
                }
            }
        }
        public void calcularPrecioDeVenta()
        {
            double procedimientoporcentaje;
            procedimientoporcentaje = (PorcentajeDeVenta / 100)* PrecioDeNegocio;
            PrecioDeVenta = procedimientoporcentaje + PrecioDeNegocio;
        }
        public void calcularGanancia()
        {
            GananciaPorProducto = PrecioDeVenta - PrecioDeNegocio;
        }
    }
}
