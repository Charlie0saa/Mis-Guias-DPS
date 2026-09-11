namespace TransLogística_SV.Models
{
    public class Batimovil : Vehiculo
    {
        // Atributo específico
        public bool TienePropulsionJet { get; set; } = true;

        public override string TipoVehiculo => "Batimóvil";

        // POLIMORFISMO: Recargo de $500 si tiene jet activado
        public override double CalcularCostoMantenimiento()
        {
            double costoBase = 1500.0;
            return TienePropulsionJet ? costoBase + 500.0 : costoBase;
        }

        public override string ObtenerResumen()
        {
            string estadoJet = TienePropulsionJet ? "Activado" : "Desactivado";
            return $"{base.ObtenerResumen()} | Propulsión Jet: {estadoJet}";
        }
    }
}