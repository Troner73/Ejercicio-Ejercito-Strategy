using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    
    
    public interface IUnidad
    {
        string Nombre { get; set; }
        IVelocible velocidad { get; set; }
        IBlindable blindable { get; set; }
        IPotenciable PotenciaFuego { get; set; }
        int Precio {  get; set; }
        
    }
}