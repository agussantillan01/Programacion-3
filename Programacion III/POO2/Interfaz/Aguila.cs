using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Aguila : AnimalSalvaje, puedeVolar
    {
        public string volar()
        {
            return "Vuela como un aguila!";
        }
    }
}
