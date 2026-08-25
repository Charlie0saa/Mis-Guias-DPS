using System;
using System.Collections.Generic;
using System.IO;

namespace GestorTareas
{
    /// <summary>
    /// Encapsula la lectura y escritura de tareas en un archivo de texto (.csv),
    /// usando StreamReader / StreamWriter, con manejo de errores de E/S.
    /// </summary>
    public class TareaRepositorio
    {
        private readonly string _rutaArchivo;

        public TareaRepositorio(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }

        /// <summary>
        /// Carga todas las tareas desde el archivo. Si el archivo no existe,
        /// retorna una lista vacía (primer uso del programa).
        /// Las líneas corruptas se omiten y se reportan, sin detener la carga.
        /// </summary>
        public List<Tarea> Cargar()
        {
            var tareas = new List<Tarea>();

            if (!File.Exists(_rutaArchivo))
            {
                return tareas; // No hay datos previos todavía.
            }

            StreamReader? lector = null;
            try
            {
                lector = new StreamReader(_rutaArchivo);
                string? linea;
                int numeroLinea = 0;

                while ((linea = lector.ReadLine()) != null)
                {
                    numeroLinea++;
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    try
                    {
                        tareas.Add(Tarea.FromLineaArchivo(linea));
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Aviso: se omitió la línea {numeroLinea} del archivo por formato inválido ({ex.Message}).");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S al leer el archivo de tareas: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"No se tienen permisos para leer el archivo de tareas: {ex.Message}");
            }
            finally
            {
                lector?.Close();
            }

            return tareas;
        }

        /// <summary>
        /// Guarda (sobrescribe) todas las tareas en el archivo.
        /// Se llama luego de cada operación de agregar, completar o eliminar.
        /// </summary>
        public void Guardar(List<Tarea> tareas)
        {
            StreamWriter? escritor = null;
            try
            {
                escritor = new StreamWriter(_rutaArchivo, append: false);
                foreach (Tarea tarea in tareas)
                {
                    escritor.WriteLine(tarea.ToLineaArchivo());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S al guardar el archivo de tareas: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"No se tienen permisos para escribir el archivo de tareas: {ex.Message}");
            }
            finally
            {
                escritor?.Close();
            }
        }
    }
}
