using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class NeveraService
    {
        private readonly ConnectionManager conexion;
        private readonly NeveraRepository repositorio;
        public NeveraService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new NeveraRepository(conexion);
        }
        public string Guardar(Nevera nevera)
        {
            try
            {
                nevera.GenerarCodigoNevera();
                nevera.CalcularEstado();
                conexion.Open();
                if (repositorio.BuscarPorCodigo(nevera.CodigoDeNevera) == null)
                {
                    repositorio.Guardar(nevera);
                    return $"Nevera registrado correctamente";
                }
                return $"Esta id de Nevera ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaNeveraRespuesta ConsultarTodos()
        {
            ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
            try
            {
                conexion.Open();
                respuesta.Neveras = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Neveras.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public ConsultaNeveraRespuesta ConsultaPorEstado(string estado)
        {
            ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
            try
            {

                conexion.Open();
                respuesta.Neveras = repositorio.BuscarPorEstado(estado);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Neveras != null) ? "Se consulto el nevera buscado" : "el nevera consultado no existe";
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
        public ConsultaNeveraRespuesta ConsultaPorNumeroDeNevera(string ubicacion)
        {
            ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
            try
            {

                conexion.Open();
                respuesta.Neveras = repositorio.ConsultarPornumeroDeNevera(ubicacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Neveras != null) ? "Se consulto el nevera buscado" : "el nevera consultado no existe";
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
        public BusquedaNeveraRespuesta BuscarPorNumeroDeNevera(string ubicacion)
        {
            BusquedaNeveraRespuesta respuesta = new BusquedaNeveraRespuesta();
            try
            {

                conexion.Open();
                respuesta.Nevera = repositorio.BuscarPorNumeroDeNevera(ubicacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Nevera != null) ? "Se encontró la id de Nevera buscado" : "la id de Nevera buscada no existe";
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
        public BusquedaNeveraRespuesta BuscarPorCodigo(string codigo)
        {
            BusquedaNeveraRespuesta respuesta = new BusquedaNeveraRespuesta();
            try
            {

                conexion.Open();
                respuesta.Nevera = repositorio.BuscarPorCodigo(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Nevera != null) ? "Se encontró la id de Nevera buscado" : "la id de Nevera buscada no existe";
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
        public string EliminarNeveras(string estado)
        {
            ConsultaNeveraRespuesta respuesta = new ConsultaNeveraRespuesta();
            try
            {
                conexion.Open();
                respuesta.Neveras = repositorio.BuscarPorEstado(estado);
                if (respuesta.Neveras != null)
                {
                    repositorio.EliminarPorEstados(estado);
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
        public string Eliminar(string codigo)
        {
            try
            {
                conexion.Open();
                var nevera = repositorio.BuscarPorCodigo(codigo);
                if (nevera != null)
                {
                    repositorio.Eliminar(nevera);
                    conexion.Close();
                    return ($"El registro {nevera.CodigoDeNevera} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {codigo} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Nevera neveraNuevo)
        {
            try
            {
                neveraNuevo.CalcularEstado();
                conexion.Open();
                var neveraAntiguo = repositorio.BuscarPorCodigo(neveraNuevo.CodigoDeNevera);
                if (neveraAntiguo != null)
                {
                    repositorio.Modificar(neveraNuevo);
                    return ($"El registro de {neveraNuevo.CodigoDeNevera} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el nevera con Id {neveraNuevo.CodigoDeNevera} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConteoNeveraRespuesta Totalizar()
        {
            ConteoNeveraRespuesta respuesta = new ConteoNeveraRespuesta();
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
        public ConteoNeveraRespuesta TotalizarTipo(string codigo)
        {
            ConteoNeveraRespuesta respuesta = new ConteoNeveraRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipo(codigo);
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
    public class ConsultaNeveraRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Nevera> Neveras { get; set; }
    }
    public class BusquedaNeveraRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Nevera Nevera { get; set; }
    }
    public class ConteoNeveraRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
