using System.Reflection;

namespace Ejercicio7
{
    public class Ejercicio7y8
    {
        static Planeta planeta1;
        static Cometa cometa1;
        static List<Astro> astros = new List<Astro>();
        static bool flag = true;

        public static int pedirEntero()
        {
            int numero;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out numero);
                if (numero >= 0)
                {
                    return numero;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Numero entero");
                }
            } while (!flag);
            return numero;
        }

        public static double pedirDouble()
        {
            double numero;
            do
            {
                flag = double.TryParse(Console.ReadLine(), out numero);
                if (numero > 0)
                {
                    return numero;
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Numero decimal");
                }
            } while (!flag);
            return numero;
        }

        public static bool siNo()
        {
            int opcion;
            Console.WriteLine("Sí: 1 || No: cualquier valor");
            opcion = pedirEntero();
            return (opcion == 1);

        }

        public static void añadirPlaneta()
        {
            planeta1 = new Planeta();
            Console.WriteLine("Cual es el nombre del planeta¿?");
            planeta1.Nombre = Console.ReadLine();

            Console.WriteLine("Cuantas lunas tiene¿?");
            planeta1.Satelites = pedirEntero();

            Console.WriteLine("Cual es el radio del planeta¿?");
            planeta1.Radio = pedirDouble();

            Console.WriteLine("Es gaseoso¿?(Sí: 1 || No: 2)");
            planeta1.Gaseoso = siNo();

            astros.Add(planeta1);
        }

        public static void añadirCometa()
        {
            cometa1 = new Cometa();
            Console.WriteLine("Cual es el nombre del cometa¿?");
            cometa1.Nombre = Console.ReadLine();

            Console.WriteLine("Cual es el radio del cometa¿?");
            cometa1.Radio = pedirDouble();

            astros.Add(cometa1);
        }

        public static void mostraDatos()
        {
            for (int i = 0; i < astros.Count; i++)
            {
                if (astros[i].GetType() == typeof(Planeta))
                {
                    Console.WriteLine(astros[i].ToString());

                }
                else if (astros[i].GetType() == typeof(Cometa))
                {
                    Console.WriteLine("Nombre: {0}", astros[i].Nombre);
                    Console.WriteLine("Radio: {0,4:F2}", astros[i].Radio);
                }
                if (((ITerraformable)astros[i]).esHabitable())
                {
                    Console.WriteLine("Es terraformable");
                }
                else
                {
                    Console.WriteLine("No es terraformable");
                }
            }
        }

        public static void incrementaDecrementa()
        {
            Planeta planeta2 = new Planeta();
            Console.WriteLine("Nombre del planeta");
            planeta2.Nombre = Console.ReadLine();
            for (int i = 0; i < astros.Count; i++)
            {
                if (astros.IndexOf(planeta1) == i)
                {
                    if (astros[i].Nombre == planeta2.Nombre && astros[i].GetType() == typeof(Planeta))
                    {
                        Console.WriteLine("Pulse 1 para incrementar un satelite o cualquier tecla para decementar");
                        if (siNo())
                        {
                            planeta1++;
                        }
                        else
                        {
                            planeta1--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Planeta no existente");
                }
            }
        }

        public static void eliminarNoTerraformables()
        {
            for (int i = astros.Count - 1; i >= 0; i--)
            {
                if (!((ITerraformable)astros[i]).esHabitable())
                {
                    astros.Remove(astros[i]);
                }
            }
            Console.WriteLine("Eliminados los no terraformables");
        }

        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("1.- Añadir planeta.");
                Console.WriteLine("2.- Añadir cometa.");
                Console.WriteLine("3.- Mostrar datos.");
                Console.WriteLine("4.- Incrementa/Decrementa nº de satelites.");
                Console.WriteLine("5.- Eliminar no terraformables.");
                Console.WriteLine("6.- Salir");
                option = pedirEntero();

                switch (option)
                {
                    case 1:
                        añadirPlaneta();
                        break;

                    case 2:
                        añadirCometa();
                        break;
                    case 3:
                        mostraDatos();

                        break;
                    case 4:
                        incrementaDecrementa();
                        break;
                    case 5:
                        eliminarNoTerraformables();
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
