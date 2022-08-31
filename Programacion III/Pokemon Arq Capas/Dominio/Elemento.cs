using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Elemento
    {
        public int  Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()  //En "Tipo", se le envia un objeto entonces a la
        {                                  //hora de mostrar por pantalla, no sabe lo que con-
            return Descripcion;            //contiene y muestra projectPokemon.Elemento
        }                                  //Entonces con el toString convierte a string el objeto

        

    }
}
