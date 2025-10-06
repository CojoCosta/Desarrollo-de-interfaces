using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio10
{
    public class GestorMatriz
    {
        public int[,] Matriz { set; get; }

        public GestorMatriz(int filas, int columnas)
        {
            Matriz = new int[filas, columnas];
            Random rd = new Random();
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = rd.Next(-5, 21);
                }
            }
        }

        public GestorMatriz() : this(3, 4) { }
        //c) Método SumaFila: se le pasa un parámetros entero y devuelve una tupla con un entero y un booleano.El booleano devuelve true si el parámetro es un índice válido y false si no lo es. En caso de índice válido el entero devuelto es la suma de los elementos de la fila.Si no devuelve 0.
        public (int, bool) SumaFila(int numeroFila)
        {
            int acu = 0;
            if (numeroFila < Matriz.GetLength(0) && numeroFila >= 0)
            {
                for (int i = 0; i < Matriz.GetLength(1); i++)
                {
                    acu += Matriz[numeroFila, i];
                }
                return (acu, true);
            }
            else
            {
                return (0, false);
            }
        }

        //d) Método SumaColumna.Se le pasa una parámetro entero que representa una columna y tendrá otro parámetro por referencia pero de salida (out) donde devuelve el resultado de la suma de los elementos de la columna.Devolverá true si el índice es correcto o false si no lo es.
        public bool SumaColumna(int numeroColumna, out int resultadoSuma)
        {
            resultadoSuma = 0;
            if (numeroColumna < Matriz.GetLength(1) && numeroColumna >= 0)
            {
                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    resultadoSuma += Matriz[i, numeroColumna];
                }
                return true;
            }
            return false;
        }

        //e) Método SumaMatriz: tiene como parámetro un object. Si el object es un array bidimensional de int o double o un objeto del tipo GestorMatriz y es del mismo tamaño que Matriz, se suma elemento a elemento y el resultado se devuelve.En otro caso lanza una excepción creada por ti denominada MatrizException.
        public int SumaMatriz(object obj)
        {
            int acu = 0;
            if (obj.GetType() == typeof(int[,]) || obj.GetType() == typeof(double[,]) || obj.GetType() == typeof(GestorMatriz))
            {
                if (obj.GetType().GetArrayRank() == Matriz.GetLength(0))
                {
                    for (int i = 0; i < Matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matriz.GetLength(1); j++)
                        {
                            acu += Matriz[i, j];
                        }
                    }
                }
                return acu;
            }
            else
            {
                throw new MatrizException("El objeto no es una matriz");
            }
        }

        //f ) Método medias: Tiene un parámetro booleano.Si es true devuelve un vector de doubles con la media de cada una de las filas. Si es false devuelve un vector de doubles con la media de cada una de las columnas.
        public double[] Medias(bool flag)
        {
            int acu = 0;
            double[] mediasFilas = new double[Matriz.GetLength(0)];
            double[] mediasColumnas = new double[Matriz.GetLength(1)];

            if (flag)
            {
                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    var intDeTupla = SumaFila(i).Item1;
                    acu += intDeTupla;
                    mediasFilas[i] += acu / Matriz.GetLength(0);
                }
                return mediasFilas;
            }
            else
            {
                for (int i = 0; i < Matriz.GetLength(1); i++)
                {
                    bool columna = SumaColumna(i, out int resultadoSuma);
                    acu += resultadoSuma;
                    mediasColumnas[i] += acu / Matriz.GetLength(0);
                }
                return mediasColumnas;
            }
        }

        //g) Método estático MostrarMatriz: Parámetro tipo array bidimensional de cualquier tipo(usa genéricos<T>). Muestra la matriz parámetro teniendo como cabeceras de filas el número de fila(empezando en 1) y como cabecera de columna una letra Unicode empezando en la A.Debe quedar todo bien alineado. Usa 5 para ancho de columna.
        public static void MostrarMatriz( int [,] bidimensional)
        {
            int cabeceraFilas = 1;
            
        }

    }
}
