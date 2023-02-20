using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entity;
using System.IO;
using System.Xml;

namespace DAL
{
    public class CadenaConexionRepository
    {
        private string ruta = @"AdminPharm.exe.config";
        
        public void Guardar(CadenaConexion cadenaConexion)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{cadenaConexion.Cadena}");
            escritor.Close();
            file.Close();
        }
        public void Modificar(CadenaConexion cadenaConexion, string newServer)
        {
            List<CadenaConexion> cadenaConexions = new List<CadenaConexion>();
            cadenaConexions = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in cadenaConexions)
            {
                if (!EsEncontrado(item.Cadena, newServer))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(cadenaConexion);
                }
            }
        }
        public List<CadenaConexion> Consultar()
        {
            List<CadenaConexion> cadenaConexions = new List<CadenaConexion>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split('>');
                CadenaConexion cadenaConexion = new CadenaConexion()
                {
                    Cadena = dato[0]+">",
                };
                cadenaConexions.Add(cadenaConexion);
            }
            lector.Close();
            file.Close();
            return cadenaConexions;
        }
        private bool EsEncontrado(string cadenaConexionRegistrada, string newServerBuscada)
        {
            return cadenaConexionRegistrada == newServerBuscada;
        }
    }
}
