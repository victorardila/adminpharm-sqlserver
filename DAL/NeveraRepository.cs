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
    public class NeveraRepository
    {
        private readonly SqlConnection _connection;
        public NeveraRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Nevera nevera)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into NEVERA (Codigo_De_Nevera, Numero_De_Nevera, Cantidad_De_Productos, Estado) 
                                        values (@Codigo_De_Nevera, @Numero_De_Nevera, @Cantidad_De_Productos, @Estado)";
                command.Parameters.AddWithValue("@Codigo_De_Nevera", nevera.CodigoDeNevera);
                command.Parameters.AddWithValue("@Numero_De_Nevera", nevera.NumeroDeNevera);
                command.Parameters.AddWithValue("@Cantidad_De_Productos", nevera.CantidadDeProductos);
                command.Parameters.AddWithValue("@Estado", nevera.Estado);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Nevera> ConsultarPornumeroDeNevera(string ubicacion)
        {
            List<Nevera> neveras = new List<Nevera>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from NEVERA where Numero_De_Nevera=@Numero_De_Nevera";
                command.Parameters.AddWithValue("@Numero_De_Nevera", ubicacion);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Nevera nevera = DataReaderMapToNevera(dataReader);
                        neveras.Add(nevera);
                    }
                }
            }
            return neveras;
        }
        public List<Nevera> BuscarPorEstado(string estado)
        {
            List<Nevera> neveras = new List<Nevera>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from NEVERA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Nevera nevera = DataReaderMapToNevera(dataReader);
                        neveras.Add(nevera);
                    }
                }
            }
            return neveras;
        }
        public Nevera BuscarPorNumeroDeNevera(string ubicacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from NEVERA where Numero_De_Nevera=@Numero_De_Nevera";
                command.Parameters.AddWithValue("@Numero_De_Nevera", ubicacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToNevera(dataReader);
            }
        }
        public Nevera BuscarPorCodigo(string codigo)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from NEVERA where Codigo_De_Nevera=@Codigo_De_Nevera";
                command.Parameters.AddWithValue("@Codigo_De_Nevera", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToNevera(dataReader);
            }
        }
        public void Modificar(Nevera nevera)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update NEVERA set Codigo_De_Nevera=@Codigo_De_Nevera, Numero_De_Nevera=@Numero_De_Nevera, Cantidad_De_Productos=@Cantidad_De_Productos, Estado=@Estado
                                        where Codigo_De_Nevera=@Codigo_De_Nevera";
                command.Parameters.AddWithValue("@Codigo_De_Nevera", nevera.CodigoDeNevera);
                command.Parameters.AddWithValue("@Numero_De_Nevera", nevera.NumeroDeNevera);
                command.Parameters.AddWithValue("@Cantidad_De_Productos", nevera.CantidadDeProductos);
                command.Parameters.AddWithValue("@Estado", nevera.Estado);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Nevera> ConsultarTodos()
        {
            List<Nevera> neveras = new List<Nevera>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Codigo_De_Nevera, Numero_De_Nevera, Cantidad_De_Productos, Estado from NEVERA";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Nevera nevera = DataReaderMapToNevera(dataReader);
                        neveras.Add(nevera);
                    }
                }
            }
            return neveras;
        }
        public void EliminarPorEstados(string estado)
        {
            List<Nevera> neveras = new List<Nevera>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from NEVERA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                command.ExecuteNonQuery();
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Nevera nevera = DataReaderMapToNevera(dataReader);
                        neveras.Add(nevera);
                    }
                }
            }
        }
        public void Eliminar(Nevera nevera)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from NEVERA where Codigo_De_Nevera=@Codigo_De_Nevera";
                command.Parameters.AddWithValue("@Codigo_De_Nevera", nevera.CodigoDeNevera);
                command.ExecuteNonQuery();
            }
        }
        private Nevera DataReaderMapToNevera(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Nevera nevera = new Nevera();
            nevera.CodigoDeNevera = (string)dataReader["Codigo_De_Nevera"];
            nevera.NumeroDeNevera = (string)dataReader["Numero_De_Nevera"];
            nevera.CantidadDeProductos = (int)dataReader["Cantidad_De_Productos"];
            nevera.Estado = (string)dataReader["Estado"];
            return nevera;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.NumeroDeNevera.Equals(tipo)).Count();
        }
    }
}
