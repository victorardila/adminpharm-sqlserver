using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
        }
        public string Guardar(Cliente cliente)
        {
            try
            {
                cliente.GenerarCodigoCliente();
                cliente.CalcularEdad();
                conexion.Open();
                if (repositorio.BuscarPorIdentificacion(cliente.Identificacion) == null)
                {
                    repositorio.Guardar(cliente);
                    return $"Cliente registrado correctamente";
                }
                return $"Esta id de cliente ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaClienteRespuesta ConsultarTodos()
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Clientes = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Clientes.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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

        public ConsultaClienteRespuesta BuscarPorSexo(string sexo)
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Clientes = repositorio.BuscarPorSexo(sexo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Clientes != null) ? "Se consulto el sexo buscado" : "el sexo consultado no existe";
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
        public BusquedaClienteRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cliente = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Cliente != null) ? "Se encontró la id de cliente buscado" : "la id de cliente buscada no existe";
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
                var cliente = repositorio.BuscarPorIdentificacion(identificacion);
                if (cliente != null)
                {
                    repositorio.Eliminar(cliente);
                    conexion.Close();
                    return ($"El registro {cliente.Identificacion} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Cliente clienteNuevo)
        {
            try
            {
                clienteNuevo.GenerarCodigoCliente();
                clienteNuevo.CalcularEdad();
                conexion.Open();
                var cajaRegistradora = repositorio.BuscarPorIdentificacion(clienteNuevo.Identificacion);
                if (cajaRegistradora != null)
                {
                    repositorio.Modificar(clienteNuevo);
                    return ($"El registro de {clienteNuevo.Identificacion} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, el cliente con Id {clienteNuevo.Identificacion} no se encuentra registrada.");
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
    public class ConsultaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }
    public class BusquedaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
    }
    public class ConteoClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
