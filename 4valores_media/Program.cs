using System;

namespace _4valores_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double numer1 = 0;
            double numer2 = 0;
            double numer3 = 0;
            double numer4 = 0;
            double media;
            double soma;
            Console.WriteLine("Digite 4 valores:");
            numer1 = Convert.ToDouble(Console.ReadLine());
            numer2 = Convert.ToDouble(Console.ReadLine());
            numer3 = Convert.ToDouble(Console.ReadLine());
            numer4 = Convert.ToDouble(Console.ReadLine());
            soma = numer1 + numer2 + numer3 + numer4;
            media = soma / 4;
            Console.WriteLine("O valor da soma é:" +soma +"E o valor da média é:" +media);
        }
    }
}
