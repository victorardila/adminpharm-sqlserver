using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vitrina
    {
        public Vitrina(string codigoDeVitrina, string numeroDeVitrina, int cantidadDeProductos, string estado)
        {
            CodigoDeVitrina = codigoDeVitrina;
            NumeroDeVitrina = numeroDeVitrina;
            CantidadDeProductos = cantidadDeProductos;
            Estado = estado;
        }
        public Vitrina()
        {

        }
        public string CodigoDeVitrina { get; set; }
        public string NumeroDeVitrina { get; set; }
        public int CantidadDeProductos { get; set; }
        public string Estado { get; set; }
        public void GenerarCodigoVitrina()
        {
            string a = "#Vitr0";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(1, 200);
            codigo = a + b;
            CodigoDeVitrina = codigo;
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
