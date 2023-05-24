using System;

namespace Fact_Recursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funciones factorial = new Funciones();
            Console.WriteLine("Recursivo: ");
            Console.WriteLine(factorial.Fact(7));
            Console.WriteLine(factorial.Fact(9));
            Console.WriteLine(factorial.Fact(12));
            Console.WriteLine("Con ciclos: ");
            Console.WriteLine(factorial.FactCiclo(7));
            Console.WriteLine(factorial.FactCiclo(9));
            Console.WriteLine(factorial.FactCiclo(12));
        }
    }
}
