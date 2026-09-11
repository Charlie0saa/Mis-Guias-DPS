namespace TransLogística_SV.Models
{
    //{punto 3.2}
    public class Motocicleta : Vehiculo
    {
        //Atributo
        public int Cilindraje { get; set; }
        //name del tipe de vehicule
        public override string TipoVehiculo => "Motocicleta";
        //POLIMORFISMO:
        public override double CalcularCostoMantenimiento()
        {
            double costoBase = 100.0;
            if (Cilindraje > 500)
            {
                costoBase += 50.0;
                
            }
            return costoBase;
        }
    }
}
