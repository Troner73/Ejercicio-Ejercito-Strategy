using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Ametrallador : IUnidad
    {
        public string Nombre { get; set; } = "Ametralllador";
        public IVelocible velocidad { get ; set ; } = new VelocidadBaja();
        public IBlindable blindable { get ; set ; } = new BlindajeLigero();
        public IPotenciable PotenciaFuego { get; set; } = new PotenciaAlta();
        public int Precio { get; set; } = 400;
    }
}