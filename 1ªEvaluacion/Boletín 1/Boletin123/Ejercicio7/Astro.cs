using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public abstract class Astro
    {
        private String nombre;
        private double radio;
        public String Nombre
        {
            set
            {
                nombre = value.ToUpper();
            }
            get
            {
                return String.Format("\"{0}\"", nombre);
            }
        }
        public double Radio
        {
            set
            {
                radio = value > 0 ? value : throw new ArgumentException(); ;
            }
            get
            {
                return radio;
            }
        }


        public Astro(String nombre, double radio)
        {
            this.nombre = nombre;
            this.radio = radio;
        }
        public Astro() : this("Tierra", 6378) { }

        public override bool Equals(object? obj)
        {
            if (obj is Astro astro)
            {
                return this.Nombre == astro.Nombre;
            }
            else if (obj is String str)
            {
                return this.Nombre == str.ToUpper() ;
            }
            else
            {
                return false;
            }
        }
    }
}
