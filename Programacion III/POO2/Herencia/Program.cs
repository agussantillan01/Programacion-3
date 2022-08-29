using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo > Auto > AutoUrbano > AutoDeportivo
            //Camioneta
            //Moto
            Vehiculo v1 = new Vehiculo();  //v1 tiene solamente motor 
            v1.Motor = "Motor de volkswagen";
            Camioneta c1 = new Camioneta(); //c1 tiene cantidad, pero hereda de vehiculo asi que tiene motor 
            c1.Motor = "Motor de Ford";
            c1.Cantidad = 5;

            Vehiculo v2 = new Camioneta(); // guarda un obj de tipo "Camioneta", en una variable tipo "Vehiculo"
                                           // pero cuenta solamente con las propiedades y metodos de "Vehiculo". 

            /*
            Camioneta c2 = new Vehiculo(); // MAL !!, UN OBJ DE TIPO CLASE BASE NO PUEDE GUARDARSE DENTRO DE UNA CLASE DERIVADA
            */


            
            

            Console.WriteLine(c1.Cantidad);
            Console.ReadKey();

        }
    }
}
