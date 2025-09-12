namespace TemaIntroduccion
{
    internal class Program
    {
            //Ejemplo referencia
            static void suma(int a, int b, ref int c)
            {
                c = a + b; // c se puede usar para sumarlo
            }
            
            //Ejemplo Out
            static void sumaOut(int a, int b, out int c)
            {
                c = a + b; //c solo puede usarse para devolver el resultado
            }

            //Ejemplo parametros con nombre y opcionales
            static void suma10(int a, int b = 10)//Los parámetros opcionales deben ir al final de la lista de parámetros
            {
            Console.WriteLine(a + b);
            }

            //Ejemplo tuplas 
            static (int, int, int) Operaciones(int a, int b)
            {
                return (a + b, a - b, a * b);
            }
    

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // println
            Console.Write("Hola, Mundo!"); // print
            Console.WriteLine("Un \ttabulador\nlínea distinta");
            Console.WriteLine(@"Un \ttabulador\nlínea distinta"); //con @ no interpreta caracteres especiales
            /*int c = null; //error
            int? b = null; //acepta null */
            int? i = 0;
            int b = i ?? -1; //si i es null, b vale -1
            do
            {
                Console.WriteLine(i++);
            } while (i < 5);
            Console.WriteLine();
            i = 0;
            do
            {
                Console.WriteLine(++i);
            } while (i < 5);

            //Ejemplo referencia
            int res = 0; // Obligatorio inicializar res antes de pasarlo
            suma(12, 34, ref res);
            Console.WriteLine("Resultado: {0}", res);

            //Ejemplo Out
            int res1; // out indica que res se inicia dentro del método
            sumaOut(12, 34, out res1);
            Console.WriteLine("Resultado: {0}", res1);

            //Ejemplo parametros con nombre y opcionales
            suma10(3, 4);
            suma10(b: 4, a: 3);
            suma10(3);

            //Ejemplo tuplas 
            var res2 = Operaciones(1, 2);
            // En lugar de var, se puede poner (int,int,int)
            Console.WriteLine("Sum:{0,4}\nRes:{1,4}\nMul:{2,4}",
            res2.Item1, res2.Item2, res2.Item3);

        }
    }
}