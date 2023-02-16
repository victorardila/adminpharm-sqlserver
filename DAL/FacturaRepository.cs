using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;
using System.IO;

namespace DAL
{
    public class FacturaRepository
    {
        private readonly SqlConnection _connection;
        public FacturaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public Factura BuscarPorIdCaja(string id_caja)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from FACTURA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", id_caja);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToFactura(dataReader);
            }
        }
        public Factura BuscarPorId(string idCaja)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from FACTURA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", idCaja);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToFactura(dataReader);
            }
        }
        public Factura BuscarPorSecuencia(int secuencia)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from FACTURA where Secuencia_De_Factura=@Secuencia_De_Factura";
                command.Parameters.AddWithValue("@Secuencia_De_Factura", secuencia);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToFactura(dataReader);
            }
        }
        public List<Factura> BuscarPorIdFactura(string idCaja)
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from FACTURA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", idCaja);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
        public List<Factura> BuscarHistorial(string id_factura)
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from FACTURA where Id_Factura=@Id_Factura";
                command.Parameters.AddWithValue("@Id_Factura", id_factura);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
        public void Guardar(Factura factura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into FACTURA (Id_Factura, Secuencia_De_Factura, FechaYHora, Nombre_De_Empleado, Ciudad, Id_Caja, Nombre_De_Cliente, Total_Sin_Redondeo, Total_Con_Redondeo, Total_De_Factura, Forma_De_Pago) 
                                        values (@Id_Factura, @Secuencia_De_Factura, @FechaYHora, @Nombre_De_Empleado, @Ciudad, @Id_Caja, @Nombre_De_Cliente, @Total_Sin_Redondeo, @Total_Con_Redondeo, @Total_De_Factura, @Forma_De_Pago)";
                command.Parameters.AddWithValue("@Id_Factura", factura.Id_Factura);
                command.Parameters.AddWithValue("@Secuencia_De_Factura", factura.SecuenciaDeFactura);
                command.Parameters.AddWithValue("@FechaYHora", factura.FechaHora);
                command.Parameters.AddWithValue("@Nombre_De_Empleado", factura.NombreDeEmpleado);
                command.Parameters.AddWithValue("@Ciudad", factura.Ciudad);
                command.Parameters.AddWithValue("@Id_Caja", factura.IdCaja);
                command.Parameters.AddWithValue("@Nombre_De_Cliente", factura.NombreDeCliente);
                command.Parameters.AddWithValue("@Total_Sin_Redondeo", factura.TotalSinRedondeo);
                command.Parameters.AddWithValue("@Total_Con_Redondeo", factura.TotalConRedondeo);
                command.Parameters.AddWithValue("@Total_De_Factura", factura.TotalFactura);
                command.Parameters.AddWithValue("@Forma_De_Pago", factura.FormaDePago);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Modificar(Factura factura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update FACTURA set Id_Factura=@Id_Factura, Secuencia_De_Factura=@Secuencia_De_Factura, FechaYHora=@FechaYHora, Nombre_De_Empleado=@Nombre_De_Empleado, Ciudad=@Ciudad, Id_Caja=@Id_Caja, Nombre_De_Cliente=@Nombre_De_Cliente,Total_Sin_Redondeo=@Total_Sin_Redondeo, Total_Con_Redondeo=@Total_Con_Redondeo, Total_De_Factura=@Total_De_Factura, Forma_De_Pago=@Forma_De_Pago
                                        where Id_Factura=@Id_Factura";
                command.Parameters.AddWithValue("@Id_Factura", factura.Id_Factura);
                command.Parameters.AddWithValue("@Secuencia_De_Factura", factura.SecuenciaDeFactura);
                command.Parameters.AddWithValue("@FechaYHora", factura.FechaHora);
                command.Parameters.AddWithValue("@Nombre_De_Empleado", factura.NombreDeEmpleado);
                command.Parameters.AddWithValue("@Ciudad", factura.Ciudad);
                command.Parameters.AddWithValue("@Id_Caja", factura.IdCaja);
                command.Parameters.AddWithValue("@Nombre_De_Cliente", factura.NombreDeCliente);
                command.Parameters.AddWithValue("@Total_Sin_Redondeo", factura.TotalSinRedondeo);
                command.Parameters.AddWithValue("@Total_Con_Redondeo", factura.TotalConRedondeo);
                command.Parameters.AddWithValue("@Total_De_Factura", factura.TotalFactura);
                command.Parameters.AddWithValue("@Forma_De_Pago", factura.FormaDePago);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Factura factura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from FACTURA where Referencia=@Referencia";
                command.Parameters.AddWithValue("@Referencia", factura.Id_Factura);
                command.ExecuteNonQuery();
            }
        }
        public void EliminarHistorial(string FormaDePago)
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from FACTURA where Forma_De_Pago=@Forma_De_Pago";
                command.Parameters.AddWithValue("@Forma_De_Pago", FormaDePago);
                command.ExecuteNonQuery();
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
        }
        public List<Factura> ConsultarTodos()
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id_Factura, Secuencia_De_Factura, FechaYHora, Nombre_De_Empleado, Ciudad, Id_Caja, Nombre_De_Cliente, Total_Sin_Redondeo, Total_Con_Redondeo, Total_De_Factura, Forma_De_Pago from FACTURA";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
        public List<Factura> EliminarHistorial()
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete Id_Factura, Secuencia_De_Factura, FechaYHora, Nombre_De_Empleado, Ciudad, Id_Caja, Nombre_De_Cliente, Total_Sin_Redondeo, Total_Con_Redondeo, Total_De_Factura, Forma_De_Pago from FACTURA";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
        public List<Factura> ConsultaPorIdCaja(string idCaja)
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from FACTURA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Estado", idCaja);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
        public List<Factura> BuscarPorFormaDePago(string FormaDePago)
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from FACTURA where Forma_De_Pago=@Forma_De_Pago";
                command.Parameters.AddWithValue("@Forma_De_Pago", FormaDePago);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
        private Factura DataReaderMapToFactura(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Factura factura = new Factura();
            factura.Id_Factura = (string)dataReader["Id_Factura"];
            factura.SecuenciaDeFactura = (int)dataReader["Secuencia_De_Factura"];
            factura.FechaHora = (DateTime)dataReader["FechaYHora"];
            factura.NombreDeEmpleado = (string)dataReader["Nombre_De_Empleado"];
            factura.Ciudad = (string)dataReader["Ciudad"];
            factura.IdCaja = (string)dataReader["Id_Caja"];
            factura.NombreDeCliente = (string)dataReader["Nombre_De_Cliente"];
            factura.TotalSinRedondeo = (int)dataReader["Total_Sin_Redondeo"];
            factura.TotalConRedondeo = (int)dataReader["Total_Con_Redondeo"];
            factura.TotalFactura = (int)dataReader["Total_De_Factura"];
            factura.FormaDePago = (string)dataReader["Forma_De_Pago"];
            return factura;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {
            return ConsultarTodos().Where(p => p.FormaDePago.Equals(tipo)).Count();
        }
    }
}
