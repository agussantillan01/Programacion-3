﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMetodos
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }
        public override string ToString()
        {
            return "Animal domestico: "+ Nombre;
        }

    }
}
