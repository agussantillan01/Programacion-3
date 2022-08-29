using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Articulo[] articulos = new Articulo[10];
            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();   //Porque el vector esta vacio. 
                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Codigo Articulo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de marca: ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }
            //Crea una sola venta
            Venta ventas = new Venta();
            Console.WriteLine("Ingrese el Codigo Cliente: ");
            ventas.CodigoCliente = int.Parse(Console.ReadLine());
            while (ventas.CodigoCliente != -1)
            {
                Console.WriteLine("Codigo Articulo: ");
                ventas.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                ventas.Cantidad = int.Parse(Console.ReadLine());

            }
            Console.ReadKey();
        }
        
    }
}
