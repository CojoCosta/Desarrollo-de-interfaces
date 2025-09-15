namespace Ejercicio4
{
    internal class Program
    {
        public static bool bisiesto(int año)
        {
            return año % 4 == 0 && año % 400 == 0 && año % 100 != 0;
        }
        static void Main(string[] args)
        {

            int option = 0;
            do
            {
                Console.WriteLine("1.- Año bisiesto:");
                Console.WriteLine("2.- Suma de rango:");
                Console.WriteLine("3.- Ambas opciones anteriores:");
                Console.WriteLine("4.- Salir:");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("Escribe un año: ");
                        Console.WriteLine("(Debe ser positivo y menor de 10000)");
                        int año = int.Parse(Console.ReadLine());
                        if (año <= 0 || año > 10000)
                        {
                            Console.WriteLine("Escriba un año valido");
                            goto case 1;
                        }
                        else
                        {
                            Console.WriteLine(bisiesto(año));
                        }

                        break;
                }
            }
            while (option != 4);
        }
    }
}
