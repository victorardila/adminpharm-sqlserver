using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class ProductoFacturaTxtRepository
    {
        private string ruta = @"ProductosAFacturar.txt";
        public void Guardar(ProductoFacturaTxt productoTxt)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{productoTxt.Cantidad};{productoTxt.Referencia};{productoTxt.Nombre};{productoTxt.Detalle};{productoTxt.Precio}");
            escritor.Close();
            file.Close();
        }
        public List<ProductoFacturaTxt> Consultar()
        {
            List<ProductoFacturaTxt> productoTxts = new List<ProductoFacturaTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                ProductoFacturaTxt productoTxt = new ProductoFacturaTxt()
                {
                    Cantidad = int.Parse(dato[0]),
                    Referencia = dato[1],
                    Nombre = dato[2],
                    Detalle = dato[3],
                    Precio = int.Parse(dato[4]),
                };
                productoTxts.Add(productoTxt);
            }
            lector.Close();
            file.Close();
            return productoTxts;
        }
        public ProductoFacturaTxt FiltroPorProducto(string referencia)
        {
            List<ProductoFacturaTxt> productoTxts = new List<ProductoFacturaTxt>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                if (dato[1].Equals(referencia))
                {
                    dato = linea.Split(';');
                    ProductoFacturaTxt productoTxt = new ProductoFacturaTxt()
                    {
                        Cantidad = int.Parse(dato[0]),
                        Referencia = dato[1],
                        Nombre = dato[2],
                        Detalle = dato[3],
                        Precio = int.Parse(dato[4]),
                    };
                    lector.Close();
                    file.Close();
                    return productoTxt;
                }
            }
            lector.Close();
            file.Close();
            return null;
        }
        public bool FiltroIdentificaicon(string referencia)
        {
            List<ProductoFacturaTxt> productoTxts = new List<ProductoFacturaTxt>();
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
        public void Modificar(ProductoFacturaTxt productoTxt, string referencia)
        {
            List<ProductoFacturaTxt> productoTxts = new List<ProductoFacturaTxt>();
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
            List<ProductoFacturaTxt> productoTxts = Consultar();
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
    }
}
