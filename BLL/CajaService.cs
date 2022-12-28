using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class CajaRegistradoraService
    {
        private readonly ConnectionManager conexion;
        private readonly CajaRepository repositorio;
        public CajaRegistradoraService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new CajaRepository(conexion);
        }
        public string Guardar(Caja cajaRegistradora)
        {
            try
            {
                cajaRegistradora.AbrirCaja();
                cajaRegistradora.GenerarIdCaja();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(cajaRegistradora.IdCaja) == null)
                {
                    repositorio.Guardar(cajaRegistradora);
                    return $"Caja abierta correctamente";
                }
                return $"Esta id de caja ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaCajaRegistradoraRespuesta ConsultarTodos()
        {
            ConsultaCajaRegistradoraRespuesta respuesta = new ConsultaCajaRegistradoraRespuesta();
            try
            {

                conexion.Open();
                respuesta.CajasRegistradoras = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.CajasRegistradoras.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public BusquedaCajaRegistradoraRespuesta BuscarPorEstado(string estado)
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            try
            {

                conexion.Open();
                respuesta.CajaRegistradora = repositorio.BuscarPorEstado(estado);
                conexion.Close();
                respuesta.Mensaje = (respuesta.CajaRegistradora != null) ? "Se encontró la caja abierta" : "la id de caja buscada no existe";
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
        public string EliminarHistorial(string estado)
        {
            ConsultaCajaRegistradoraRespuesta respuesta = new ConsultaCajaRegistradoraRespuesta();
            try
            {
                conexion.Open();
                respuesta.CajasRegistradoras = repositorio.BuscarHistorial(estado);
                if (respuesta.CajasRegistradoras != null)
                {
                    repositorio.EliminarHistorial(estado);
                    conexion.Close();
                    return ($"El historial se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, las cajas en estado {estado} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var cajaRegistradora = repositorio.BuscarPorIdentificacion(identificacion);
                if (cajaRegistradora != null)
                {
                    repositorio.Eliminar(cajaRegistradora);
                    conexion.Close();
                    return ($"El registro {cajaRegistradora.IdCaja} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string ModificarCash(Caja cajaRegistradoraNueva)
        {
            try
            {
                conexion.Open();
                var cajaRegistradora = repositorio.BuscarPorIdentificacion(cajaRegistradoraNueva.IdCaja);
                if (cajaRegistradora != null)
                {
                    repositorio.ModificarCash(cajaRegistradoraNueva);
                    return ($"los productos se han generado en la caja {cajaRegistradoraNueva.IdCaja} satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, la caja con Id {cajaRegistradoraNueva.IdCaja} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Caja cajaRegistradoraNueva)
        {
            try
            {
                cajaRegistradoraNueva.CerrarCaja();
                conexion.Open();
                var cajaRegistradora = repositorio.BuscarPorIdentificacion(cajaRegistradoraNueva.IdCaja);
                if (cajaRegistradora != null)
                {
                    repositorio.Modificar(cajaRegistradoraNueva);
                    return ($"El registro de {cajaRegistradoraNueva.IdCaja} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, la caja con Id {cajaRegistradoraNueva.IdCaja} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaCajaRegistradoraRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaCajaRegistradoraRespuesta respuesta = new BusquedaCajaRegistradoraRespuesta();
            try
            {

                conexion.Open();
                respuesta.CajaRegistradora = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.CajaRegistradora != null) ? "Se encontró la id de caja buscada" : "la id de caja buscada no existe";
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
        public ConteoCajaRegistradoraRespuesta Totalizar()
        {
            ConteoCajaRegistradoraRespuesta respuesta = new ConteoCajaRegistradoraRespuesta();
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
        public ConteoCajaRegistradoraRespuesta TotalizarTipo(string tipo)
        {
            ConteoCajaRegistradoraRespuesta respuesta = new ConteoCajaRegistradoraRespuesta();
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
    public class ConsultaCajaRegistradoraRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Caja> CajasRegistradoras { get; set; }
    }
    public class BusquedaCajaRegistradoraRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Caja CajaRegistradora { get; set; }
    }
    public class ConteoCajaRegistradoraRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
