using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Persona
    {
        // PROPIEDAD
        private int edad;
        private int sueldo;
        private string nombre;

        //METODOS
        //SETS
        public void setEdad(int e)
        {
         edad = e;
        }
        public void setSueldo(int s)
        {
            sueldo = s;
        }
        public void setNombre(string n)
        {
            nombre = n;
        }
        //GETS  
        public int getEdad()
        {
            return edad;
        }
        public float getSueldo()
        {
            return sueldo;
        }
        public string getNombre()
        {
            return nombre;
        }
    }

}