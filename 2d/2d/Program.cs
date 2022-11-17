using System;

namespace _2d
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Insira os determinados lados do Quadrado:");
            double lados4 = Convert.ToDouble(Console.ReadLine());

            double perimetro = lados4 * 4;
            Console.WriteLine("O perímetro (soma dos lados) é:" + perimetro);


        }
    }
}
