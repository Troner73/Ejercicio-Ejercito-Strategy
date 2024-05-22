using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class TransporteRapido : IUnidad
    {
        public string Nombre { get; set; } = "Transporte Rapido";
        public IVelocible velocidad { get; set; } = new VelocidadAlta();
        public IBlindable blindable { get ; set ; } = new BlindajeLigero();
        public IPotenciable PotenciaFuego { get ; set ; } = new PotenciaBaja();
        public int Precio { get; set; } = 1600;
    }
}