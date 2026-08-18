using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primer lote con 10 registros de productos, cada producto tiene:
            // - Código Artículo (3 dígitos no correlativos)
            // - Precio
            // - Código de Marca (1 a 10)
            // Segundo lote con las ventas de la semana. Cada venta tiene:
            // - Código Artículo
            // - Cantidad
            // - Código Cliente (1 a 100)
            // Este lote corta con Código de Cliente cero.

            Articulo[] articulos = new Articulo[10];
            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo(); // INFERIDO: no se ve con claridad en el video; sin esto el vector queda en null
                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Código: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10)");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }
            // cargado el vector completo con los 10
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Código de Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Código Articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());
                // trabajamos....
                // pido cliente nuevamente:
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Código de Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
