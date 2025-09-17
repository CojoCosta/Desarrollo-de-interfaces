namespace Ejercicio5
{
    internal class Program
    {
        static bool factorial(ref int numero)
        {
            int acu = numero;
            for (int i = acu - 1; i > 0; i--)
            {
                acu *= i;
            }
            return numero < 0 || numero > 10 ? false : true;

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
            int a = 5;
            Console.WriteLine(factorial(ref a));
            dibujarAsteriscos();
            Console.ReadLine();


        }
    }
}