using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Agus";
            nombre = "Hola mi nombre es " + nombre;
            Console.WriteLine(nombre);
            //Devuelve cantidad de caracteres
            int cant = nombre.Length;
            Console.WriteLine(cant);

            //Pasa a MAYUSCULA
            string mayuscula = nombre.ToUpper();
            Console.WriteLine(mayuscula);
            // Pasa a minuscula
            string minuscula = nombre.ToLower();
            Console.WriteLine(minuscula);
            //Remplaza letras o oraciones
            string remplaza = nombre.Replace('a', 'e'); //aca rempleza las letras "a" por letras "e"
            Console.WriteLine(remplaza);

;
            Console.ReadKey();
        }
    }
}
