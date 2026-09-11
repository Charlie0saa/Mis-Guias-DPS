using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TAREA_EXTRA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Donde esta la base de datos
            string cadena = "Server=DESKTOP-S9N1VV4\\SQLEXPRESS;" +
                 "Database=DSP_AA260854;" +
                 "Trusted_Connection=True;" +
                 "TrustServerCertificate=True;";

            
            Console.Write("Ingrese la carrera a consultar: ");
            string carrera = Console.ReadLine();

            
            string sql = "SELECT Nombre, Carrera, Promedio " +
                         "FROM Estudiantes " +
                         "WHERE Carrera = @carrera " +
                         "ORDER BY Promedio DESC";

            
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();

                
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    
                    comando.Parameters.AddWithValue("@carrera", carrera);

                   
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        Console.WriteLine($"\n--- ESTUDIANTES DE {carrera.ToUpper()} ---\n");

                        int contador = 0;

                        
                        while (lector.Read())
                        {
                            string nombre = lector.GetString(0);
                            string carreraFila = lector.GetString(1);
                            decimal promedio = lector.GetDecimal(2);

                            Console.WriteLine($"{nombre,-15} {carreraFila,-12} {promedio}");
                            contador++;
                        }

                        
                        Console.WriteLine($"\n{contador} estudiante(s) encontrado(s).");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}