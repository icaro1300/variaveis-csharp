using System;

namespace tipos_de_variavéis
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = num1;
            int resultado = num1 + num2;
            num1 = 6;
            Console.WriteLine("O valor de num1 é: {0} e está no stack.", num1.ToString());
            Console.WriteLine("O valor de num2 é: {0} e está no stack.", num2.ToString());
            Calculadora minhacalculadora = new Calculadora();
            minhacalculadora.somar();
            Console.ReadKey();

            Console.WriteLine("Variavéis nulla");
            int? altura = null;

            if (altura.HasValue)
            {
                Console.WriteLine("O valor da altura: {0}", altura);
            }
            else
            {
                Console.WriteLine("O valor da altura é nullo");
            }

            Console.ReadKey();
        }
    }

}



  
    


