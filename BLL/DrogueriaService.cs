using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class DrogueriaService
    {
        private readonly ConnectionManager conexion;
        private readonly DrogueriaRepository repositorio;
        public DrogueriaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DrogueriaRepository(conexion);
        }
        public string Guardar(Drogueria drogueria)
        {
            try
            {
                drogueria.GenerarIdDrogueria();
                conexion.Open();
                if (repositorio.BuscarPorId(drogueria.NIT) == null)
                {
                    repositorio.Guardar(drogueria);
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
        public ConsultaDrogueriaRespuesta ConsultarTodos()
        {
            ConsultaDrogueriaRespuesta respuesta = new ConsultaDrogueriaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Droguerias = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Droguerias.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public string Modificar(Drogueria drogueriaNueva)
        {
            try
            {
                conexion.Open();
                var drogueriaAntigua = repositorio.BuscarPorId(drogueriaNueva.IdDrogueria);
                if (drogueriaAntigua != null)
                {
                    repositorio.Modificar(drogueriaNueva);
                    return ($"El registro de {drogueriaNueva.NIT} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, la caja con Id {drogueriaNueva.NIT} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaDrogueriaRespuesta BuscarPorId(string nit)
        {
            BusquedaDrogueriaRespuesta respuesta = new BusquedaDrogueriaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Drogueria = repositorio.BuscarPorId(nit);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Drogueria != null) ? "Se encontró la id de caja buscada" : "la id de caja buscada no existe";
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
        public string Eliminar(string id)
        {
            try
            {
                conexion.Open();
                var drogueria = repositorio.BuscarPorId(id);
                if (drogueria != null)
                {
                    repositorio.Eliminar(drogueria);
                    conexion.Close();
                    return ($"El registro {drogueria.IdDrogueria} se ha eliminado satisfactoriamente.");
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
        public ConteoProductoRespuesta TotalizarTipo(string tipo)
        {
            ConteoProductoRespuesta respuesta = new ConteoProductoRespuesta();
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
    public class ConsultaDrogueriaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Drogueria> Droguerias { get; set; }
    }
    public class BusquedaDrogueriaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Drogueria Drogueria { get; set; }
    }
    public class ConteoDrogueriaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
