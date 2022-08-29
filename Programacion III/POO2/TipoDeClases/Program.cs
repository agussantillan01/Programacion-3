using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeClases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Al tener la clase "Persona", como una clase abstracata, no podemos realizar un obj de clase Persona
            //Esto permite que solo se puedan instanciar sus clases hijas o mejor dicho, "derivadas". 
            //Persona p1 = new Persona();


            Console.WriteLine(Lider.Saludar());
            Console.ReadKey();


            

        }
    }
}
