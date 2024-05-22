using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class BlindajeLigero : IBlindable
    {
        public double Blindaje { get; set; }

        public BlindajeLigero(double blindaje)
        {
            Blindaje = blindaje;
        }

        public BlindajeLigero()
        {
        }
    }
}