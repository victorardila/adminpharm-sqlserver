using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class VitrinaService
    {
        private readonly ConnectionManager conexion;
        private readonly VitrinaRepository repositorio;
        public VitrinaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new VitrinaRepository(conexion);
        }
        public string Guardar(Vitrina vitrina)
        {
            try
            {
                vitrina.GenerarCodigoVitrina();
                vitrina.CalcularEstado();
                conexion.Open();
                if (repositorio.BuscarPorCodigo(vitrina.CodigoDeVitrina) == null)
                {
                    repositorio.Guardar(vitrina);
                    return $"Vitrina registrado correctamente";
                }
                return $"Esta id de Vitrina ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaVitrinaRespuesta ConsultarTodos()
        {
            ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Vitrinas = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Vitrinas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public ConsultaVitrinaRespuesta ConsultaPorEstado(string estado)
        {
            ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Vitrinas = repositorio.BuscarPorEstado(estado);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Vitrinas != null) ? "Se consulto el vitrina buscado" : "el vitrina consultado no existe";
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
        public ConsultaVitrinaRespuesta ConsultaPorNumeroDeVitrina(string ubicacion)
        {
            ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Vitrinas = repositorio.ConsultarPornumeroDeVitrina(ubicacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Vitrinas != null) ? "Se consulto el vitrina buscado" : "el vitrina consultado no existe";
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
        public BusquedaVitrinaRespuesta BuscarPorNumeroDeVitrina(string ubicacion)
        {
            BusquedaVitrinaRespuesta respuesta = new BusquedaVitrinaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Vitrina = repositorio.BuscarPorNumeroDeVitrina(ubicacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Vitrina != null) ? "Se encontró la id de Vitrina buscado" : "la id de Vitrina buscada no existe";
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
        public BusquedaVitrinaRespuesta BuscarPorCodigo(string codigo)
        {
            BusquedaVitrinaRespuesta respuesta = new BusquedaVitrinaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Vitrina = repositorio.BuscarPorCodigo(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Vitrina != null) ? "Se encontró la id de Vitrina buscado" : "la id de Vitrina buscada no existe";
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
        public string EliminarVitrinas(string estado)
        {
            ConsultaVitrinaRespuesta respuesta = new ConsultaVitrinaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Vitrinas = repositorio.BuscarPorEstado(estado);
                if (respuesta.Vitrinas != null)
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
                var vitrina = repositorio.BuscarPorCodigo(codigo);
                if (vitrina != null)
                {
                    repositorio.Eliminar(vitrina);
                    conexion.Close();
                    return ($"El registro {vitrina.CodigoDeVitrina} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {codigo} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Vitrina vitrinaNuevo)
        {
            try
            {
                vitrinaNuevo.CalcularEstado();
                conexion.Open();
                var vitrinaAntiguo = repositorio.BuscarPorCodigo(vitrinaNuevo.CodigoDeVitrina);
                if (vitrinaAntiguo != null)
                {
                    repositorio.Modificar(vitrinaNuevo);
                    return ($"El registro de {vitrinaNuevo.CodigoDeVitrina} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el vitrina con Id {vitrinaNuevo.CodigoDeVitrina} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConteoVitrinaRespuesta Totalizar()
        {
            ConteoVitrinaRespuesta respuesta = new ConteoVitrinaRespuesta();
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
        public ConteoVitrinaRespuesta TotalizarTipo(string codigo)
        {
            ConteoVitrinaRespuesta respuesta = new ConteoVitrinaRespuesta();
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
    public class ConsultaVitrinaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Vitrina> Vitrinas { get; set; }
    }
    public class BusquedaVitrinaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Vitrina Vitrina { get; set; }
    }
    public class ConteoVitrinaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
