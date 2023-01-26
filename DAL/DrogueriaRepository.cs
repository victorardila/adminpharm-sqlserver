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
    public class DrogueriaRepository
    {
        private readonly SqlConnection _connection;
        public DrogueriaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Drogueria drogueria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into DROGUERIA (Id_Drogueria, Nombre_De_Drogueria, NIT, CodigoCamara, Frase_Distintiva, Regimen, PBX,Direccion,Telefono) 
                                        values (@Id_Drogueria, @Nombre_De_Drogueria, @NIT, @CodigoCamara, @Frase_Distintiva, @Regimen, @PBX, @Direccion, @Telefono)";
                command.Parameters.AddWithValue("@Id_Drogueria", drogueria.IdDrogueria);
                command.Parameters.AddWithValue("@Nombre_De_Drogueria", drogueria.NombreDrogueria);
                command.Parameters.AddWithValue("@NIT", drogueria.NIT);
                command.Parameters.AddWithValue("@CodigoCamara", drogueria.CodigoDeCamara);
                command.Parameters.AddWithValue("@Frase_Distintiva", drogueria.FraseDistintiva);
                command.Parameters.AddWithValue("@Regimen", drogueria.Regimen);
                command.Parameters.AddWithValue("@PBX", drogueria.PBX);
                command.Parameters.AddWithValue("@Direccion", drogueria.Direccion);
                command.Parameters.AddWithValue("@Telefono", drogueria.Telefono);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Drogueria> ConsultarTodos()
        {
            List<Drogueria> cajas = new List<Drogueria>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select Id_Drogueria, Nombre_De_Drogueria, NIT, CodigoCamara, Frase_Distintiva, Regimen, PBX, Direccion, Telefono from DROGUERIA";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Drogueria drogueria = DataReaderMapToDrogueria(dataReader);
                        cajas.Add(drogueria);
                    }
                }
            }
            return cajas;
        }
        public void Modificar(Drogueria drogueria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update DROGUERIA set Nombre_De_Drogueria=@Nombre_De_Drogueria, NIT=@NIT, CodigoCamara=@CodigoCamara, Frase_Distintiva=@Frase_Distintiva, Regimen=@Regimen, PBX=@PBX, Direccion=@Direccion, Telefono=@Telefono
                                        where Id_Drogueria=@Id_Drogueria";
                command.Parameters.AddWithValue("@Id_Drogueria", drogueria.IdDrogueria);
                command.Parameters.AddWithValue("@Nombre_De_Drogueria", drogueria.NombreDrogueria);
                command.Parameters.AddWithValue("@NIT", drogueria.NIT);
                command.Parameters.AddWithValue("@CodigoCamara", drogueria.CodigoDeCamara);
                command.Parameters.AddWithValue("@Frase_Distintiva", drogueria.FraseDistintiva);
                command.Parameters.AddWithValue("@Regimen", drogueria.Regimen);
                command.Parameters.AddWithValue("@PBX", drogueria.PBX);
                command.Parameters.AddWithValue("@Direccion", drogueria.Direccion);
                command.Parameters.AddWithValue("@Telefono", drogueria.Telefono);
                var filas = command.ExecuteNonQuery();
            }
        }
        public Drogueria BuscarPorId(string nit)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from DROGUERIA where Id_Drogueria=@Id_Drogueria";
                command.Parameters.AddWithValue("@Id_Drogueria", nit);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToDrogueria(dataReader);
            }
        }
        public void Eliminar(Drogueria drogueria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from DROGUERIA where Id_Drogueria=@Id_Drogueria";
                command.Parameters.AddWithValue("@Id_Drogueria", drogueria.IdDrogueria);
                command.ExecuteNonQuery();
            }
        }
        private Drogueria DataReaderMapToDrogueria(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Drogueria drogueria = new Drogueria();
            drogueria.IdDrogueria = (string)dataReader["Id_Drogueria"];
            drogueria.NombreDrogueria = (string)dataReader["Nombre_De_Drogueria"];
            drogueria.NIT = (string)dataReader["NIT"];
            drogueria.CodigoDeCamara = (string)dataReader["CodigoCamara"];
            drogueria.FraseDistintiva = (string)dataReader["Frase_Distintiva"];
            drogueria.Regimen = (string)dataReader["Regimen"];
            drogueria.PBX = (string)dataReader["PBX"];
            drogueria.Direccion = (string)dataReader["Direccion"];
            drogueria.Telefono = (string)dataReader["Telefono"];
            return drogueria;
        }
        public int Totalizar()
        {
            return ConsultarTodos().Count();
        }
        public int TotalizarTipo(string tipo)
        {

            return ConsultarTodos().Where(p => p.IdDrogueria.Equals(tipo)).Count();
        }
    }
}
