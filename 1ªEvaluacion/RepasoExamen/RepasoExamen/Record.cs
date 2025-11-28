using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen
{
    internal class Record
    {
        public string Nombre { set; get; }
        public int Puntuacion { set; get; }
        private int edad;

        public int Edad
        {
            set
            {
                edad = value < 0 ? throw new ArgumentException(): value;
            }
            get
            {
                return edad;
            }
        }
        public Record(string nombre, int puntuacion, int edad)
        {
            Nombre = nombre;
            Puntuacion = puntuacion;
            Edad = edad;
        }
        public override string ToString()
        {
            return String.Format($"Nombre: {Nombre}, Edad: {Edad}, Puntuación: {Puntuacion}");
        }
    }
}
