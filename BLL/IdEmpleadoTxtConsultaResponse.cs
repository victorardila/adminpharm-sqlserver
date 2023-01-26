using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
    public class IdEmpleadoTxtConsultaResponse
    {
        public List<IdEmpleadoTxt> IdEmpleadoTxts { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }

        public IdEmpleadoTxtConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public IdEmpleadoTxtConsultaResponse(List<IdEmpleadoTxt> idEmpleadoTxts)
        {
            IdEmpleadoTxts = new List<IdEmpleadoTxt>();
            IdEmpleadoTxts = idEmpleadoTxts;
            Encontrado = true;
        }
    }
}
