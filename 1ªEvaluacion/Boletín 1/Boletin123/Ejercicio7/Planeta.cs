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
        private bool Gaseoso { set; get; }
        private int satelites;

        //public bool Gaseoso
        //{
        //    set
        //    {
        //        gaseoso = value;
        //    }
        //    get
        //    {
        //        return gaseoso;
        //    }
        //}
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
        public Planeta() : base("", 0)//T
        {
            this.Gaseoso = false;
            this.satelites = 0;
        }

        public bool esHabitable()
        {
            if (!this.Gaseoso && (base.Radio >= 2000 && base.Radio <= 8000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return String.Format("{0,10} {1,4} {0,8:F2}", base.Nombre, satelites, base.Radio);
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