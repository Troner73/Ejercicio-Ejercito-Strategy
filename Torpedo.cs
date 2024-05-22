using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Torpedo : IUnidad
    {
        public string Nombre { get; set; } = "Torpedo";
        public IVelocible velocidad { get; set; } = new VelocidadAlta();
        public IBlindable blindable { get; set; } = new BlindajePesado();
        public IPotenciable PotenciaFuego { get; set; } = new PotenciaAlta();
        public int Precio { get; set; } = 1350;
    }
}