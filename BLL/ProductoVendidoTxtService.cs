using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ProductoVendidoTxtService
    {
        private readonly ProductoVendidoTxtRepository productoTxtRepository;
        public ProductoVendidoTxtService()
        {
            productoTxtRepository = new ProductoVendidoTxtRepository();
        }

        public string Guardar(ProductoVendidoTxt productoTxt, string rutasVendidos)
        {
            try
            {
                productoTxtRepository.Guardar(productoTxt, rutasVendidos);
                return "Producto en txt registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }

        public ProductoVendidoTxtConsultaResponse Consultar(string rutasVendidos)
        {
            try
            {
                return new ProductoVendidoTxtConsultaResponse(productoTxtRepository.Consultar(rutasVendidos));
            }
            catch (Exception e)
            {
                return new ProductoVendidoTxtConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public bool FiltroIdentificaicon(string referencia, string rutasVendidos)
        {

            try
            {
                return (productoTxtRepository.FiltroIdentificaicon(referencia, rutasVendidos));
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public ProductoVendidoTxtConsultaResponse ConsultarPorFechas(string fecha, string rutasVendidos)
        {
            try
            {
                return new ProductoVendidoTxtConsultaResponse(productoTxtRepository.ConsultarPorFechas(fecha, rutasVendidos));
            }
            catch (Exception e)
            {
                return new ProductoVendidoTxtConsultaResponse("Error al Guardar:" + e.Message);
            }

        }
        public string Modificar(ProductoVendidoTxt productoTxt, string referencia, string rutasVendidos)
        {
            try
            {
                productoTxtRepository.Modificar(productoTxt, referencia, rutasVendidos);
                return "Producto Modificado Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Modificar:" + e.Message;
            }
        }
        public string Eliminar(string referencia, string rutasVendidos)
        {
            try
            {
                productoTxtRepository.Eliminar(referencia, rutasVendidos);
                return "Producto Eliminada";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
        public string EliminarHistorial(string rutasVendidos)
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
        public string Totalizar(string rutasVendidos)
        {
            try
            {
                var Cuenta = productoTxtRepository.Totalizar(rutasVendidos).ToString();
                return Cuenta;
            }
            catch (Exception e)
            {
                var respuesta = "No se encontraron registros";
                return respuesta;
            }
        }
    }
}
