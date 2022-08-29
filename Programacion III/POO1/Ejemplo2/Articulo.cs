using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        //Codigo Articulo (3 digitos no correlativos)
        //Precio 
        //Codigo de marca (1 a 10)
        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }
        int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (codMarca > 0 && codMarca < 11)
                {
                    codMarca = value;
                }
                else
                {
                    codMarca = -1;

                }
            }
        }
            
        

    }
}
