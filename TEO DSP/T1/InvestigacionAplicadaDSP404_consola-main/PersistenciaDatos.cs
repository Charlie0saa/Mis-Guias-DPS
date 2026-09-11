using System;
using System.Collections.Generic;
using System.IO;

public class PersistenciaDatos
{
    // Ruta del archivo donde se guardarán las tareas
    private readonly string _rutaArchivo;

    public PersistenciaDatos(string nombreArchivo = "tareas_guardadas.txt")
    {
        // Obtiene la ruta donde se esta ejecutando el programa
        string directorioEjecucion = AppDomain.CurrentDomain.BaseDirectory;

        // Sube 3 niveles en las carpetas para llegar a la raiz del proyecto
        string directorioRaiz = Path.GetFullPath(Path.Combine(directorioEjecucion, @"..\..\..\"));

        // Une la ruta de la raiz con el nombre del archivo
        _rutaArchivo = Path.Combine(directorioRaiz, nombreArchivo);
    }

    // Guarda la lista completa de las tareas en un archivo de texto
    // sobrescribiendo el archivo con la informacion más reciente
    public void GuardarTareas(IEnumerable<Tarea> tareas)
    {
        try
        {
            // El false indica que sobrescribirá el archivo
            using (StreamWriter sw = new StreamWriter(_rutaArchivo, false))
            {
                foreach (var tarea in tareas)
                {
                    // Guardamos el Nombre y el estado de Completada
                    string linea = $"{tarea.Nombre}|{tarea.Completada}";
                    sw.WriteLine(linea);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError al guardar las tareas: {ex.Message}");
        }
    }

    // Lee el archivo de texto y devuelve la lista de tareas guardadas
    public List<Tarea> CargarTareas()
    {
        List<Tarea> tareasCargadas = new List<Tarea>();

        // Si el archivo no existe, se devuelve una lista vacia
        if (!File.Exists(_rutaArchivo))
        {
            return tareasCargadas;
        }

        try
        {
            using (StreamReader sr = new StreamReader(_rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split('|');

                    // Se revisa que se tengan los 2 campos requeridos (Nombre y Completada)
                    if (datos.Length == 2)
                    {
                        Tarea tarea = new Tarea(datos[0])
                        {
                            Completada = bool.Parse(datos[1])
                        };

                        tareasCargadas.Add(tarea);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError cargando las tareas: {ex.Message}");
        }

        return tareasCargadas;
    }
}