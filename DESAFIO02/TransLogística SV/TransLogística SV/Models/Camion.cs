namespace TransLogística_SV.Models
{
    //{punto 3.2}

    //herencia camion y vehiculo
    public class Camion : Vehiculo
    {
        //Atributo
        public double CapacidadCargaToneladas { get; set; } 

        //name del tipe de vehicule
        public override string TipoVehiculo => "Camión";

        //POLIMORFISMO:
        public override double CalcularCostoMantenimiento()
        {
            double costoBase = 500.0;
            double recargoPorTonelada = 50.0;
            return costoBase + (CapacidadCargaToneladas * recargoPorTonelada);
        }
        //reuso del metodo base
        public override string ObtenerResumen()
        {
            return base.ObtenerResumen() + $", Capacidad de Carga: {CapacidadCargaToneladas} toneladas";
        }
    }
}
