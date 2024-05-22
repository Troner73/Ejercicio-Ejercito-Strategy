using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class TanqueAtaque : IUnidad
    {
        public string Nombre { get; set; } = "Tanque Ataque";
        public IVelocible velocidad { get; set; } = new VelocidadBaja();
        public IBlindable blindable { get; set; } = new BlindajeContrachapado();
        public IPotenciable PotenciaFuego { get; set; } = new PotenciaAlta();
        public int Precio { get; set; } = 15600;

        
    }
}