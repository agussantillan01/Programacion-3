using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Agustin";
            Console.WriteLine(p1.Saludar("maxi"));
          
            Console.ReadKey();
        }
    }
}
