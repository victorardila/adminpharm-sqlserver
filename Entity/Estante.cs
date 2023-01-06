using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estante
    {
        public Estante(string codigoDeEstante, int numeroDeEstante, int cantidadDeProductos,string estado)
        {
            CodigoDeEstante = codigoDeEstante;
            NumeroDeEstante = numeroDeEstante;
            CantidadDeProductos = cantidadDeProductos;
            Estado = estado;
        }
        public Estante()
        {

        }
        public string CodigoDeEstante { get; set; }
        public int NumeroDeEstante { get; set; }
        public int CantidadDeProductos { get; set; }
        public string Estado { get; set; }
        public void GenerarCodigoEstante()
        {
            string a = "#Est0";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(1, 200);
            codigo = a + b;
            CodigoDeEstante = codigo;
        }
        public void CalcularEstado()
        {
            if(CantidadDeProductos>0 && CantidadDeProductos < 20)
            {
                Estado = "Medio Vacio";
            }
            else
            {
                if (CantidadDeProductos > 20 && CantidadDeProductos < 50)
                {
                    Estado = "Medio Lleno";
                }
                else
                {
                    if (CantidadDeProductos>50 && CantidadDeProductos<70)
                    {
                        Estado = "Casi Lleno";
                    }
                    else
                    {
                        if (CantidadDeProductos == 0)
                        {
                            Estado = "Vacio";
                        }
                        else
                        {
                            if (CantidadDeProductos == 70)
                            {
                                Estado = "Lleno";
                            }
                        }
                    }
                }
            }
        }
    }
}
