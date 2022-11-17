using System;

namespace _4d
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira 10 valores:");
            string[] valores = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor: {0}", i + 1);
                valores[i] = Console.ReadLine();
            }

            double[] pares = new double[10];
            double[] impares = new double[10];

            for (int i = 0; i < 10; i++)
            {
                int v = Convert.ToInt32(valores[i]);
                if (v % 2 == 0)
                {
                    Console.WriteLine("Os valores pares são: {0}", v);
                }
                else
                {
                    Console.WriteLine("Os valores ímpares são: {0}", v);
                }
            } } } }
       
