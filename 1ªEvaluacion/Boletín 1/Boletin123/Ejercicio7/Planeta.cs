using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Planeta : Astro, ITerraformable

    {
        public bool Gaseoso { set; get; }
        private int satelites;

        public int Satelites
        {
            set
            {
                satelites = value < 0 ? 0 : value;
            }
            get
            {
                return satelites;
            }
        }

        public Planeta(String nombre, double radio, bool gaseoso, int satelites) : base(nombre, radio)
        {
            this.Gaseoso = gaseoso;
            this.satelites = satelites;
        }
        public Planeta() : this("", 0, false, 0) { }

        public bool esHabitable()
        {
            return !this.Gaseoso && (base.Radio >= 2000 && base.Radio <= 8000);
            
        }
        public override string ToString()
        {
            return String.Format("{0,10} {1,4} {2,8:F2}", base.Nombre, satelites, base.Radio);
        }

        public static Planeta operator ++(Planeta p1)
        {
            p1.satelites++;
            return p1;
        }
        public static Planeta operator --(Planeta p1)
        {
            if (p1.satelites <= 0)
            {
                return p1;
            }
            else
            {
                p1.satelites--;
                return p1;
            }
        }
    }
}