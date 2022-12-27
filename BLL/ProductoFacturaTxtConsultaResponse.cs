using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class ProductoFacturaTxtConsultaResponse
    {
        public List<ProductoFacturaTxt> ProductoTxts { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }

        public ProductoFacturaTxtConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public ProductoFacturaTxtConsultaResponse(List<ProductoFacturaTxt> papeleras)
        {
            ProductoTxts = new List<ProductoFacturaTxt>();
            ProductoTxts = papeleras;
            Encontrado = true;
        }
    }
}
