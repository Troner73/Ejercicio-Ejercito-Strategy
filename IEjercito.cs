using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    
     public interface IEjercito
    {
        void AgregarUnidad(IUnidad unidad);
        int NumUnidades();
        double PotenciaFuegoTotal();
        double BlindajeTotal();
        double CapacidadMovimiento();
        double DineroGastado();
        double CapacidadMilitar();
    }
}