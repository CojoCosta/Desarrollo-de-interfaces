using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Ordenador
    {
        public string Nombre { get; set; }
        private int memoriaRam;

        public int MemoriaRam
        {
            set
            {
                memoriaRam = value >= 0 ? value : 16;
            }

            get
            {
                return memoriaRam;
            }
        }


        public static bool comprobadorIPs(String ip)
        {
            String[] bytes = ip.Split(".");
            if (bytes.Length == 4)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    if (!Byte.TryParse(bytes[i], out _))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}, MemoriaRam: {MemoriaRam} ";
        }



    }
}
