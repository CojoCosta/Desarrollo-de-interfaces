using System.Security.Cryptography.X509Certificates;

namespace Receta
{
    public class Receta
    {
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public int Tiempo { set; get; }

        public Receta()
        {
            Nombre = "Ejemplo";
            Descripcion = "hacer Ej";
            Tiempo = 120;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}

