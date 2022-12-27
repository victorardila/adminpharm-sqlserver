using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class ProductoVencidoTxtConsultaResponse
    {
        public List<ProductoVencidoTxt> ProductoTxts { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }

        public ProductoVencidoTxtConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public ProductoVencidoTxtConsultaResponse(List<ProductoVencidoTxt> papeleras)
        {
            ProductoTxts = new List<ProductoVencidoTxt>();
            ProductoTxts = papeleras;
            Encontrado = true;
        }
    }
}
