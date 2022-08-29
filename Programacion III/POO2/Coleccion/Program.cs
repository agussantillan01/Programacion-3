using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Coleccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
          
            c1.Color = "Amarillo";
            c2.Color = "Blanco";
            c3.Color = "Negro";

            //Hace una lsita de los objetos de camioneta
            List<Camioneta> listaCamionetas= new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            //Cantidad de elementos de la lista
           Console.WriteLine("Cantidad de elementos de la listaCamionetas: "+listaCamionetas.Count);
            //Muestro el segundo elemento => como si fuese un vector 
            Console.WriteLine("Color de la segunda camioneta: " + listaCamionetas[1].Color);
            //Elimina eleemntso de la lista
            listaCamionetas.Remove(c3);
            Console.WriteLine("nueva Cantidad de elementos: " + listaCamionetas.Count);

            //Recorrer toda la lista
            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color:  "+ item.Color);
            }

            Console.ReadKey();

        }
    }
}
