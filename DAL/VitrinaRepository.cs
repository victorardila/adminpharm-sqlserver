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
    public class VitrinaRepository
    {
        private readonly SqlConnection _connection;
        public VitrinaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Vitrina vitrina)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Vitrina (Codigo_De_Vitrina, Numero_De_Vitrina, Cantidad_De_Productos, Estado) 
                                        values (@Codigo_De_Vitrina, @Numero_De_Vitrina, @Cantidad_De_Productos, @Estado)";
                command.Parameters.AddWithValue("@Codigo_De_Vitrina", vitrina.CodigoDeVitrina);
                command.Parameters.AddWithValue("@Numero_De_Vitrina", vitrina.NumeroDeVitrina);
                command.Parameters.AddWithValue("@Cantidad_De_Productos", vitrina.CantidadDeProductos);
                command.Parameters.AddWithValue("@Estado", vitrina.Estado);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Vitrina> ConsultarPornumeroDeVitrina(string ubicacion)
        {
            List<Vitrina> vitrinas = new List<Vitrina>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Vitrina where Numero_De_Vitrina=@Numero_De_Vitrina";
                command.Parameters.AddWithValue("@Numero_De_Vitrina", ubicacion);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Vitrina vitrina = DataReaderMapToVitrina(dataReader);
                        vitrinas.Add(vitrina);
                    }
                }
            }
            return vitrinas;
        }
        public List<Vitrina> BuscarPorEstado(string estado)
        {
            List<Vitrina> vitrinas = new List<Vitrina>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from VITRINA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Vitrina vitrina = DataReaderMapToVitrina(dataReader);
                        vitrinas.Add(vitrina);
                    }
                }
            }
            return vitrinas;
        }
        public Vitrina BuscarPorNumeroDeVitrina(string ubicacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Vitrina where Numero_De_Vitrina=@Numero_De_Vitrina";
                command.Parameters.AddWithValue("@Numero_De_Vitrina", ubicacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToVitrina(dataReader);
            }
        }
        public Vitrina BuscarPorCodigo(string codigo)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from VITRINA where Codigo_De_Vitrina=@Codigo_De_Vitrina";
                command.Parameters.AddWithValue("@Codigo_De_Vitrina", codigo);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToVitrina(dataReader);
            }
        }
        public void Modificar(Vitrina vitrina)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update VITRINA set Codigo_De_Vitrina=@Codigo_De_Vitrina, Numero_De_Vitrina=@Numero_De_Vitrina, Cantidad_De_Productos=@Cantidad_De_Productos, Estado=@Estado
                                        where Codigo_De_Vitrina=@Codigo_De_Vitrina";
                command.Parameters.AddWithValue("@Codigo_De_Vitrina", vitrina.CodigoDeVitrina);
                command.Parameters.AddWithValue("@Numero_De_Vitrina", vitrina.NumeroDeVitrina);
                command.Parameters.AddWithValue("@Cantidad_De_Productos", vitrina.CantidadDeProductos);
                command.Parameters.AddWithValue("@Estado", vitrina.Estado);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Vitrina> ConsultarTodos()
        {
            List<Vitrina> vitrinas = new List<Vitrina>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Codigo_De_Vitrina, Numero_De_Vitrina, Cantidad_De_Productos, Estado from VITRINA";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Vitrina vitrina = DataReaderMapToVitrina(dataReader);
                        vitrinas.Add(vitrina);
                    }
                }
            }
            return vitrinas;
        }
        public void EliminarPorEstados(string estado)
        {
            List<Vitrina> vitrinas = new List<Vitrina>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from VITRINA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                command.ExecuteNonQuery();
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Vitrina vitrina = DataReaderMapToVitrina(dataReader);
                        vitrinas.Add(vitrina);
                    }
                }
            }
        }
        public void Eliminar(Vitrina vitrina)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from VITRINA where Codigo_De_Vitrina=@Codigo_De_Vitrina";
                command.Parameters.AddWithValue("@Codigo_De_Vitrina", vitrina.CodigoDeVitrina);
                command.ExecuteNonQuery();
            }
        }
        private Vitrina DataReaderMapToVitrina(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Vitrina vitrina = new Vitrina();
            vitrina.CodigoDeVitrina = (string)dataReader["Codigo_De_Vitrina"];
            vitrina.NumeroDeVitrina = (string)dataReader["Numero_De_Vitrina"];
            vitrina.CantidadDeProductos = (int)dataReader["Cantidad_De_Productos"];
            vitrina.Estado = (string)dataReader["Estado"];
            return vitrina;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.NumeroDeVitrina.Equals(tipo)).Count();
        }
    }
}
