using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CadenaConexion
    {
        public CadenaConexion(string cadenaConexion)
        {
            Cadena = cadenaConexion;
        }
        public CadenaConexion()
        {

        }
        public string Cadena { get; set; }
    }
}
