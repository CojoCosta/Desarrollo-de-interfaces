using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class GestorMatriz
    {
        public int[][] Matriz { set; get; }

        public GestorMatriz(int filas, int columnas)
        {
            _ = Matriz[filas][columnas];
        }

        public GestorMatriz() : this(3, 4) { }


        
    }
}
