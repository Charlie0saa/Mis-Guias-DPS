namespace TransLogística_SV.Models
{
    public abstract class Vehiculo
    {
        //{punto 3.1}

        //propiedades
        public string Placa { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Anio { get; set; }
        public double Kilometraje { get; set; } 
        
        //Propiedad abtracta
        public abstract string TipoVehiculo { get; }

        //Metodo abstracto
        public abstract double CalcularCostoMantenimiento();

        //Metodo virtual
        public virtual string ObtenerResumen()
        {
            return $"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Kilometraje: {Kilometraje}";
        }


    }
}
