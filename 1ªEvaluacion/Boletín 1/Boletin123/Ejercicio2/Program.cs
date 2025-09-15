namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;
            double peso;

            Console.WriteLine("Diga su nombre: ");
            nombre =  Console.ReadLine();
            Console.WriteLine("Diga su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga su peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre es: {0,12}, " +
                "su edad: {1,4} \n\ty su peso {2,5:F1} \nsu " +
                "nombre entre comillas: \"{0}\" y edad " +
                "entre barras \\{1}\\", nombre, edad, peso);
        }
    }
}
