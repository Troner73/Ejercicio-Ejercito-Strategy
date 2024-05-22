using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class Ejercito : IEjercito
    {
        private List<IUnidad> unidades;
        private double fondoDisponible;

        public Ejercito(double fondoDisponible)
        {
            unidades = new List<IUnidad>();
            this.fondoDisponible = fondoDisponible;
        }

        public void AgregarUnidad(IUnidad unidad)
        {
            if (unidad.Precio <= fondoDisponible)
            {
                unidades.Add(unidad);
                fondoDisponible -= unidad.Precio;
            }
            else
            {
                throw new Exception("Presupuesto insuficiente.");
            }
        }

        public int NumUnidades()
        {
            return unidades.Count;
        }

        public double PotenciaFuegoTotal()
        {
            return unidades.Sum(u => u.PotenciaFuego.PotenciaFuego);
        }

        public double BlindajeTotal()
        {
            return unidades.Sum(u => u.blindable.Blindaje);
        }

        public double CapacidadMovimiento()
        {
            return unidades.Sum(u => u.velocidad.Velocidad);
        }

        public double DineroGastado()
        {
            return fondoDisponible;
        }

        public double CapacidadMilitar()
        {
            double potenciaFuego = PotenciaFuegoTotal();
            double capacidadMovimiento = CapacidadMovimiento();
            double blindaje = BlindajeTotal();
            return (potenciaFuego * capacidadMovimiento) / (2 * (100 - blindaje));
        }
    }
}