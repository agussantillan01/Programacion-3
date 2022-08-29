using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociacion
{
    internal class Auto : Vehiculo
    {

        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public Auto()
        {
            chasis = new Chasis();

        }
        //Creo una variable de tipo Chasis, es decir, creo un obj de una clase(Chasis) dentro de otra clase(Auto).
        //Composicion
        public Chasis chasis { get;} // es asociacion por composicion, porque para armar el auto debe haber si o si
                                     // un chasis (por eso el constructor).
                                     // No se puede cambiar el chasis... por lo menos desde el exterior







        //Creo una variable de tipo motor, es decir, creo un obj de una clase dentro de otra clase.
        //Agregacion
        public Motor motor { get; set; } // es asociacion por agregacion, porque el motor es algo que se puede agregar
                                      // despues al auto. No necesariamente a la hora de armar el auto, tiene q tener
                                      // un motor
                                      


    }
}
