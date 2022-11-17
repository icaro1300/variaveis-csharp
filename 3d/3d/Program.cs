using System;

namespace _3d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do Retângulo:");
            double altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a largura do Retângulo:");
            double largura = Convert.ToInt32(Console.ReadLine());

            double area = largura*altura;
            Console.WriteLine("A área do Retângulo é:" +area);

            double perimetro = (largura + altura)* 2;
            Console.WriteLine("O perímetro é:" + perimetro);
           

        }
    }
}
