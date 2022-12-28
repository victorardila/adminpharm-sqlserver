using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class ProductoVendidoTxtConsultaResponse
    {
        public List<ProductoVendidoTxt> ProductoTxts { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }

        public ProductoVendidoTxtConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public ProductoVendidoTxtConsultaResponse(List<ProductoVendidoTxt> productostxts)
        {
            ProductoTxts = new List<ProductoVendidoTxt>();
            ProductoTxts = productostxts;
            Encontrado = true;
        }
    }
}
