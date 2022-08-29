using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En esta lsita se puede agregar animales que "sepan volar", es decir que contengan la interfaz en este caso "puedeVolar"
            List<puedeVolar> listaVoladores = new List<puedeVolar>();
            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Canario());

        }
    }
}
