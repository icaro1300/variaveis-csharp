using System;

namespace ByteVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] vbytes = { 2, 4, 8, 10 };

            Console.WriteLine("Lista de Valores do Vetor");
            Console.WriteLine("Valor1: {0}", vbytes[0]);
            Console.WriteLine("Valor2: {0}", vbytes[1]);
            Console.WriteLine("Valor3: {0}", vbytes[2]);
            Console.WriteLine("Valor4: {0}", vbytes[3]);
            Console.WriteLine("Total de elementos no vetor é: {0}", vbytes.Length);

            for (int i = 0; i < vbytes.Length; i++)
            {
                Console.WriteLine("Valor a posição {0} é igual a {1}", i, vbytes[i]);

            }
            byte[] vbytesB = new byte[3];
            Console.WriteLine("Novos valores");
            for (int i = 0; i < vbytesB.Length; i++)
            {
                Console.WriteLine("Digite o {0} valor: ", i);
                try
                {
                    vbytesB[i] = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    vbytes[i] = 0;
                }
                int contValidos = 0;
                int contInvalidos = 0;
            
                {
                    if (vbytesB[i] == 0) { contInvalidos ++; }
                    else { contValidos ++; }
                    Console.WriteLine("Quantidade de válidos é: {0}", contValidos);
                    Console.WriteLine("Quantidade de invalidos é: {0}", contInvalidos);




                }

            }
        }
    } }
