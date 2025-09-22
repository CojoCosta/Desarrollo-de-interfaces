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
                nombre = String.Format("\"%s\"", value.ToUpper());//TODO separar set/get
            }
            get
            {
                return nombre;
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
        public Astro()//TODO llamar al otro ctor
        {
            this.nombre = "Tierra";
            this.radio = 6378;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Astro)//TODO comparar nombres
            {
                return this.Equals(obj);
            }
            else if (obj is String)
            {
                return this.nombre.Equals(obj);//TODO ==
            }
            else
            {
                return false;
            }
        }
    }
}
