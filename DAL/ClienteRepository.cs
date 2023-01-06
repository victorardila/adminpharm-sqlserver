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
    public class ClienteRepository
    {
        private readonly SqlConnection _connection;
        public ClienteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into CLIENTE (Codigo_Cliente, Id, Tipo_De_Id, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Telefono, Correo) 
                                        values (@Codigo_Cliente, @Id, @Tipo_De_Id, @Nombres, @Apellidos, @Fecha_De_Nacimiento, @Edad, @Sexo, @Direccion_Domicilio, @Telefono, @Correo)";
                command.Parameters.AddWithValue("@Codigo_Cliente", cliente.CodigoCliente);
                command.Parameters.AddWithValue("@Id", cliente.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", cliente.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", cliente.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", cliente.Edad);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", cliente.Direccion);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Cliente> BuscarPorSexo(string sexo)
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CLIENTE where Sexo=@Sexo";
                command.Parameters.AddWithValue("@Sexo", sexo);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToCliente(dataReader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
        public Cliente BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CLIENTE where Id=@Id";
                command.Parameters.AddWithValue("@Id", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToCliente(dataReader);
            }
        }
        public void Modificar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update CLIENTE set Codigo_Cliente=@Codigo_Cliente, Tipo_De_Id=@Tipo_De_Id, Nombres=@Nombres, Apellidos=@Apellidos, Fecha_De_Nacimiento=@Fecha_De_Nacimiento, Edad=@Edad, Sexo=@Sexo, Direccion_Domicilio=@Direccion_Domicilio, Telefono=@Telefono, Correo=@Correo
                                        where Id=@Id";
                command.Parameters.AddWithValue("@Codigo_Cliente", cliente.CodigoCliente);
                command.Parameters.AddWithValue("@Id", cliente.Identificacion);
                command.Parameters.AddWithValue("@Tipo_De_Id", cliente.TipoDeIdentificacion);
                command.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@Fecha_De_Nacimiento", cliente.FechaDeNacimiento);
                command.Parameters.AddWithValue("@Edad", cliente.Edad);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@Direccion_Domicilio", cliente.Direccion);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Correo", cliente.CorreoElectronico);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Codigo_Cliente, Id, Tipo_De_Id, Nombres, Apellidos, Fecha_De_Nacimiento, Edad, Sexo, Direccion_Domicilio, Telefono, Correo from CLIENTE";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToCliente(dataReader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;

        }
        public void Eliminar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from CLIENTE where Id=@Id";
                command.Parameters.AddWithValue("@Id", cliente.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        private Cliente DataReaderMapToCliente(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.CodigoCliente = (string)dataReader["Codigo_Cliente"];
            cliente.Identificacion = (string)dataReader["Id"];
            cliente.TipoDeIdentificacion = (string)dataReader["Tipo_De_Id"];
            cliente.Nombres = (string)dataReader["Nombres"];
            cliente.Apellidos = (string)dataReader["Apellidos"];
            cliente.FechaDeNacimiento = (DateTime)dataReader["Fecha_De_Nacimiento"];
            cliente.Edad = (int)dataReader["Edad"];
            cliente.Sexo = (string)dataReader["Sexo"];
            cliente.Direccion = (string)dataReader["Direccion_Domicilio"];
            cliente.Telefono = (string)dataReader["Telefono"];
            cliente.CorreoElectronico = (string)dataReader["Correo"];
            return cliente;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.Sexo.Equals(tipo)).Count();
        }
    }
}
