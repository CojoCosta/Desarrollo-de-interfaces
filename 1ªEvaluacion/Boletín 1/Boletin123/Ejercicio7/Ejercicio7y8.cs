using System.Reflection;

namespace Ejercicio7
{
    public class Ejercicio7y8
    {
        static void Main(string[] args)
        {
            int option = 0;
            bool flag = true;
            Planeta planeta1 = new Planeta();
            List<Astro> astros = new List<Astro>();
            do
            {


                Console.WriteLine("1.- Añadir planeta.");
                Console.WriteLine("2.- Añadir cometa.");
                Console.WriteLine("3.- Mostrar datos.");
                Console.WriteLine("4.- Incrementa/Decrementa nº de satelites.");
                Console.WriteLine("5.- Eliminar no terraformables.");
                Console.WriteLine("6.- Salir");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Escribe un numero.");
                }
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Cual es el nombre del planeta¿?");
                        planeta1.Nombre = Console.ReadLine();

                        do
                        {
                            double radio;
                            Console.WriteLine("Cual es el radio del planeta¿?");
                            flag = double.TryParse(Console.ReadLine(), out radio);
                            if (!flag)
                            {
                                Console.WriteLine("Eso no es un nº decimal, vuelve a intentarlo");
                            }
                        }
                        while (!flag);

                        do
                        {
                            int lunas;
                            Console.WriteLine("Cuantas lunas tiene¿?");
                            flag = int.TryParse(Console.ReadLine(), out lunas);
                            if (!flag)
                            {
                                Console.WriteLine("Eso no es un nº entero, vuelve a intentarlo");
                            }
                        }
                        while (!flag);

                        Console.WriteLine("Es gaseoso¿?");
                        planeta1.Gaseoso = bool.Parse(Console.ReadLine());
                        astros.Add(planeta1);
                        break;

                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;

                    case 6:
                        Console.WriteLine("Gracias por usar el programa.");
                        break;

                }
            }
            while (option != 6);
        }
    }
}
