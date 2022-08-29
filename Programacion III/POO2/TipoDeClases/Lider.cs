using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeClases
{
    static class Lider
    {
        //Esta clase no puede heredar de otras
        //No pueden heredar de ella 
        //No se puede instanciar en el program.cs
        //Pero se pude usar desde el program.cs

        public static string Saludar()
        {
            return "Hola desde clase static Lider!";

        }
    }
}
