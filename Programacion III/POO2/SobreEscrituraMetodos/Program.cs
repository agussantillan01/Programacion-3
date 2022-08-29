using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "PEPE";
            Console.WriteLine(a1.ToString());

            //*************

            Gato g1 = new Gato();
            Console.WriteLine(g1.Comunicarse());
            Tigre t1 = new Tigre();
            Console.WriteLine(t1.Comunicarse());


            Console.ReadKey();

        }
    }
}
