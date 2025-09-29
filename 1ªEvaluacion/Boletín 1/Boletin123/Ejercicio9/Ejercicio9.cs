namespace Ejercicio9
{
    public class Ejercicio9
    {
        static void Main(string[] args)
        {
            Dictionary<String, Ordenador> direcciones = new Dictionary<String, Ordenador>();
            int option = 0;
            do
            {
                Console.WriteLine("1.- Añadir nuevo equipo");
                Console.WriteLine("2.- Añadir varios equipos");
                Console.WriteLine("3.- Elimina un dato por clave");
                Console.WriteLine("4.- Mostrar coleccion completa(solo ips)");
                Console.WriteLine("5.- Muestra un elemento de la coleccion (mostrar RAM o que no existe)");
                Console.WriteLine("6.- Salir");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:

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

                        break;

                    default:
                        Console.WriteLine("Elija una opcion del menu");
                        break;

                }
            }
            while (option != 6);
        }
    }
}
