using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class FacturaService
    {
        private readonly ConnectionManager conexion;
        private readonly FacturaRepository repositorio;
        public FacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new FacturaRepository(conexion);
        }
        public string Guardar(Factura factura)
        {
            try
            {
                factura.GenerarNombrePdf();
                factura.GenerarFechaYHoraFactura();
                factura.TotalizarFactura();
                conexion.Open();
                if (repositorio.BuscarPorId(factura.Id_Factura) == null)
                {
                    repositorio.Guardar(factura);
                    return $"La factura se generó correctamente";
                }
                return $"Esta Id de factura ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Factura facturaNueva)
        {
            try
            {
                facturaNueva.GenerarNombrePdf();
                facturaNueva.GenerarIdFactura();
                facturaNueva.GenerarFechaYHoraFactura();
                facturaNueva.TotalizarFactura();
                conexion.Open();
                var facturaAntigua = repositorio.BuscarPorId(facturaNueva.Id_Factura);

                if (facturaAntigua != null)
                {
                    repositorio.Modificar(facturaNueva);
                    return $"El registro de {facturaNueva.Id_Factura} se ha modificado satisfactoriamente.";
                }
                else
                {
                    return $"Lo sentimos, la factura con Identificación {facturaAntigua.Id_Factura} no se encuentra registrado.";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaFacturaRespuesta ConsultarTodos()
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Facturas = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Facturas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConsultaFacturaRespuesta BuscarPorIdFactura(string idCaja)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Facturas = repositorio.BuscarPorIdFactura(idCaja);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Facturas != null) ? "Se consulto el estante buscado" : "el estante consultado no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public string EliminarHistorial(string FormaDePago)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Facturas = repositorio.BuscarHistorial(FormaDePago);
                if (respuesta.Facturas != null)
                {
                    repositorio.EliminarHistorial(FormaDePago);
                    conexion.Close();
                    return ($"El historial se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, las cajas en estado {FormaDePago} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }

        public BusquedaFacturaRespuesta BuscarPorId(string id)
        {
            BusquedaFacturaRespuesta respuesta = new BusquedaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Factura = repositorio.BuscarPorId(id);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Factura != null) ? "Se encontró la factura" : "la identificacion de factura buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public BusquedaFacturaRespuesta BuscarPorSecuencia(int secuencia)
        {
            BusquedaFacturaRespuesta respuesta = new BusquedaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Factura = repositorio.BuscarPorSecuencia(secuencia);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Factura != null) ? "Se encontró la factura" : "la identificacion de factura buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConsultaFacturaRespuesta ConsultaPorIdCaja(string idCaja)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Facturas = repositorio.ConsultaPorIdCaja(idCaja);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Facturas != null) ? "Se consulto el estante buscado" : "el estante consultado no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConsultaFacturaRespuesta BuscarPorFormaDePago(string FormaDePago)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Facturas = repositorio.BuscarPorFormaDePago(FormaDePago);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Facturas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
        public string Eliminar(string id)
        {
            try
            {
                conexion.Open();
                var producto = repositorio.BuscarPorId(id);
                if (producto != null)
                {
                    repositorio.Eliminar(producto);
                    conexion.Close();
                    return ($"El registro {producto.Id_Factura} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {id} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConteoProductoRespuesta Totalizar()
        {
            ConteoProductoRespuesta respuesta = new ConteoProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.Totalizar(); ;
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConteoFacturaRespuesta TotalizarTipo(string tipo)
        {
            ConteoFacturaRespuesta respuesta = new ConteoFacturaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipo(tipo);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
    }
    public class ConsultaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Factura> Facturas { get; set; }
    }
    public class BusquedaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Factura Factura { get; set; }
    }
    public class ConteoFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
