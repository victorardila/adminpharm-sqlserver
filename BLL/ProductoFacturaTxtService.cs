using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ProductoFacturaTxtService
    {
        private readonly ProductoFacturaTxtRepository productoTxtRepository;
        public ProductoFacturaTxtService()
        {
            productoTxtRepository = new ProductoFacturaTxtRepository();
        }

        public string Guardar(ProductoFacturaTxt productoTxt)
        {
            try
            {
                productoTxtRepository.Guardar(productoTxt);
                return "Producto en txt registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }

        public ProductoFacturaTxtConsultaResponse Consultar()
        {
            try
            {
                return new ProductoFacturaTxtConsultaResponse(productoTxtRepository.Consultar());
            }
            catch (Exception e)
            {
                return new ProductoFacturaTxtConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public bool FiltroIdentificaicon(string referencia)
        {

            try
            {
                return (productoTxtRepository.FiltroIdentificaicon(referencia));
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public string Modificar(ProductoFacturaTxt productoTxt, string referencia)
        {
            try
            {
                productoTxtRepository.Modificar(productoTxt, referencia);
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
                productoTxtRepository.Eliminar(referencia);
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
                productoTxtRepository.EliminarTodo();
                return "Productos de factura Eliminados";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
    }
}
