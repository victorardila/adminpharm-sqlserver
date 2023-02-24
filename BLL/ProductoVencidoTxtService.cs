using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
    public class ProductoVencidoTxtService
    {
        private readonly ProductoVencidoTxtRepository productoTxtRepository;
        public ProductoVencidoTxtService()
        {
            productoTxtRepository = new ProductoVencidoTxtRepository();
        }

        public string Guardar(ProductoVencidoTxt productoTxt)
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

        public ProductoVencidoTxtConsultaResponse Consultar()
        {
            try
            {
                return new ProductoVencidoTxtConsultaResponse(productoTxtRepository.Consultar());
            }
            catch (Exception e)
            {
                return new ProductoVencidoTxtConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public ProductoVencidoTxtConsultaResponse ConsultarPorReferencias(string referencia)
        {
            try
            {
                return new ProductoVencidoTxtConsultaResponse(productoTxtRepository.ConsultarPorReferencias(referencia));
            }
            catch (Exception e)
            {
                return new ProductoVencidoTxtConsultaResponse("Error al Guardar:" + e.Message);
            }

        }
        public string Modificar(ProductoVencidoTxt productoTxt, string referencia)
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
        public string Totalizar()
        {
            try
            {
                var Cuenta = productoTxtRepository.Totalizar().ToString();
                return Cuenta;
            }
            catch (Exception e)
            {
                var respuesta = "No se encontraron registros";
                return respuesta;
            }
        }
        public string TotalizarTipo(string tipo)
        {
            try
            {
                var Cuenta = productoTxtRepository.TotalizarTipo(tipo).ToString();
                return Cuenta;
            }
            catch (Exception e)
            {
                var respuesta= "No se encontraron registros";
                return respuesta;
            }
        }
    }
}
