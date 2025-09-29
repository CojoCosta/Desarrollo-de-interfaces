using System.Linq.Expressions;

namespace Ejercicio9
{
    public class Ejercicio9
    {
        public static int pedirEntero()
        {
            bool flag = true;
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
                    Console.WriteLine("Numero entero positivo");
                }
            } while (!flag);
            return numero;
        }
        static void Main(string[] args)
        {
            Dictionary<String, Ordenador> ipPorOrdenador = new Dictionary<String, Ordenador>();
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
                        Ordenador ordenador = new Ordenador();
                        string ip;
                        Console.WriteLine("Escribe la ip del equipo con formato(xxx.xxx.xxx.xxx): ");
                        ip = Console.ReadLine();
                        if (!Ordenador.comprobadorIPs(ip))
                        {
                            goto case 1;
                        }
                        Console.WriteLine("Nombre del equipo");
                        ordenador.Nombre = Console.ReadLine();
                        ipPorOrdenador.Add(ip, ordenador);

                        Console.WriteLine("Escribe la RAM: (numero entero positivo)");
                        ordenador.MemoriaRam = pedirEntero();
                        break;

                    case 2:
                        string datos;
                        string [] ipParRamImpar = new string[0];
                        string [] ips;
                        string [] rams;
                        Dictionary<string, int> ipPorRam = new Dictionary<string, int>();
                        Console.WriteLine("Escribe las ips y RAMs con formato(xxx.xxx.xxx.xxx:RAM, ip2:RAM,... ");
                        datos = Console.ReadLine();
                        string [] ipRam = datos.Split(",");
                        for (int j = 0; j < ipRam.Length; j++)
                        {
                            ipParRamImpar = ipRam[j].Split(":");
                        }
                        for (int k = 0; k < ipParRamImpar.Length; k++)
                        {
                            if (k % 2 == 0)
                            {
                                ips = ipParRamImpar[k];
                            }
                        }
                        break;

                    case 3:

                        break;

                    case 4:
                        int i = 1;
                        foreach (var ordenadores in ipPorOrdenador)
                        {
                            Console.WriteLine("ip" + i + ": " + ordenadores.Key);
                            i++;
                        }

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
