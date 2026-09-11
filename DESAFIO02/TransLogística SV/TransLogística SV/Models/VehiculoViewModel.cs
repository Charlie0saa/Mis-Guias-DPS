using System;
using System.ComponentModel.DataAnnotations;

namespace TransLogística_SV.Models
{
    //clase para mandar datos al formulario de vistas
    public class VehiculoViewModel
    {
        //Almacena que tipo de vehiculo selecciono el monger
        public String TipoSeleccionado { get; set; } = "Automovil";

        //----------------------------------------------------------------------

        //atributos
        [Required(ErrorMessage = "La placa es obligatoria.")]
        public string Placa { get; set; } = string.Empty;

        //----------------------------------------------------------------------
         
        [Required(ErrorMessage = "La marca es obligatoria.")]
        public string Marca { get; set; } = string.Empty;

        //----------------------------------------------------------------------

        [Required(ErrorMessage = "El modelo es obligatorio.")]
        public string Modelo { get; set; } = string.Empty;

        //----------------------------------------------------------------------

        [Range(1990, 2026, ErrorMessage = "El año debe estar entre 1990 y 2026.")]
        public int Anio { get; set; } = System.DateTime.Now.Year;

        //----------------------------------------------------------------------

        [Range(0, 2000000, ErrorMessage = "El kilometraje debe estar entre 0 y 2,000,000 km.")]
        public double Kilometraje { get; set; }

        //----------------------------------------------------------------------

        public bool TienePropulsionJet { get; set; } = true;

        //----------------------------------------------------------------------

        //Atributos especificos de cada tipo de vehiculo

        public double CapacidadCargaToneladas { get; set; } // Para Camión

        //----------------------------------------------------------------------

        public string TipoCombustible { get; set; } = "Regular"; // Para Automóvil

        //----------------------------------------------------------------------

        public int Cilindraje { get; set; } // Para Motocicleta
    }
}
