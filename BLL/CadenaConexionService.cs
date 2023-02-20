using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class CadenaConexionService
    {
        private readonly CadenaConexionRepository cadenaConexionRepository;
        public CadenaConexionService()
        {
            cadenaConexionRepository = new CadenaConexionRepository();
        }
        public string Modificar(CadenaConexion cadenaConexion, string newServer)
        {
            try
            {
                cadenaConexionRepository.Modificar(cadenaConexion, newServer);
                return "Producto en txt registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }
    }
}
