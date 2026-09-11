using System;
using System.Globalization;

namespace GestorTareas
{
    /// <summary>
    /// Representa el estado en el que puede encontrarse una tarea.
    /// </summary>
    public enum EstadoTarea
    {
        Pendiente,
        Completada
    }

    /// <summary>
    /// Clase que modela una tarea del gestor de pendientes.
    /// Aplica encapsulamiento mediante propiedades con validación básica.
    /// </summary>
    public class Tarea
    {
        // Formato usado para persistir y mostrar fechas de forma consistente.
        public const string FormatoFecha = "yyyy-MM-dd";

        // Separador usado al guardar en el archivo de texto (CSV simple).
        public const char Separador = ';';

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public EstadoTarea Estado { get; set; }

        public Tarea(int id, string titulo, string descripcion, DateTime fecha, EstadoTarea estado = EstadoTarea.Pendiente)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Fecha = fecha;
            Estado = estado;
        }

        /// <summary>
        /// Convierte la tarea a una línea de texto lista para escribir en el archivo.
        /// Se reemplaza el separador dentro de los campos para no romper el formato.
        /// </summary>
        public string ToLineaArchivo()
        {
            string tituloSeguro = Titulo.Replace(Separador, ',');
            string descripcionSeguro = Descripcion.Replace(Separador, ',');
            return string.Join(Separador,
                Id.ToString(CultureInfo.InvariantCulture),
                tituloSeguro,
                descripcionSeguro,
                Fecha.ToString(FormatoFecha, CultureInfo.InvariantCulture),
                Estado.ToString());
        }

        /// <summary>
        /// Reconstruye una Tarea a partir de una línea leída del archivo.
        /// Lanza FormatException si la línea está corrupta o incompleta.
        /// </summary>
        public static Tarea FromLineaArchivo(string linea)
        {
            string[] partes = linea.Split(Separador);
            if (partes.Length != 5)
            {
                throw new FormatException($"La línea no tiene el formato esperado (5 campos): '{linea}'");
            }

            int id = int.Parse(partes[0], CultureInfo.InvariantCulture);
            string titulo = partes[1];
            string descripcion = partes[2];
            DateTime fecha = DateTime.ParseExact(partes[3], FormatoFecha, CultureInfo.InvariantCulture);
            EstadoTarea estado = (EstadoTarea)Enum.Parse(typeof(EstadoTarea), partes[4]);

            return new Tarea(id, titulo, descripcion, fecha, estado);
        }

        public override string ToString()
        {
            string estadoTexto = Estado == EstadoTarea.Completada ? "Completada" : "Pendiente";
            return $"[{Id}] {Titulo} | {Descripcion} | Fecha: {Fecha.ToString(FormatoFecha)} | Estado: {estadoTexto}";
        }
    }
}
