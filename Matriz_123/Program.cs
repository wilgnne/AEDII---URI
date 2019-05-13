using System;

namespace Matriz_123
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                    break;
                
                int num = int.Parse(entrada);
                int cont = num-1;

                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        char c = '3';
                        if (i == j)
                        {
                            c = '1';
                        }
                        if (j == cont)
                        {
                            c = '2';
                            cont--;
                        }
                        Console.Write(c);
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
