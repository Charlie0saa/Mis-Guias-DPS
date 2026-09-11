namespace TransLogística_SV.Models
{
    //{punto 3.2}
    public class Automovil : Vehiculo
    {
        //Atributo
        public String TipoCombustible { get; set; } = "Regular";
        //name del tipe de vehicule
        public override string TipoVehiculo => "Automóvil";

        //POLIMORFISMO:
        public override double CalcularCostoMantenimiento()
        {
            double costoBase = 200.0;
            if (TipoCombustible.Equals("Premium", System.StringComparison.OrdinalIgnoreCase))
            {
                costoBase += 75.0; // Recargo por combustible premium
            }
            return costoBase;
        }
    }
}
