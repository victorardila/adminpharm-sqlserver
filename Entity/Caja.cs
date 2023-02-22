using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Caja
    {
        public Caja(string idCaja, string fechaDeApertura, string horaDeApertura, string fechaDeCierre, string horaDeCierre, string estado, double montoInicial, double montoFinal, double ventaDelDia)
        {
            IdCaja = idCaja;
            FechaDeApertura = fechaDeApertura;
            HoraDeApertura = horaDeApertura;
            FechaDeCierre = fechaDeCierre;
            HoraDeCierre = horaDeCierre;
            Estado = estado;
            MontoInicial = montoInicial;
            MontoFinal = montoFinal;
            VentaDelDia = ventaDelDia;
        }

        public Caja()
        {
        }

        public string IdCaja { get; set; }
        public string FechaDeApertura { get; set; }
        public string HoraDeApertura { get; set; }
        public string FechaDeCierre { get; set; }
        public string HoraDeCierre { get; set; }
        public string Estado { get; set; }
        public double MontoInicial { get; set; }
        public double MontoFinal { get; set; }
        public double VentaDelDia { get; set; }

        //Metodos de la clase
        string dateNullFormat = "--/--/----";
        string timeNullFormat = "--:--";
        public void AbrirCaja()
        {
            string fechaDeApertura = DateTime.Today.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("h:mm:ss tt");
            FechaDeApertura = fechaDeApertura;
            HoraDeApertura= time;
            FechaDeCierre = dateNullFormat;
            HoraDeCierre = timeNullFormat;
            Estado = "Abierta";
        }
        public void GenerarIdCaja()
        {
            string a = "#CJ";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(25000, 30000);
            codigo = a + b;
            IdCaja = codigo;
        }
        public void CerrarCaja()
        {
            string fechaDeCierre = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("h:mm:ss tt");
            FechaDeCierre = fechaDeCierre;
            HoraDeCierre = time;
            Estado = "Cerrada";
        }
    }
}
