using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Caja
    {
        public Caja(string idCaja, string fechaDeApertura, string fechaDeCierre, string estado, double montoInicial, double monto)
        {
            IdCaja = idCaja;
            FechaDeApertura = fechaDeApertura;
            FechaDeCierre = fechaDeCierre;
            Estado = estado;
            Monto = monto;
        }

        public Caja()
        {
        }

        public string IdCaja { get; set; }
        public string FechaDeApertura { get; set; }
        public string FechaDeCierre { get; set; }
        public string Estado { get; set; }
        public double Monto { get; set; }
        //Metodos de la clase
        string dateNullFormat = "--/--/----";
        public void AbrirCaja()
        {
            string fechaDeApertura = DateTime.Today.ToString("dd-MM-yyyy");
            FechaDeApertura = fechaDeApertura;
            FechaDeCierre = dateNullFormat;
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
            FechaDeCierre = fechaDeCierre;
            Estado = "Cerrada";
        }
    }
}
