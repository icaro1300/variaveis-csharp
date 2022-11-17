using System;

namespace int_real
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Console.WriteLine("Digite valor:");
            try
            {
                valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("O valor é inteiro!");
            }
            catch (Exception)
            {
                Console.WriteLine("O valor é real!");
                throw;
            }
        }
    }
}
