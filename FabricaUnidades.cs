using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public abstract class FabricaUnidades
    {
        public static IUnidad CrearUnidad(string tipo)
        {
            switch (tipo)
            {
                case "Transporte":
                    return CrearTransporte();
                case "TanqueAtaque":
                    return CrearTanqueAtaque();
                case "TransporteRapido":
                    return CrearTransporteRapido();
                case "Sanitario":
                    return CrearSanitario();
                case "Antiaereo":
                    return CrearAntiaereo();
                case "Torpedo":
                    return CrearTorpedo();
                case "Canion":
                    return CrearCanion();
                case "Infanteria":
                    return CrearInfanteria();
                case "Ametrallador":
                    return CrearAmetrallador();
                default:
                    throw new Exception("Tipo de unidad militar no válida.");
            }
        }

        protected static IUnidad CrearTransporte()
        {
            return new Transporte();
        }

        protected static IUnidad CrearTanqueAtaque()
        {
            return new TanqueAtaque();
        }

        protected static IUnidad CrearTransporteRapido()
        {
            return new TransporteRapido();
        }

        protected static IUnidad CrearSanitario()
        {
            return new Sanitario();
        }

        protected static IUnidad CrearAntiaereo()
        {
            return new Antiaereo();
        }

        protected static IUnidad CrearTorpedo()
        {
            return new Torpedo();
        }

        protected static IUnidad CrearCanion()
        {

            return new Canion();
        }

        protected static IUnidad CrearInfanteria()
        {
            return new Infanteria();
        }

        protected static IUnidad CrearAmetrallador()
        {
            return new Ametrallador();
        }
    }
}