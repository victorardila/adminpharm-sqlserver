using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class ProductoVendidoTxtRepository
    {
        private string ruta = @"ProductosVendidos.txt";
        public void Guardar(ProductoVendidoTxt productoTxt)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{productoTxt.FechaDeVenta};{productoTxt.Cantidad};{productoTxt.Referencia};{productoTxt.Nombre};{productoTxt.Detalle};{productoTxt.Precio}");
            escritor.Close();
            file.Close();
        }
        public List<ProductoVendidoTxt> Consultar()
        {
            List<ProductoVendidoTxt> productoTxts = new List<ProductoVendidoTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                ProductoVendidoTxt productoTxt = new ProductoVendidoTxt()
                {
                    FechaDeVenta=dato[0],
                    Cantidad = int.Parse(dato[1]),
                    Referencia = dato[2],
                    Nombre = dato[3],
                    Detalle = dato[4],
                    Precio = int.Parse(dato[5]),
                };
                productoTxts.Add(productoTxt);
            }
            lector.Close();
            file.Close();
            return productoTxts;
        }
        public bool FiltroIdentificaicon(string referencia)
        {
            List<ProductoVendidoTxt> productoTxts = new List<ProductoVendidoTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                if (dato[1].Equals(referencia))
                {
                    lector.Close();
                    file.Close();
                    return true;
                }
            }
            lector.Close();
            file.Close();
            return false;
        }
        private bool EsEncontrado(string referenciaRegistrada, string referenciaBuscada)
        {
            return referenciaRegistrada == referenciaBuscada;
        }
        public void Modificar(ProductoVendidoTxt productoTxt, string referencia)
        {
            List<ProductoVendidoTxt> productoTxts = new List<ProductoVendidoTxt>();
            productoTxts = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in productoTxts)
            {
                if (!EsEncontrado(item.Referencia, referencia))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(productoTxt);
                }
            }
        }
        public void EliminarTodo()
        {
            File.Delete(ruta);
        }
        public void Eliminar(string referencia)
        {
            List<ProductoVendidoTxt> productoTxts = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in productoTxts)
            {
                if (!item.Referencia.Equals(referencia))
                {
                    Guardar(item);
                }
            }
        }
        public int Totalizar()
        {
            return Consultar().Count();
        }
    }
}
