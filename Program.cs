using Strategy;

namespace SistemaDefensa
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercito ejercito = new Ejercito(50000);

            try
            {
                IUnidad transporte = FabricaUnidades.CrearUnidad("Transporte");
                ejercito.AgregarUnidad(transporte);

                IUnidad TanqueAtaque = FabricaUnidades.CrearUnidad("TanqueAtaque");
                ejercito.AgregarUnidad(TanqueAtaque);

                IUnidad TransporteRapido = FabricaUnidades.CrearUnidad("TransporteRapido");
                ejercito.AgregarUnidad(TransporteRapido);

                IUnidad Transporte = FabricaUnidades.CrearUnidad("InfanteriaBasica");
                ejercito.AgregarUnidad(Transporte);

                IUnidad Ametrallador = FabricaUnidades.CrearUnidad("Ametrallador");
                ejercito.AgregarUnidad(Ametrallador);

                IUnidad Sanitario = FabricaUnidades.CrearUnidad("Sanitario");
                ejercito.AgregarUnidad(Sanitario);

                IUnidad Antiaereo = FabricaUnidades.CrearUnidad("CanionAntiaereo");
                ejercito.AgregarUnidad(Antiaereo);

                IUnidad Torpedero = FabricaUnidades.CrearUnidad("TorpedoMovil");
                ejercito.AgregarUnidad(Torpedero);

                IUnidad Canon = FabricaUnidades.CrearUnidad("Canion");
                ejercito.AgregarUnidad(Canon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Console.WriteLine($"Potencia de fuego total: {ejercito.PotenciaFuegoTotal()}");
            Console.WriteLine($"Blindaje total: {ejercito.BlindajeTotal()}");
            Console.WriteLine($"Capacidad de movimiento: {ejercito.CapacidadMovimiento()}");
            Console.WriteLine($"Capacidad militar: {ejercito.CapacidadMilitar()}");
            Console.WriteLine($"Cantidad de unidades: {ejercito.NumUnidades()}");
            Console.WriteLine($"Dinero gastado: {ejercito.DineroGastado()}");
        }
    }
}
