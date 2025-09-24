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
                if (numero > 0)
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

        public static double pedirDecimal()
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
            do
            {
                int opcion;
                Console.WriteLine("Sí: 1 || No: 2");
                opcion = pedirEntero();
                if (opcion == 1)
                {
                    return true;
                }
                else if (opcion == 2)
                {
                    return false;
                }
                else
                {
                    return flag = false;
                    flag = false;
                }
            } while (!flag);
        }

        public static void añadirPlaneta()
        {
            planeta1 = new Planeta();
            Console.WriteLine("Cual es el nombre del planeta¿?");
            planeta1.Nombre = Console.ReadLine();

            Console.WriteLine("Cuantas lunas tiene¿?");
            planeta1.Satelites = pedirEntero();

            Console.WriteLine("Cual es el radio del planeta¿?");
            planeta1.Radio = pedirDecimal();

            Console.WriteLine("Es gaseoso¿?(Sí: 1 || No: 2)");
            planeta1.Gaseoso = siNo();

            astros.Add(planeta1);
        }

        public static void añadirCometa()
        {
            cometa1 = new Cometa();
            Console.WriteLine("Cual es el nombre del cometa¿?");
            cometa1.Nombre = Console.ReadLine();

            double radio;
            Console.WriteLine("Cual es el radio del cometa¿?");
            radio = pedirDecimal();
        }

        public static void mostraDatos()
        {
            for (int i = 0; i < astros.Count; i++)
            {
                if (astros[i].GetType() == typeof(Planeta))
                {
                    Console.WriteLine(astros[i].ToString());
                    if (((Planeta)astros[i]).esHabitable())
                    {
                        Console.WriteLine("Es terraformable");
                    }
                    else
                    {
                        Console.WriteLine("No es terraformable");
                    }
                }
                else if (astros[i].GetType() == typeof(Cometa))
                {
                    Console.WriteLine("Nombre: {0}", astros[i].Nombre);
                    Console.WriteLine("Radio: {0,4:F2}", astros[i].Radio);
                    if (((Cometa)astros[i]).esHabitable())
                    {
                        Console.WriteLine("Es terraformable");
                    }
                    else
                    {
                        Console.WriteLine("No es terraformable");
                    }
                }
            }
        }

        public static void incrementaDecrementa()
        {
            int n;
            Console.WriteLine("Nombre del planeta");
            String nombre = Console.ReadLine();
            Planeta p1 = new Planeta();
            p1.Nombre = nombre;
            if (astros.IndexOf((Astro)p1).GetType() == typeof(Planeta))
            {
                do
                {
                    Console.WriteLine("Quiere incrementar un sateite¿? (Sí: 1 || No: 2)");

                }
                while (true);
                //astros.IndexOf((Astro)p1).
            }
            else
            {
                Console.WriteLine("Planeta no existente");
            }



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
