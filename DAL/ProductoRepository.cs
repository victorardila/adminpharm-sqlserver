using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;

namespace DAL
{
    public class ProductoRepository
    {
        private readonly SqlConnection _connection;
        public ProductoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into PRODUCTO (Cantidad, Referencia, Nombre, Detalle, Fecha_De_Registro, Fecha_De_Vencimiento, Lote, Laboratorio, Estado, Tipo, Via, Valor_Por_Unidad, Valor_Por_Blister, Valor_Por_Caja, Porcentaje_De_Venta, Precio_De_Negocio, Precio_De_Venta, Ganancia_Por_Producto, Ubicacion) 
                                        values (@Cantidad, @Referencia, @Nombre, @Detalle, @Fecha_De_Registro, @Fecha_De_Vencimiento, @Lote, @Laboratorio, @Estado, @Tipo, @Via, @Valor_Por_Unidad, @Valor_Por_Blister, @Valor_Por_Caja, @Porcentaje_De_Venta, @Precio_De_Negocio, @Precio_De_Venta, @Ganancia_Por_Producto, @Ubicacion)";
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Referencia", producto.Referencia);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Detalle", producto.Detalle);
                command.Parameters.AddWithValue("@Fecha_De_Registro", producto.FechaDeRegistro);
                command.Parameters.AddWithValue("@Fecha_De_Vencimiento", producto.FechaDeVencimiento);
                command.Parameters.AddWithValue("@Lote", producto.Lote);
                command.Parameters.AddWithValue("@Laboratorio", producto.Laboratorio);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                command.Parameters.AddWithValue("@Tipo", producto.Tipo);
                command.Parameters.AddWithValue("@Via", producto.Via);
                command.Parameters.AddWithValue("@Valor_Por_Unidad", producto.ValorPorUnidad);
                command.Parameters.AddWithValue("@Valor_Por_Blister", producto.ValorPorBlister);
                command.Parameters.AddWithValue("@Valor_Por_Caja", producto.ValorPorPaquete);
                command.Parameters.AddWithValue("@Porcentaje_De_Venta", producto.PorcentajeDeVenta);
                command.Parameters.AddWithValue("@Precio_De_Negocio", producto.PrecioDeNegocio);
                command.Parameters.AddWithValue("@Precio_De_Venta", producto.PrecioDeVenta);
                command.Parameters.AddWithValue("@Ganancia_Por_Producto", producto.GananciaPorProducto);
                command.Parameters.AddWithValue("@Ubicacion", producto.Ubicacion);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from PRODUCTO where Referencia=@Referencia";
                command.Parameters.AddWithValue("@Referencia", producto.Referencia);
                command.ExecuteNonQuery();
            }
        }
        public List<Producto> ConsultarPorLaboratoio(string laboratorio)
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * Laboratorio from PRODUCTO";
                command.Parameters.AddWithValue("@Laboratorio", laboratorio);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public List<Producto> ConsultarTodosLaboratorios()
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Laboratorio from PRODUCTO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public List<Producto> ConsultarTodos()
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Cantidad, Referencia, Nombre, Detalle, Fecha_De_Registro, Fecha_De_Vencimiento, Lote, Laboratorio, Estado, Tipo, Via, Valor_Por_Unidad, Valor_Por_Blister, Valor_Por_Caja, Porcentaje_De_Venta, Precio_De_Negocio, Precio_De_Venta, Ganancia_Por_Producto, Ubicacion from PRODUCTO";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public Producto BuscarExistenciaDeLaboratorio(string laboratorio)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from PRODUCTO where Laboratorio=@Laboratorio";
                command.Parameters.AddWithValue("@Laboratorio", laboratorio);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToProducto(dataReader);
            }
        }
        public Producto BuscarPorReferencia(string referencia)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from PRODUCTO where Referencia=@Referencia";
                command.Parameters.AddWithValue("@Referencia", referencia);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToProducto(dataReader);
            }
        }
        public void ModificarEstadoProducto(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update PRODUCTO set Estado=@Estado
                                        where Referencia=@Referencia";
                command.Parameters.AddWithValue("@Referencia", producto.Referencia);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Producto> BuscarPorEstado(string estado)
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from PRODUCTO where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public List<Producto> BuscarPorViaAdminitracion(string via)
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from PRODUCTO where Via=@Via";
                command.Parameters.AddWithValue("@Via", via);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public List<Producto> BuscarPorUbicacion(string ubicacion)
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from PRODUCTO where Ubicacion=@Ubicacion";
                command.Parameters.AddWithValue("@Ubicacion", ubicacion);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public List<Producto> BuscarPorTipo(string tipo)
        {
            List<Producto> productos = new List<Producto>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from PRODUCTO where Tipo=@Tipo";
                command.Parameters.AddWithValue("@Tipo", tipo);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public void ModificarCantidad(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update PRODUCTO set Cantidad=@Cantidad
                                        where Referencia=@Referencia";
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Referencia", producto.Referencia);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Modificar(Producto producto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update PRODUCTO set Cantidad=@Cantidad, Nombre=@Nombre, Detalle=@Detalle, Fecha_De_Registro=@Fecha_De_Registro, Fecha_De_Vencimiento=@Fecha_De_Vencimiento, Lote=@Lote, Laboratorio=@Laboratorio,Estado=@Estado, Tipo=@Tipo, Via=@Via, Valor_Por_Unidad=@Valor_Por_Unidad, Valor_Por_Blister=@Valor_Por_Blister, Valor_Por_Caja=@Valor_Por_Caja, Porcentaje_De_Venta=@Porcentaje_De_Venta, Precio_De_Negocio=@Precio_De_Negocio, Precio_De_Venta=@Precio_De_Venta, Ganancia_Por_Producto=@Ganancia_Por_Producto, Ubicacion=@Ubicacion
                                        where Referencia=@Referencia";
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Referencia", producto.Referencia);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Detalle", producto.Detalle);
                command.Parameters.AddWithValue("@Fecha_De_Registro", producto.FechaDeRegistro);
                command.Parameters.AddWithValue("@Fecha_De_Vencimiento", producto.FechaDeVencimiento);
                command.Parameters.AddWithValue("@Lote", producto.Lote);
                command.Parameters.AddWithValue("@Laboratorio", producto.Laboratorio);
                command.Parameters.AddWithValue("@Estado", producto.Estado);
                command.Parameters.AddWithValue("@Tipo", producto.Tipo);
                command.Parameters.AddWithValue("@Via", producto.Via);
                command.Parameters.AddWithValue("@Valor_Por_Unidad", producto.ValorPorUnidad);
                command.Parameters.AddWithValue("@Valor_Por_Blister", producto.ValorPorBlister);
                command.Parameters.AddWithValue("@Valor_Por_Caja", producto.ValorPorPaquete);
                command.Parameters.AddWithValue("@Porcentaje_De_Venta", producto.PorcentajeDeVenta);
                command.Parameters.AddWithValue("@Precio_De_Negocio", producto.PrecioDeNegocio);
                command.Parameters.AddWithValue("@Precio_De_Venta", producto.PrecioDeVenta);
                command.Parameters.AddWithValue("@Ganancia_Por_Producto", producto.GananciaPorProducto);
                command.Parameters.AddWithValue("@Ubicacion", producto.Ubicacion);
                var filas = command.ExecuteNonQuery();
            }
        }
        private Producto DataReaderMapToProducto(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.Cantidad = (int)dataReader["Cantidad"];
            producto.Referencia = (string)dataReader["Referencia"];
            producto.Nombre = (string)dataReader["Nombre"];
            producto.Detalle = (string)dataReader["Detalle"];
            producto.FechaDeRegistro = (DateTime)dataReader["Fecha_De_Registro"];
            producto.FechaDeVencimiento = (DateTime)dataReader["Fecha_De_Vencimiento"];
            producto.Lote = (string)dataReader["Lote"];
            producto.Laboratorio = (string)dataReader["Laboratorio"];
            producto.Estado = (string)dataReader["Estado"];
            producto.Tipo = (string)dataReader["Tipo"];
            producto.Via = (string)dataReader["Via"];
            producto.ValorPorUnidad = (int)dataReader["Valor_Por_Unidad"];
            producto.ValorPorBlister = (int)dataReader["Valor_Por_Blister"];
            producto.ValorPorPaquete = (int)dataReader["Valor_Por_Caja"];
            producto.PorcentajeDeVenta = (int)dataReader["Porcentaje_De_Venta"];
            producto.PrecioDeNegocio = (int)dataReader["Precio_De_Negocio"];
            producto.PrecioDeVenta = (int)dataReader["Precio_De_Venta"];
            producto.GananciaPorProducto = (int)dataReader["Ganancia_Por_Producto"];
            producto.Ubicacion = (string)dataReader["Ubicacion"];
            return producto;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.Estado.Equals(tipo)).Count();
        }
    }
}
