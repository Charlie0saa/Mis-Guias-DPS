using System;
using System.Collections.Generic;

public class Tarea
{
    public string Nombre { get; set; }
    public bool Completada { get; set; }

    public Tarea(string nombre)
    {
        Nombre = nombre;
        Completada = false;
    }
}

class Program
{
    static List<Tarea> tareas = new List<Tarea>();
    // Necesario para la clase PersistenciaDatos.cs
    static PersistenciaDatos persistencia = new PersistenciaDatos();

    static void Main(string[] args)
    {
        int opcion;

        // Necesario para cargar los Datos en la lista guardada (.txt)
        tareas = persistencia.CargarTareas();

        do
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("       GESTOR DE TAREAS");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Completar tarea");
            Console.WriteLine("4. Eliminar tarea");
            Console.WriteLine("5. Guardar lista de tareas");
            Console.WriteLine("6. Salir");
            Console.WriteLine("=================================");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarTarea();
                        break;

                    case 2:
                        ListarTareas();
                        break;

                    case 3:
                        CompletarTarea();
                        break;

                    case 4:
                        EliminarTarea();
                        break;

                    case 5:
                        GuardarListaTareas();
                        break;

                    case 6:
                        Console.WriteLine("\nPrograma finalizado. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("\nERROR: Opción no válida.");
                        Pausar();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nERROR: Debe ingresar un número.");
                Pausar();
                opcion = 0;
            }

        } while (opcion != 6);
    }

    static void AgregarTarea()
    {
        Console.Clear();

        Console.WriteLine("========== AGREGAR TAREA ==========");
        Console.Write("Ingrese el nombre de la tarea: ");

        string nombre = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("\nERROR: El nombre de la tarea no puede estar vacío.");
        }
        else
        {
            tareas.Add(new Tarea(nombre));

            Console.WriteLine("\nTarea agregada correctamente.");
        }

        Pausar();
    }

    static void ListarTareas()
    {
        Console.Clear();

        Console.WriteLine("========== LISTA DE TAREAS ==========");

        if (tareas.Count == 0)
        {
            Console.WriteLine("\nNo hay tareas registradas.");
        }
        else
        {
            for (int i = 0; i < tareas.Count; i++)
            {
                string estado;

                if (tareas[i].Completada)
                {
                    estado = "COMPLETADA";
                }
                else
                {
                    estado = "PENDIENTE";
                }

                Console.WriteLine(
                    $"{i + 1}. {tareas[i].Nombre} - {estado}"
                );
            }
        }

        Pausar();
    }

    static void CompletarTarea()
    {
        Console.Clear();

        Console.WriteLine("========== COMPLETAR TAREA ==========");

        if (tareas.Count == 0)
        {
            Console.WriteLine("\nNo hay tareas registradas.");
            Pausar();
            return;
        }

        ListarTareasSinPausa();

        Console.Write("\nIngrese el número de la tarea a completar: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 1 && numero <= tareas.Count)
            {
                if (tareas[numero - 1].Completada)
                {
                    Console.WriteLine("\nERROR: Esta tarea ya está completada.");
                }
                else
                {
                    tareas[numero - 1].Completada = true;

                    Console.WriteLine(
                        "\nTarea completada correctamente."
                    );
                }
            }
            else
            {
                Console.WriteLine("\nERROR: El número de tarea no existe.");
            }
        }
        else
        {
            Console.WriteLine("\nERROR: Debe ingresar un número válido.");
        }

        Pausar();
    }

    static void EliminarTarea()
    {
        Console.Clear();

        Console.WriteLine("========== ELIMINAR TAREA ==========");

        if (tareas.Count == 0)
        {
            Console.WriteLine("\nNo hay tareas registradas.");
            Pausar();
            return;
        }

        ListarTareasSinPausa();

        Console.Write("\nIngrese el número de la tarea a eliminar: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero >= 1 && numero <= tareas.Count)
            {
                string nombre = tareas[numero - 1].Nombre;

                tareas.RemoveAt(numero - 1);

                Console.WriteLine(
                    $"\nLa tarea \"{nombre}\" fue eliminada correctamente."
                );
            }
            else
            {
                Console.WriteLine("\nERROR: El número de tarea no existe.");
            }
        }
        else
        {
            Console.WriteLine("\nERROR: Debe ingresar un número válido.");
        }

        Pausar();
    }

    static void ListarTareasSinPausa()
    {
        for (int i = 0; i < tareas.Count; i++)
        {
            string estado = tareas[i].Completada
                ? "COMPLETADA"
                : "PENDIENTE";

            Console.WriteLine(
                $"{i + 1}. {tareas[i].Nombre} - {estado}"
            );
        }
    }

    static void Pausar()
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }

    static void GuardarListaTareas()
    {
        Console.Clear();
        Console.WriteLine("========== GUARDAR TAREAS ==========");

        // Llamada para guardar desde el menu
        persistencia.GuardarTareas(tareas);

        Console.WriteLine("\nLas tareas han sido guardadas en el archivo de texto correctamente.");
        Pausar();
    }
}
