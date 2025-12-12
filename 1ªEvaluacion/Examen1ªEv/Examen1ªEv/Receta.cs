using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1ªEv
{
    internal class Receta
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Tiempo { get; set; }
        public Receta()
        {
            Nombre = "Ejemplo";
            Descripcion = "";
            Tiempo = 0;
        }
        public Receta(string nombre, string descripcion, int tiempo) 
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Tiempo = tiempo;
        }

        public override string ToString()
        { 
            return Nombre;
        }
    }
}
