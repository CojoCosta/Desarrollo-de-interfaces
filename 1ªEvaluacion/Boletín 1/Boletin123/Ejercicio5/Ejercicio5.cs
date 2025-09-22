#define OPCION
namespace Ejercicio5
{
    internal class Ejercicio5
    {
        static bool factorial(ref int numero)//TODO revisar
        {
            int acu = numero;
            if (numero >= 0 && numero <= 10)
            {

                if (numero == 0)
                {
                    acu = 1;
                }
                else
                {
                    for (int i = acu - 1; i > 0; i--)
                    {
                        acu *= i;
                    }
                }
                    return true;
            }
            else
            {
                return false;
            }



        }


        static int numRandom(int min, int max)
        {
            Random rd = new Random();
            return rd.Next(min, max);
        }

        static void dibujarAsteriscos(int numAsteriscos = 10)
        {
            for (int i = 0; i < numAsteriscos; i++)
            {
                Console.SetCursorPosition(numRandom(1, 21), numRandom(1, 11));
                Console.WriteLine("*");
            }
        }


        static void Main(string[] args)
        {
            int a = 0;//TODO directivas compilación
#if OPCION
            Console.WriteLine(factorial(ref a));
#else
            dibujarAsteriscos();
#endif
            Console.ReadLine();
        }
    }
}