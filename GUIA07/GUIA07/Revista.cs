using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Drawing;

namespace GUIA07
{
    // Clase hija: Revista
    public class Revista : MaterialBiblioteca
    {
        public int NumeroEdicion { get; set; }
        public string MesPublicacion { get; set; }
        public Revista(string titulo, string autor, int anio, Image portada, int edicion, string mes)
            : base(titulo, autor, anio, portada)
        {
            NumeroEdicion = edicion;
            MesPublicacion = mes;
        }
        public override string ObtenerDescripcion()
        {
            return $"Revista: {Titulo} - {Autor} ({Anio}), Edición {NumeroEdicion}, Mes: {MesPublicacion}";
        }
    }
}
