using System;

namespace ByteParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar um programa que leia 10 números e ao final exiba a lista de valores pares e impares. Só aceitavél valores do tipo Byte.
           //Também deve ser exibido a quantidade de valores que não são Bytes.

            Console.WriteLine("Digite 10 números:");
            string[] valores = new string[10];

            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine("Digite o {0}º valor:", i + 1);
                valores[i] = Console.ReadLine();
            }
            byte[] pares = new byte[10];
            byte[] impares = new byte[10];
            int qtderros = 0;
            int indicepar = 0;
            int indiceimpar = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    byte v = Convert.ToByte(valores[i]);
                    if (v % 2 ==0)
                    {
                        pares[indicepar] = v;
                        indicepar++;
                    }
                    else
                    {
                        impares[indiceimpar] = v;
                        indicepar++;
                    }
                }
                catch (Exception)
                {
                    qtderros++;
                }
            }
            //Imprimir lista dos pares
            Console.WriteLine("Pares");
            for (int i = 0; i < 10; i++)
            {
                if (pares[i]!=0) { Console.WriteLine(pares[i]); }
            }
            //Imprimir lista dos impares
            Console.WriteLine("Impares");
            for (int i = 0; i < 10; i++)
            {
                if (impares[i] != 0) { Console.WriteLine(impares[i]); }
            }
             //total final de erros
             Console.WriteLine("A quantidade de erros {0}", qtderros);
            }
        }
    }

