using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Venta
    {
        //Codigo Articulo   
        //Cantidad 
        //Codigo Cliente (1 a 100)
        public int CodigoArticulo  { get; set; }
        public int Cantidad { get; set; }
        private int codCliente;
        public int CodigoCliente
        {
            get { return codCliente; }
            set 
            { 
                if (codCliente >0 && codCliente < 100)
                {
                    codCliente = value;
                }
                else
                {
                    codCliente = -1;
                }
            }
        }

    }
}
