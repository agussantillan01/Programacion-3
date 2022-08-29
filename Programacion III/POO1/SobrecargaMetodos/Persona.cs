using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodos
{
    internal class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public float Sueldo { get; set; }

        public string Saludar()
        {
            return "Hola soy " + Nombre;
        }

        //SOBRECARGA DE METODO
        public string Saludar(string Nombre) 
        {
            return "hola " + Nombre + ", soy " + this.Nombre;
                      //nombreXparametro        //nombrePropio
        }

    }


}
