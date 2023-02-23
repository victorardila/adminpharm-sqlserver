using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class ProductoService
    {
        private readonly ConnectionManager conexion;
        private readonly ProductoRepository repositorio;
        public ProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProductoRepository(conexion);
        }
        public string Guardar(Producto producto)
        {
            try
            {
                producto.calcularEstado();
                producto.calcularPrecioDeVenta();
                producto.calcularGanancia();
                conexion.Open();
                if (repositorio.BuscarPorReferencia(producto.Referencia) == null)
                {
                    repositorio.Guardar(producto);
                    return $"Producto registrado correctamente";
                }
                else
                {
                    repositorio.Guardar(producto);
                    return $"Producto registrado correctamente";
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ModificarCantidad(Producto productoNuevo)
        {
            try
            {
                productoNuevo.calcularEstado();
                conexion.Open();
                var productoAntiguo = repositorio.BuscarPorReferencia(productoNuevo.Referencia);

                if (productoAntiguo != null)
                {
                    repositorio.ModificarCantidad(productoNuevo);
                    return $"El registro de {productoNuevo.Nombre} se ha modificado satisfactoriamente.";
                }
                else
                {
                    return $"Lo sentimos, el cliente con Identificación {productoAntiguo.Referencia} no se encuentra registrado.";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Producto productoNuevo)
        {
            try
            {
                productoNuevo.calcularEstado();
                productoNuevo.calcularPrecioDeVenta();
                productoNuevo.calcularGanancia();
                conexion.Open();
                var productoAntiguo = repositorio.BuscarPorReferencia(productoNuevo.Referencia);

                if (productoAntiguo != null)
                {
                    repositorio.Modificar(productoNuevo);
                    return $"El registro de {productoNuevo.Nombre} se ha modificado satisfactoriamente.";
                }
                else
                {
                    return $"Lo sentimos, el producto con Identificación {productoAntiguo.Referencia} no se encuentra registrado.";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string ModificarEstado(Producto productoNuevo)
        {
            try
            {
                productoNuevo.calcularEstado();
                productoNuevo.calcularPrecioDeVenta();
                productoNuevo.calcularGanancia();
                conexion.Open();
                var productoAntiguo = repositorio.BuscarPorReferencia(productoNuevo.Referencia);

                if (productoAntiguo != null)
                {
                    repositorio.ModificarEstadoProducto(productoNuevo);
                    return $"El registro de {productoNuevo.Nombre} se ha modificado satisfactoriamente.";
                }
                else
                {
                    return $"Lo sentimos, el cliente con Identificación {productoAntiguo.Referencia} no se encuentra registrado.";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaProductoRespuesta BuscarExistenciaDeLaboratorio(string laboratoio)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Producto = repositorio.BuscarExistenciaDeLaboratorio(laboratoio);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Producto != null) ? "Se encontró el producto" : "la refecrencia de producto buscada no existe";
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
        public ConsultaProductoRespuesta ConsultaTodosLaboratorios()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Productos = repositorio.ConsultarTodosLaboratorios();
                conexion.Close();
                respuesta.Mensaje = (respuesta.Productos != null) ? "Se consulto el estante buscado" : "el estante consultado no existe";
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
        public ConsultaProductoRespuesta ConsultaPorLaboratorios(string laboratorio)
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Productos = repositorio.ConsultarPorLaboratoio(laboratorio);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Productos != null) ? "Se consulto el estante buscado" : "el estante consultado no existe";
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
        public ConsultaProductoRespuesta ConsultarTodos()
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Productos = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Productos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public ConsultaProductoRespuesta BuscarPorEstado(string estado)
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Productos = repositorio.BuscarPorEstado(estado);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Productos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public ConsultaProductoRespuesta BuscarPorViaAdminitracion(string via)
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Productos = repositorio.BuscarPorViaAdminitracion(via);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Productos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public ConsultaProductoRespuesta BuscarPorUbicacion(string ubicacion)
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Productos = repositorio.BuscarPorUbicacion(ubicacion);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Productos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public ConsultaProductoRespuesta BuscarPorTipo(string tipo)
        {
            ConsultaProductoRespuesta respuesta = new ConsultaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Productos = repositorio.BuscarPorTipo(tipo);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Productos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
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
        public BusquedaProductoRespuesta BuscarPorReferencia(string referencia)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Producto = repositorio.BuscarPorReferencia(referencia);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Producto != null) ? "Se encontró el producto" : "la refecrencia de producto buscada no existe";
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
        public string Eliminar(string referencia)
        {
            try
            {
                conexion.Open();
                var producto = repositorio.BuscarPorReferencia(referencia);
                if (producto != null)
                {
                    repositorio.Eliminar(producto);
                    conexion.Close();
                    return ($"El registro {producto.Referencia} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {referencia} no se encuentra registrada.");
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
    public class ConsultaProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Producto> Productos { get; set; }
    }
    public class BusquedaProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Producto Producto { get; set; }
    }
    public class ConteoProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
