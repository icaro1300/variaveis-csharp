using System;

namespace _1d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um determinado valor:");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Este valor é número!");
            }
            catch (Exception)
            {
                Console.WriteLine("Este valor é texto!");
          
            }
        }
    }
}
