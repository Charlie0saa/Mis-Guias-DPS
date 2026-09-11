using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Drawing;

namespace GUIA07
{   
        // Clase base
        public abstract class MaterialBiblioteca
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Anio { get; set; }
            public Image Portada { get; set; }
            public bool Prestado { get; private set; }
            public UsuarioBiblioteca UsuarioPrestamo { get; private set; }
            public MaterialBiblioteca(string titulo, string autor, int anio, Image portada)
            {
                Titulo = titulo;
                Autor = autor;
                Anio = anio;
                Portada = portada;
                Prestado = false;
            }
            public void AsignarPrestamo(UsuarioBiblioteca usuario)
            {
                if (usuario == null)
                    throw new ArgumentNullException(nameof(usuario));
                if (Prestado)
                    throw new InvalidOperationException("El material ya se encuentra prestado.");
                Prestado = true;
                UsuarioPrestamo = usuario;
            }
            public void Devolver()
            {
                Prestado = false;
                UsuarioPrestamo = null;
            }
            public abstract string ObtenerDescripcion();
            public string ObtenerEstado()
            {
                if (Prestado && UsuarioPrestamo != null)
                    return $"Prestado a {UsuarioPrestamo.Nombre}";
                return "Disponible";
            }

            public override string ToString()
            {
                return Titulo;
            }
        }
    
}
