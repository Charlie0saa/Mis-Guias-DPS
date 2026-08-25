using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA06
{
    internal class clsEmpleado
    {
        //-------Atributos privados--------
        private string Nombres;
        private string Apellidos;
        private DateTime FechaNacimiento;
        private int Edad;

        private DateTime FechaContratacion;
        private decimal TasaIsss;
        private decimal TasaRenta;
        private decimal SueldoBase;
        private decimal SueldoFinal;

        private bool DatosCompletos;
        private bool DatosLaboralesListos;

        private string ultimoError = String.Empty;

        ///-----------Properties publicas(Compatibilidad)----------------
        ///<summary>Apellido, Nombres</summary>
        public string nombrecompleto => $"{Apellidos}, {Nombres}";
        /// <summary>Indica si los datos personales pasaron validación</summary>
        public bool datospersonales_aceptados => DatosCompletos;
        /// <summary>Indica si los datos laborales pasaron validación</summary>
        public bool datoslaborales_aceptados => DatosLaboralesListos;
        /// <summary>Mensaje de error/resultados de la última validación</summary>
        public string UltimoError => ultimoError;


        // ---------- Constructor ----------
        public clsEmpleado()
        {
            TasaIsss = 3.0m; //valor por defecto (porcentual)
            TasaRenta = 10.0m; //valor por defecto (porcentual)
            FechaContratacion = DateTime.Now;
            DatosCompletos = false;
            DatosLaboralesListos = false;
        }

        // ---------- Métodos de validación y asignación ----------
        /// <summary>
        /// Valida y asigna los datos personales.
        /// Devuelve true si OK, false y UltimoError en caso contrario.
        /// </summary>
        public bool DefinirDatosPersonales(String nom, String apel, DateTime fechanac)
        {
            ultimoError = String.Empty;
            DatosCompletos = false;

            if (String.IsNullOrEmpty(nom))
            {
                ultimoError = "Falta ingresar nombres del empleado";
                return false;
            }
            if(String.IsNullOrWhiteSpace(apel))
            {
                ultimoError = "Falta ingresar apellidos del empleado";
                return false;
            }

            Nombres = nom.Trim();
            Apellidos = apel.Trim();

            //Calculo de edad preciso
            int edadCalculada = DateTime.Now.Year - fechanac.Year;
            if(fechanac > DateTime.Now.AddYears(-edadCalculada)) edadCalculada--;
            
            


            if (edadCalculada < 0)
            {
                ultimoError = "Fecha de nacimiento inválida";
                return false;
            }
            if (edadCalculada < 18)
            {
                ultimoError = "Persona menor de edad según código de trabajo (mínimo 18 años).";
                return false;
            }
            if (edadCalculada > 50)
            {
                ultimoError = "Persona mayor de edad según código de trabajo (máximo 65 años).";
                return false;
            }

            FechaNacimiento = fechanac;
            Edad= edadCalculada;
            DatosCompletos = true;
            return true;
            
                
            }

            

            
                /// <summary>
                /// Valida y asigna datos laborales (fecha contrato y sueldo).
                /// Devuelve true si OK y deja UltimoError si no.
                /// </summary>
                public bool DefinirDatosLaborales(DateTime fechacontrato, decimal sueldoinic)
        {
            ultimoError = String.Empty;
            DatosLaboralesListos = false;

            if (!DatosCompletos)
            {
                ultimoError = "Debe completar primero los datos personales.";
                return false;
            }
            if (sueldoinic < 0)
            {
                ultimoError = "Sueldo inicial no puede ser negativo.";
                return false;
            }

            DateTime fechaMinLaboral= FechaNacimiento.AddYears(18);
            DateTime fechaHoy = DateTime.Now;

            if (fechacontrato < fechaMinLaboral)
            {
                ultimoError = $"Fecha de contrato inválida. Debe ser >= {fechaMinLaboral:d}.";
                return false;
            }
            if (fechacontrato > fechaHoy)
            {
                ultimoError = $"Fecha de contrato inválida. No puede ser futura (hoy: {fechaHoy:d}).";
                return false;
            }
            FechaContratacion = fechacontrato;
            SueldoBase = Math.Round(sueldoinic, 2);
            DatosLaboralesListos = true;
            CalcularSueldoNeto();
            return true;
            }
        /// <summary>
        /// Asigna las tasas (porcentaje) para ISSS y Renta. Recalcula sueldo.
        /// Rango razonable: 0..40 (%)
        /// </summary>
            public void AsignarDescuentos(decimal isss = 2.50m, decimal renta = 10.50m)
            {
            if (isss >= 0m && isss <= 40m) TasaIsss = isss;
            if (renta >= 0m && renta <= 40m) TasaRenta = renta;
            CalcularSueldoNeto();

            }
        /// <summary>
        /// Retorna sueldos como cadenas formateadas (compatibilidad con código existente)
        /// </summary>
        public void VerSueldos(ref string sb, ref string sf)
        {
            sb = SueldoBase.ToString("F2", CultureInfo.CurrentCulture);
            sf = SueldoFinal.ToString("F2", CultureInfo.CurrentCulture);
        }
        // ---------- Método interno ----------
        private void CalcularSueldoNeto()
        {
            decimal descIsss = SueldoBase * (TasaIsss / 100m);
            decimal descRenta = SueldoBase * (TasaRenta / 100m);
            SueldoFinal = Math.Round(SueldoBase - descIsss - descRenta, 2);
        }
        // Para debugging/registro si se requiere
        public override string ToString() => $"{nombrecompleto} - Sueldo base: {SueldoBase:F2} Neto: {SueldoFinal:F2}";

    }
}
