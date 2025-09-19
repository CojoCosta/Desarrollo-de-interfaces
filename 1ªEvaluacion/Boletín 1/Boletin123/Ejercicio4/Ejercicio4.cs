namespace Ejercicio4
{
    internal class Ejercicio4
    {
        public static bool bisiesto(int año)//REvisar
        {
            return (año % 4 == 0 && año % 100 != 0) ||  año % 400 == 0  ;
        }
        public static int? sumaRango(int n1, int n2)
        {
            if (n1 < n2)
            {
                int acu = n1;
                for (int i = n1; i <= n2; i++)
                {
                    acu += i;
                }
                return acu;
            }
            else
            {
                return null;
            }
        }
        static void Main(string[] args)
        {

            int option = 0;
            do
            {
                bool flag = false;
                Console.WriteLine("1.- Año bisiesto:");
                Console.WriteLine("2.- Suma de rango:");
                Console.WriteLine("3.- Ambas opciones anteriores:");
                Console.WriteLine("4.- Salir:");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
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
                            if (bisiesto(año))
                            {
                                Console.WriteLine("El año {0} es bisiesto", año);
                            }
                            else
                            {
                                Console.WriteLine("El año {0} no es bisiesto", año);
                            }
                        }
                        if (flag)
                        {
                            goto case 2;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Escribe un numero positivo menor que 10000: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe otro numero positivo menor que 10000: ");
                        int num2 = int.Parse(Console.ReadLine());
                        if (num1 <= 0 || num1 > 10000 && num2 <= 0 || num2 > 10000)
                        {
                            Console.WriteLine("Escriba un año valido");
                            goto case 2;
                        }
                        else
                        {
                            Console.WriteLine("La suma de los numeros en {0} y {1} es: {2}",num1, num2, sumaRango(num1, num2));
                        }
                        break;
                    case 3:
                        flag = true;
                        goto case 1;
                        break;

                    case 4:
                        Console.WriteLine("Gracias por usar el programa.");
                        break;

                    default:
                        Console.WriteLine("Elija una opcion entre 1 y 4");
                        break;
                }
            }
            while (option != 4);
        }
    }
}
