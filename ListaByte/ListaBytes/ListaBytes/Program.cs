using System;

namespace ListaBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] valores = { 4, "gota", 300, 500, 255, 5 };
            byte[] vbytes = new byte[5];
            string[] vtextos = new string[5];
            int[] vforafaixa = new int[5];
            int pbytes = 0;
            int ptextos = 0;
            int pfaixa = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    var v = Convert.ToByte(valores[i]);
                    vbytes[pbytes] = v;
                    pbytes++;
                }
                catch (FormatException)
                {
                    vtextos[ptextos] = valores[i].ToString();
                    ptextos++;
                }
                catch (OverflowException)
                {
                    vforafaixa[pfaixa] = Convert.ToInt32(valores[i]);
                    pfaixa++;
                }
                Console.ReadKey();
            }
        }
    } }
