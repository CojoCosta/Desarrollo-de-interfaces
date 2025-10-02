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
                    Console.WriteLine("Numero entero positivo (1-6)");
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
                option = pedirEntero();
                switch (option)
                {
                    case 1:
                        Ordenador ordenador = new Ordenador();
                        string ip;
                        bool flag = true;
                        Console.WriteLine("Escribe la ip del equipo con formato(xxx.xxx.xxx.xxx): ");
                        ip = Console.ReadLine();
                        if (!Ordenador.comprobadorIPs(ip))
                        {
                            goto case 1;
                        }
                        do
                        {
                            Console.WriteLine("Nombre del equipo");
                            ordenador.Nombre = Console.ReadLine();//TODO revisar
                            if (!ipPorOrdenador.ContainsKey(ip))
                            {
                                ipPorOrdenador.Add(ip, ordenador);
                            }
                        }
                        while (false);


                        Console.WriteLine("Escribe la RAM: (numero entero positivo)");
                        ordenador.MemoriaRam = pedirEntero();
                        break;

                    case 2:
                        Ordenador ordenador1 = new Ordenador();
                        string datos;
                        string[] ordenadores;
                        string[] ipYRam;
                        string ips;
                        string rams;
                        Dictionary<string, int> ipPorRam = new Dictionary<string, int>();
                        Console.WriteLine("Escribe las ips y RAMs con formato(xxx.xxx.xxx.xxx:RAM, ip2:RAM,... ");
                        datos = Console.ReadLine();
                        ordenadores = datos.Split(",");
                        for (int j = 0; j < ordenadores.Length; j++)
                        {
                            ipYRam = ordenadores[j].Split(":");
                            if (ipYRam.Length == 2)
                            {
                                ips = ipYRam[0];
                                rams = ipYRam[1];
                                bool flag1 = int.TryParse(rams, out int ramComprobada);// no tienes en cuenta problemas con ram
                                if (Ordenador.comprobadorIPs(ips) && !ipPorOrdenador.ContainsKey(ips) && flag1)
                                {
                                    ordenador1.MemoriaRam = ramComprobada;
                                    ipPorOrdenador.Add(ips, ordenador1);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error en algun split");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Escriba la ip del ordenador que desea eliminar");
                        string ipEliminar = Console.ReadLine();
                        if (!Ordenador.comprobadorIPs(ipEliminar))
                        {
                            Console.WriteLine("El ordenador con esta ip no existe.");
                            break;
                        }
                        else
                        {
                            if (ipPorOrdenador.ContainsKey(ipEliminar))
                            {
                                ipPorOrdenador.Remove(ipEliminar);
                                
                                //TODO ????? O_o'
                            }
                        }

                        break;

                    case 4:
                        int i = 1;
                        foreach (var item in ipPorOrdenador.Keys)
                        {
                            Console.WriteLine("ip" + i + ": " + item);
                            i++;
                        }
                        //foreach (var ordenado in ipPorOrdenador)//TODO recorrer solo conleccion de claves
                        //{
                        //Console.WriteLine("ip" + i + ": " + ordenado.Key);
                        //i++;
                        //}

                        break;

                    case 5:
                        Console.WriteLine("Escriba la ip del ordenador del que desee saber su ram");
                        String ipMostrarRam = Console.ReadLine();
                        if (ipPorOrdenador.ContainsKey(ipMostrarRam))
                        {
                            Console.WriteLine("Memoria de su ordenador es: " + ipPorOrdenador[ipMostrarRam]);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Gracias por usar el programa");
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
