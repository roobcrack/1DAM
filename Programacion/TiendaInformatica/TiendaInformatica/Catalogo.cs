using System;

namespace TiendaInformatica
{
    internal class Catalogo
    {
        private Dictionary<string, ProductoInformatico> diccionario;

        public Catalogo()
        {
            diccionario = new Dictionary<string, ProductoInformatico>();
        }

        public string NuevoProducto(ProductoInformatico producto)
        {
            if (string.IsNullOrWhiteSpace(producto.GetCodigo()) ||
                string.IsNullOrWhiteSpace(producto.GetMarca()) ||
                string.IsNullOrWhiteSpace(producto.GetModelo()))
            {
                return "Error: Todos los atributos de texto deben estar llenos.";
            }

            if (producto.GetPrecio() <= 0)
            {
                return "Error: El precio debe ser mayor que 0.";
            }

            if (diccionario.ContainsKey(producto.GetCodigo()))
            {
                return "Error: El código del producto ya existe en el catálogo.";
            }

            if (producto is Perifericos)
            {
                Perifericos periferico = (Perifericos)producto;
                if (periferico.GetNombre() is Null ||
                    string.IsNullOrWhiteSpace(periferico.GetConexion()))
                {
                    return "Error: El nombre y la conexión del periférico no pueden ser nulos.";
                }
            } else if(producto is Portatiles)
            {
                Portatiles portailes = (Portatiles)producto;
                if(string.)
            }

            diccionario.Add(producto.GetCodigo(), producto);
            return "Producto añadido correctamente al catálogo.";
        }
    }
}
