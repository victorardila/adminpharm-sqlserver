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
    public class EstanteRepository
    {
        private readonly SqlConnection _connection;
        public EstanteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Estante estante)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into ESTANTE (Codigo_De_Estante, Numero_De_Estante, Cantidad_De_Productos, Estado) 
                                        values (@Codigo_De_Estante, @Numero_De_Estante, @Cantidad_De_Productos, @Estado)";
                command.Parameters.AddWithValue("@Codigo_De_Estante", estante.CodigoDeEstante);
                command.Parameters.AddWithValue("@Numero_De_Estante", estante.NumeroDeEstante);
                command.Parameters.AddWithValue("@Cantidad_De_Productos", estante.CantidadDeProductos);
                command.Parameters.AddWithValue("@Estado", estante.Estado);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Estante> ConsultarPornumeroDeEstante(string ubicacion)
        {
            List<Estante> estantes = new List<Estante>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ESTANTE where Numero_De_Estante=@Numero_De_Estante";
                command.Parameters.AddWithValue("@Numero_De_Estante", ubicacion);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Estante estante = DataReaderMapToEstante(dataReader);
                        estantes.Add(estante);
                    }
                }
            }
            return estantes;
        }
        public List<Estante> BuscarPorEstado(string estado)
        {
            List<Estante> estantes = new List<Estante>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ESTANTE where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Estante estante = DataReaderMapToEstante(dataReader);
                        estantes.Add(estante);
                    }
                }
            }
            return estantes;
        }
        public Estante BuscarPorNumeroDeEstante(string ubicacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ESTANTE where Numero_De_Estante=@Numero_De_Estante";
                command.Parameters.AddWithValue("@Numero_De_Estante", ubicacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEstante(dataReader);
            }
        }
        public Estante BuscarPorCodigo(string codigo)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from ESTANTE where Codigo_De_Estante=@Codigo_De_Estante";
                command.Parameters.AddWithValue("@Codigo_De_Estante", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEstante(dataReader);
            }
        }
        public void Modificar(Estante estante)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update ESTANTE set Codigo_De_Estante=@Codigo_De_Estante, Numero_De_Estante=@Numero_De_Estante, Cantidad_De_Productos=@Cantidad_De_Productos, Estado=@Estado
                                        where Codigo_De_Estante=@Codigo_De_Estante";
                command.Parameters.AddWithValue("@Codigo_De_Estante", estante.CodigoDeEstante);
                command.Parameters.AddWithValue("@Numero_De_Estante", estante.NumeroDeEstante);
                command.Parameters.AddWithValue("@Cantidad_De_Productos", estante.CantidadDeProductos);
                command.Parameters.AddWithValue("@Estado", estante.Estado);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Estante> ConsultarTodos()
        {
            List<Estante> estantes = new List<Estante>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Codigo_De_Estante, Numero_De_Estante, Cantidad_De_Productos, Estado from ESTANTE";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Estante estante = DataReaderMapToEstante(dataReader);
                        estantes.Add(estante);
                    }
                }
            }
            return estantes;
        }
        public void Eliminar(Estante estante)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from ESTANTE where Codigo_De_Estante=@Codigo_De_Estante";
                command.Parameters.AddWithValue("@Codigo_De_Estante", estante.CodigoDeEstante);
                command.ExecuteNonQuery();
            }
        }
        private Estante DataReaderMapToEstante(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Estante estante = new Estante();
            estante.CodigoDeEstante = (string)dataReader["Codigo_De_Estante"];
            estante.NumeroDeEstante = (int)dataReader["Numero_De_Estante"];
            estante.CantidadDeProductos = (int)dataReader["Cantidad_De_Productos"];
            estante.Estado = (string)dataReader["Estado"];
            return estante;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.NumeroDeEstante.Equals(tipo)).Count();
        }
    }
}
