using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMetodos
{
    internal class Animal
    {
        public virtual string Comunicarse() // virtual => se puede hacer un override y sobreescribir
        {
            return "Ruido ... ruido.. ";
        }
    }
}
