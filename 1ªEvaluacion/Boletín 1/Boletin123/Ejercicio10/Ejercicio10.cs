namespace Ejercicio10
{
    public class Ejercicio10
    {
        static void Main(string[] args)
        {
            GestorMatriz gm = new GestorMatriz();
            Console.WriteLine("MATRIZ");
            GestorMatriz.MostrarMatriz<int>(gm.Matriz);
            Console.WriteLine("SUMA FILA 1");
            Console.WriteLine(gm.SumaFila(1));
            Console.WriteLine("SUMA FILA 3");
            Console.WriteLine(gm.SumaFila(3));
            int resultadoColumna;
            Console.WriteLine("SUMA COLUMNA 1");
            gm.SumaColumna(1,out resultadoColumna);
            Console.WriteLine(resultadoColumna);
            Console.WriteLine("SUMA COLUMNA 3");
            gm.SumaColumna(3, out resultadoColumna);
            Console.WriteLine(resultadoColumna);
        }
    }
}
