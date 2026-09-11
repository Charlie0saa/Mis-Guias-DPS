using System;
using System.Collections.Generic;
using System.Linq;
using TransLogística_SV.Models;

namespace TransLogística_SV.Repositorio
{
    //{PARTE 3.3}
    public class VehiculoRepositorio
    {
        //DICCIONARIO PARA ALMACENAR VEHICULOS
        private static Dictionary<string, Vehiculo> _vehiculos = new Dictionary<string, Vehiculo>();

        //METODO PARA AGREGAR VEHICULOS AL DICCIONARIO
        public bool Agregar(Vehiculo v) 
        {
            //validar que v no sea nulo y que la placa no sea nula o vacía
            if (v == null || string.IsNullOrWhiteSpace(v.Placa))
            {
                return false; 
            }
            // Validar si la placa ya existe en el diccionario para evitar duplicados
            if (_vehiculos.ContainsKey(v.Placa))
            {
                return false; 
            }

            // Guardar el vehículo usando la placa como clave (Key)
            _vehiculos.Add(v.Placa, v);
            return true; // Registro exitoso

        }
        // METODO PARA OBTENER TODOS LOS VEHICULOS REGISTRADOS
        public List<Vehiculo> ObtenerTodos()
        {
            // Extrae solo los objetos Vehiculo del diccionario y los convierte en una Lista
            return _vehiculos.Values.ToList();
        }
        // METODO PARA OBTENER UN SOLO VEHICULO POR SU PLACA
        public Vehiculo ObtenerPorPlaca(string placa)
        {
            // Valida placa
            if (string.IsNullOrWhiteSpace(placa))
            {
                return null;
            }

            if (_vehiculos.ContainsKey(placa))
            {
                return _vehiculos[placa];
            }
            return null;
        }
        //METODO PARA ACTUALIZAR 
        public bool Actualizar(string placa, Vehiculo v)
        {
            // Si la placa no existe en el diccionario, no se puede actualizar
            if (!_vehiculos.ContainsKey(placa)) return false;

            // Reemplaza el objeto en esa posición de la llave
            _vehiculos[placa] = v;
            return true;
        }

        //METODO PARA ELIMINAR 
        public bool Eliminar(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa)) return false;

            // Elimina la llave y su valor del diccionario
            return _vehiculos.Remove(placa);
        }
    }
}
