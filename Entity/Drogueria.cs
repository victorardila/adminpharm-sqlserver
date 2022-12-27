using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Drogueria
    {
        public Drogueria(string idDrogueria, string nombreDrogueria, string nit, string fraseDistintiva, string regimen,  string pbx, string direccion, string telefono)
        {
            IdDrogueria = idDrogueria;
            NombreDrogueria = nombreDrogueria;
            NIT = nit;
            FraseDistintiva = fraseDistintiva;
            Regimen = regimen;
            PBX = pbx;
            Direccion = direccion;
            Telefono = telefono;
        }
        public Drogueria()
        {

        }
        public string IdDrogueria { get; set; }
        public string NombreDrogueria { get; set; }
        public string NIT { get; set; }
        public string FraseDistintiva { get; set; }
        public string Regimen { get; set; }
        public string PBX { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public void GenerarIdDrogueria()
        {
            IdDrogueria = "#Drog";
        }
    }
}
