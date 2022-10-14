using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Empleado
    {
        //Constructor
        public Empleado(string identificacion, string tipoDeIdentificacion, string nombres, string apellidos, DateTime fechaDeNacimiento, string direccion, string sexo, string telefono, string correoElectronico)
        {
            Identificacion = identificacion;
            TipoDeIdentificacion = tipoDeIdentificacion;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaDeNacimiento = fechaDeNacimiento;
            Direccion = direccion;
            Sexo = sexo;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
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
        public string CodigoEmpleado { get; set; }

        /*Metodos de la clase*/
        public void GenerarCodigoCliente()
        {
            string a = "#En";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(100000, 200000);
            codigo = a + b;
            CodigoEmpleado = codigo;
        }
    }
}
