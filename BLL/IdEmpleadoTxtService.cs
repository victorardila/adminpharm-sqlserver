using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class IdEmpleadoTxtService
    {
        private readonly IdEmpleadoTxtRepository idEmpleadoTxtRepository;
        public IdEmpleadoTxtService()
        {
            idEmpleadoTxtRepository = new IdEmpleadoTxtRepository();
        }

        public string Guardar(IdEmpleadoTxt idEmpleadoTxt)
        {
            try
            {
                idEmpleadoTxtRepository.Guardar(idEmpleadoTxt);
                return "Producto en txt registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }

        public IdEmpleadoTxtConsultaResponse Consultar()
        {
            try
            {
                return new IdEmpleadoTxtConsultaResponse(idEmpleadoTxtRepository.Consultar());
            }
            catch (Exception e)
            {
                return new IdEmpleadoTxtConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public bool FiltroIdentificaicon(string referencia)
        {

            try
            {
                return (idEmpleadoTxtRepository.FiltroIdentificaicon(referencia));
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public string Modificar(IdEmpleadoTxt idEmpleadoTxt, string referencia)
        {
            try
            {
                idEmpleadoTxtRepository.Modificar(idEmpleadoTxt, referencia);
                return "Producto Modificado Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Modificar:" + e.Message;
            }
        }
        public string Eliminar(string referencia)
        {
            try
            {
                idEmpleadoTxtRepository.Eliminar(referencia);
                return "Producto Eliminada";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
        public string EliminarHistorial()
        {
            try
            {
                idEmpleadoTxtRepository.EliminarTodo();
                return "Productos de factura Eliminados";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
    }
}
