using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Transporte : IUnidad
    {

   
    public string Nombre { get; set; } = "MX-7899";
    public IVelocible velocidad { get; set; } = new VelocidadAlta();
    public IBlindable blindable { get; set; } = new BlindajeLigero();    
    public IPotenciable PotenciaFuego { get; set; } = new PotenciaBaja();
    public int Precio { get; set; } = 4200;

   
}
}