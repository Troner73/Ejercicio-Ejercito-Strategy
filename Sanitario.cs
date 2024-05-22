using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Sanitario : IUnidad
    {
        public string Nombre { get; set; } = "Sanitario";
        public IVelocible velocidad { get; set; } = new VelocidadBaja();
        public  IBlindable blindable { get ; set  ; } = new BlindajeLigero();
        public IPotenciable PotenciaFuego { get ; set ; } = new PotenciaBaja();
        public int Precio { get; set; } = 500;

       
    }
}