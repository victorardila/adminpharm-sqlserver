using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class EmpleadoService
    {
        private readonly ConnectionManager conexion;
        private readonly EmpleadoRepository repositorio;
        public EmpleadoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new EmpleadoRepository(conexion);
        }
        public string Guardar(Empleado empleado)
        {
            try
            {
                empleado.GenerarCodigoEmpleado();
                empleado.CalcularEdad();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(empleado.Identificacion) == null)
                {
                    repositorio.Guardar(empleado);
                    return $"Empleado registrado correctamente";
                }
                return $"Esta id de empleado ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaEmpleadoRespuesta ConsultarTodos()
        {
            ConsultaEmpleadoRespuesta respuesta = new ConsultaEmpleadoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Empleados = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Empleados.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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

        public ConsultaEmpleadoRespuesta BuscarPorSexo(string sexo)
        {
            ConsultaEmpleadoRespuesta respuesta = new ConsultaEmpleadoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Empleados = repositorio.BuscarPorSexo(sexo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Empleados != null) ? "Se consulto el sexo buscado" : "el sexo consultado no existe";
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
        public BusquedaEmpleadoRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Empleado = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Empleado != null) ? "Se encontró la id de empleado buscado" : "la id de empleado buscada no existe";
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
        public BusquedaEmpleadoRespuesta BuscarPorNombreDeUsuario(string nombreDeUsuario)
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Empleado = repositorio.BuscarPorNombreDeUsuario(nombreDeUsuario);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Empleado != null) ? "Se encontró la id de empleado buscado" : "la id de empleado buscada no existe";
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
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var empleado = repositorio.BuscarPorIdentificacion(identificacion);
                if (empleado != null)
                {
                    repositorio.Eliminar(empleado);
                    conexion.Close();
                    return ($"El registro {empleado.Identificacion} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Empleado empleadoNuevo)
        {
            try
            {
                empleadoNuevo.GenerarCodigoEmpleado();
                empleadoNuevo.CalcularEdad();
                conexion.Open();
                var cajaRegistradora = repositorio.BuscarPorIdentificacion(empleadoNuevo.Identificacion);
                if (cajaRegistradora != null)
                {
                    repositorio.Modificar(empleadoNuevo);
                    return ($"El registro de {empleadoNuevo.Identificacion} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el empleado con Id {empleadoNuevo.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
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
    public class ConsultaEmpleadoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Empleado> Empleados { get; set; }
    }
    public class BusquedaEmpleadoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Empleado Empleado { get; set; }
    }
    public class ConteoEmpleadoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
