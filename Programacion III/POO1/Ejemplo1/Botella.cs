using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Botella
    {

        private int capacidad;
        private string material;
        private string color;

        //PROPIEDAD
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }


    }
}
