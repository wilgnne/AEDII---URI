using System;

namespace Entrada_e_Saida_com_Virgula
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();
            
            int v = texto.IndexOf(',');

            for (int i = 0; i < texto.Length; i++)
            {
                if (i != v)
                    Console.Write(texto[i]);
                else
                    Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
