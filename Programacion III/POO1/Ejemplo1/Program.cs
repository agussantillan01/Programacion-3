using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.setEdad(21);
            Console.WriteLine("La edad de la persona es de " + p1.getEdad());
            
            Botella b1 = new Botella();
            b1.Capacidad = 200; //Lo seteo como si fuese una variable 
            Console.WriteLine("La capacidad de la botella es de " + b1.Capacidad);

            Perro perro1 = new Perro();
            perro1.Color = "Blanco";
            Console.WriteLine("El color del perro es " + perro1.Color);
            perro1.Ladrar();
            
            Console.ReadKey();
            

            
        }
    }
}
