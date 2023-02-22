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
    public class CajaRepository
    {
        private readonly SqlConnection _connection;
        public CajaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar2(Caja caja)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Insert Into CAJA(Id_Caja, Fecha_De_Apertura, Fecha_De_Cierre, Estado, Monto_Inicial, Monto_Final, Venta_Del_Dia) " +
                    "Values (@Id_Caja, @Fecha_De_Apertura, @Fecha_De_Cierre, @Estado, @Monto_Inicial, @Monto_Final, @Venta_Del_Dia)";
                //command.Parameters.Add("@Id", SqlDbType.VarChar).Value = persona.Identificacion;
                command.Parameters.AddWithValue("@Id_Caja", caja.IdCaja);
                command.Parameters.AddWithValue("@Fecha_De_Apertura", caja.FechaDeApertura);
                command.Parameters.AddWithValue("@Fecha_De_Cierre", caja.FechaDeCierre);
                command.Parameters.AddWithValue("@Estado", caja.Estado);
                command.Parameters.AddWithValue("@Monto_Inicial", caja.MontoInicial);
                command.Parameters.AddWithValue("@Monto_Final", caja.MontoFinal);
                command.Parameters.AddWithValue("@Venta_Del_Dia", caja.VentaDelDia);
                command.ExecuteNonQuery();

            }
        }
        public void Guardar(Caja caja)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into CAJA (Id_Caja, Fecha_De_Apertura, Hora_De_Apertura, Fecha_De_Cierre, Hora_De_Cierre, Estado, Monto_Inicial, Monto_Final, Venta_Del_Dia) 
                                        values (@Id_Caja, @Fecha_De_Apertura, @Hora_De_Apertura, @Fecha_De_Cierre, @Hora_De_Cierre, @Estado, @Monto_Inicial, @Monto_Final, @Venta_Del_Dia)";
                command.Parameters.AddWithValue("@Id_Caja", caja.IdCaja);
                command.Parameters.AddWithValue("@Fecha_De_Apertura", caja.FechaDeApertura);
                command.Parameters.AddWithValue("@Hora_De_Apertura", caja.HoraDeApertura);
                command.Parameters.AddWithValue("@Fecha_De_Cierre", caja.FechaDeCierre);
                command.Parameters.AddWithValue("@Hora_De_Cierre", caja.HoraDeCierre);
                command.Parameters.AddWithValue("@Estado", caja.Estado);
                command.Parameters.AddWithValue("@Monto_Inicial", caja.MontoInicial);
                command.Parameters.AddWithValue("@Monto_Final", caja.MontoFinal);
                command.Parameters.AddWithValue("@Venta_Del_Dia", caja.VentaDelDia);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Caja caja)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from CAJA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", caja.IdCaja);
                command.ExecuteNonQuery();
            }
        }
        public void EliminarHistorial(string estado)
        {
            List<Caja> cajas = new List<Caja>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from CAJA where Estado=@Estado";
                command.Parameters.AddWithValue("@estado", estado);
                command.ExecuteNonQuery();
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Caja caja = DataReaderMapToCajaRegistradora(dataReader);
                        cajas.Add(caja);
                    }
                }
            }
        }
        public List<Caja> ConsultarTodos()
        {
            List<Caja> cajas = new List<Caja>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id_Caja, Fecha_De_Apertura, Hora_De_Apertura, Fecha_De_Cierre, Hora_De_Cierre, Estado, Monto_Inicial, Monto_Final, Venta_Del_Dia  from CAJA";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Caja caja = DataReaderMapToCajaRegistradora(dataReader);
                        cajas.Add(caja);
                    }
                }
            }
            return cajas;
        }
        public List<Caja> ConsultarPorEstadosCajas(string estado)
        {
            List<Caja> cajas = new List<Caja>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CAJA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Caja caja = DataReaderMapToCajaRegistradora(dataReader);
                        cajas.Add(caja);
                    }
                }
            }
            return cajas;
        }
        public List<Caja> BuscarHistorial(string estado)
        {
            List<Caja> cajas = new List<Caja>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CAJA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Caja caja = DataReaderMapToCajaRegistradora(dataReader);
                        cajas.Add(caja);
                    }
                }
            }
            return cajas;
        }
        public Caja BuscarPorEstado(string estado)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CAJA where Estado=@Estado";
                command.Parameters.AddWithValue("@Estado", estado);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToCajaRegistradora(dataReader);
            }
        }
        public Caja BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from CAJA where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToCajaRegistradora(dataReader);
            }
        }
        public void ModificarCash(Caja caja)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update CAJA set Monto_Final=@Monto_Final, Venta_Del_Dia=@Venta_Del_Dia
                                        where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", caja.IdCaja);
                command.Parameters.AddWithValue("@Monto_Final", caja.MontoFinal);
                command.Parameters.AddWithValue("@Venta_Del_Dia", caja.VentaDelDia);
                var filas = command.ExecuteNonQuery();
            }
        }
        public void Modificar(Caja caja)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update CAJA set Fecha_De_Apertura=@Fecha_De_Apertura, Hora_De_Apertura=@Hora_De_Apertura, Fecha_De_Cierre=@Fecha_De_Cierre, Hora_De_Cierre=@Hora_De_Cierre, Estado=@Estado, Monto_Inicial=@Monto_Inicial, Monto_Final=@Monto_Final, Venta_Del_Dia=@Venta_Del_Dia
                                        where Id_Caja=@Id_Caja";
                command.Parameters.AddWithValue("@Id_Caja", caja.IdCaja);
                command.Parameters.AddWithValue("@Fecha_De_Apertura", caja.FechaDeApertura);
                command.Parameters.AddWithValue("@Hora_De_Apertura", caja.HoraDeApertura);
                command.Parameters.AddWithValue("@Fecha_De_Cierre", caja.FechaDeCierre);
                command.Parameters.AddWithValue("@Hora_De_Cierre", caja.HoraDeCierre);
                command.Parameters.AddWithValue("@Estado", caja.Estado);
                command.Parameters.AddWithValue("@Monto_Inicial", caja.MontoInicial);
                command.Parameters.AddWithValue("@Monto_Final", caja.MontoFinal);
                command.Parameters.AddWithValue("@Venta_Del_Dia", caja.VentaDelDia);
                var filas = command.ExecuteNonQuery();
            }
        }
        private Caja DataReaderMapToCajaRegistradora(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Caja caja = new Caja();
            caja.IdCaja = (string)dataReader["Id_Caja"];
            caja.FechaDeApertura = (string)dataReader["Fecha_De_Apertura"];
            caja.HoraDeApertura = (string)dataReader["Hora_De_Apertura"];
            caja.FechaDeCierre = (string)dataReader["Fecha_De_Cierre"];
            caja.HoraDeCierre = (string)dataReader["Hora_De_Cierre"];
            caja.Estado = (string)dataReader["Estado"];
            caja.MontoInicial = (int)dataReader["Monto_Inicial"];
            caja.MontoFinal = (int)dataReader["Monto_Final"];
            caja.VentaDelDia = (int)dataReader["Venta_Del_Dia"];
            return caja;
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
