using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA07
{
    public class UsuarioBiblioteca
    {
        public string Nombre { get; set; }
        public string Carnet { get; set; }
        public UsuarioBiblioteca(string nombre, string carnet)
        {
            Nombre = nombre;
            Carnet = carnet;
        }
        public override string ToString()
        {
            return $"{Nombre} ({Carnet})";
        }
    }
}
