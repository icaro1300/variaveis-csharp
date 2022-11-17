using System;

namespace raiz_quadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            double numer;
            Console.WriteLine("Digite valor:");
            numer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A raiz quadrada é de:", Math.Sqrt(numer));
        }
    }
}
