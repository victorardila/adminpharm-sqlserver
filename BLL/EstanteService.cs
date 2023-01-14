using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class EstanteService
    {
        private readonly ConnectionManager conexion;
        private readonly EstanteRepository repositorio;
        public EstanteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new EstanteRepository(conexion);
        }
        public string Guardar(Estante estante)
        {
            try
            {
                estante.GenerarCodigoEstante();
                estante.CalcularEstado();
                conexion.Open();
                if (repositorio.BuscarPorCodigo(estante.CodigoDeEstante) == null)
                {
                    repositorio.Guardar(estante);
                    return $"Estante registrado correctamente";
                }
                return $"Esta id de Estante ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaEstanteRespuesta ConsultarTodos()
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            try
            {
                conexion.Open();
                respuesta.Estantes = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Estantes.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public ConsultaEstanteRespuesta ConsultaPorEstado(string estado)
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Estantes = repositorio.BuscarPorEstado(estado);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Estantes != null) ? "Se consulto el estante buscado" : "el estante consultado no existe";
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
        public ConsultaEstanteRespuesta ConsultaPorNumeroDeEstante(string ubicacion)
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Estantes = repositorio.ConsultarPornumeroDeEstante(ubicacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Estantes != null) ? "Se consulto el estante buscado" : "el estante consultado no existe";
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
        public BusquedaEstanteRespuesta BuscarPorNumeroDeEstante(string ubicacion)
        {
            BusquedaEstanteRespuesta respuesta = new BusquedaEstanteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Estante = repositorio.BuscarPorNumeroDeEstante(ubicacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Estante != null) ? "Se encontró la id de Estante buscado" : "la id de Estante buscada no existe";
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
        public BusquedaEstanteRespuesta BuscarPorCodigo(string codigo)
        {
            BusquedaEstanteRespuesta respuesta = new BusquedaEstanteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Estante = repositorio.BuscarPorCodigo(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Estante != null) ? "Se encontró la id de Estante buscado" : "la id de Estante buscada no existe";
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
        public string EliminarEstantes(string estado)
        {
            ConsultaEstanteRespuesta respuesta = new ConsultaEstanteRespuesta();
            try
            {
                conexion.Open();
                respuesta.Estantes = repositorio.BuscarPorEstado(estado);
                if (respuesta.Estantes != null)
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
                var estante = repositorio.BuscarPorCodigo(codigo);
                if (estante != null)
                {
                    repositorio.Eliminar(estante);
                    conexion.Close();
                    return ($"El registro {estante.CodigoDeEstante} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {codigo} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Estante estanteNuevo)
        {
            try
            {
                estanteNuevo.CalcularEstado();
                conexion.Open();
                var estanteAntiguo = repositorio.BuscarPorCodigo(estanteNuevo.CodigoDeEstante);
                if (estanteAntiguo != null)
                {
                    repositorio.Modificar(estanteNuevo);
                    return ($"El registro de {estanteNuevo.CodigoDeEstante} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el estante con Id {estanteNuevo.CodigoDeEstante} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConteoEstanteRespuesta Totalizar()
        {
            ConteoEstanteRespuesta respuesta = new ConteoEstanteRespuesta();
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
        public ConteoEstanteRespuesta TotalizarTipo(string codigo)
        {
            ConteoEstanteRespuesta respuesta = new ConteoEstanteRespuesta();
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
    public class ConsultaEstanteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Estante> Estantes { get; set; }
    }
    public class BusquedaEstanteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Estante Estante { get; set; }
    }
    public class ConteoEstanteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
