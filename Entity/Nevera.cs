using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Nevera
    {
        public Nevera(string codigoDeNevera, string numeroDeNevera, int cantidadDeProductos, string estado)
        {
            CodigoDeNevera = codigoDeNevera;
            NumeroDeNevera = numeroDeNevera;
            CantidadDeProductos = cantidadDeProductos;
            Estado = estado;
        }
        public Nevera()
        {

        }
        public string CodigoDeNevera { get; set; }
        public string NumeroDeNevera { get; set; }
        public int CantidadDeProductos { get; set; }
        public string Estado { get; set; }
        public void GenerarCodigoNevera()
        {
            string a = "#Nev0";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(1, 200);
            codigo = a + b;
            CodigoDeNevera = codigo;
        }
        public void CalcularEstado()
        {
            if (CantidadDeProductos > 0 && CantidadDeProductos < 20)
            {
                Estado = "Medio Vacia";
            }
            else
            {
                if (CantidadDeProductos > 20 && CantidadDeProductos < 50)
                {
                    Estado = "Medio Llena";
                }
                else
                {
                    if (CantidadDeProductos > 50 && CantidadDeProductos < 70)
                    {
                        Estado = "Casi Llena";
                    }
                    else
                    {
                        if (CantidadDeProductos == 0)
                        {
                            Estado = "Vacia";
                        }
                        else
                        {
                            if (CantidadDeProductos == 70)
                            {
                                Estado = "Llena";
                            }
                        }
                    }
                }
            }
        }
    }
}
