using System;

namespace TypeByte
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte x = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("O valor digital é: {0}", x);
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor digitado está fora do máximo. O máximo é 255");
            }
            catch (FormatException)
            {
                Console.WriteLine("Você digitou um texto. Só é aceitável um número de 0 a 255");
            }
         
        }
    }
}
