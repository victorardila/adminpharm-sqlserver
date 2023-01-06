using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {
        //Constructor
        public Empleado(string identificacion, string tipoDeIdentificacion, string nombres, string apellidos, DateTime fechaDeNacimiento, int edad, string direccion, string sexo, string telefono, string correoElectronico, string contraseña, string codigoEmpleado)
        {
            Identificacion = identificacion;
            TipoDeIdentificacion = tipoDeIdentificacion;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaDeNacimiento = fechaDeNacimiento;
            Edad = edad;
            Direccion = direccion;
            Sexo = sexo;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            Contraseña = contraseña;
            CodigoEmpleado = codigoEmpleado;
        }
        //Constructor Sobrecargado
        public Empleado()
        {

        }
        /*Atributos de la clase*/
        public string Identificacion { get; set; }
        public string TipoDeIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public string CodigoEmpleado { get; set; }

        /*Metodos de la clase*/
        public void GenerarCodigoEmpleado()
        {
            string a = "#Em";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(100000, 200000);
            codigo = a + b;
            CodigoEmpleado = codigo;
        }
        public void CalcularEdad()
        {
            int AñoActual = DateTime.Now.Year;
            Edad = AñoActual - FechaDeNacimiento.Year;
        }
    }
}
