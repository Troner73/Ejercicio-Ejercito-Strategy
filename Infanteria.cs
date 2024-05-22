using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Infanteria : IUnidad
    {
        public string Nombre { get; set; } = "Infanteria";
        public IVelocible velocidad { get ; set ; } = new VelocidadBaja();
        public IBlindable blindable { get ; set ; } = new BlindajeLigero();
        public IPotenciable PotenciaFuego { get ; set ; } = new PotenciaMedia();
        public int Precio { get ; set ; }

       
    }
}
    