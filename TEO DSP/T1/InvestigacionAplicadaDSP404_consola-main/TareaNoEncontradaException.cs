using System;

namespace GestorTareas
{
    /// <summary>
    /// Excepción personalizada que se lanza cuando se intenta operar
    /// sobre una tarea que no existe en la colección (por Id).
    /// </summary>
    public class TareaNoEncontradaException : Exception
    {
        public int IdBuscado { get; }

        public TareaNoEncontradaException(int idBuscado)
            : base($"No se encontró ninguna tarea con el Id {idBuscado}.")
        {
            IdBuscado = idBuscado;
        }

        public TareaNoEncontradaException(int idBuscado, string mensaje)
            : base(mensaje)
        {
            IdBuscado = idBuscado;
        }
    }
}
