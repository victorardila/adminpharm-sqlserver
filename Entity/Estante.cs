using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estante
    {
        public string CodigoDeEstante { get; set; }
        public int NumeroDeEstante { get; set; }
        public int CantidadDeProductos { get; set; }
        public void GenerarCodigoCliente()
        {
            string a = "#Est0";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(1, 200);
            codigo = a + b;
            CodigoDeEstante = codigo;
        }
    }
}
