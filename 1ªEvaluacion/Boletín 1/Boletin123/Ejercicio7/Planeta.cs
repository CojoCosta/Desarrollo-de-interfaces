using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Planeta : Astro , ITerraformable

    {
        private bool gaseoso
        {
            set
            {
                gaseoso = value;
            }
            get
            {
                return gaseoso;
            }
        }
        public int satelites
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
            this.gaseoso = gaseoso;
            this.satelites = satelites;
        }
        public Planeta() : base("", 0)
        {
            this.gaseoso = false;
            this.satelites = 0;
        }

        public bool esHabitable() : base(radio)
        {
            if (!this.gaseoso && (radio >= 2000 && radio <= 8000))
            {
                return true;
            }
            else
            {
                return false;
            }
                throw new NotImplementedException();
        }
    }
}
