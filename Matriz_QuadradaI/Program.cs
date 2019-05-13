using System;

namespace Matriz_QuadradaI
{

    //Time limit exceeded
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string entrada = Console.ReadLine();
                if (entrada == "0")
                    break;
                
                int tamanho = int.Parse(entrada);

                int[,] matriz = new int[tamanho, tamanho];

                int pares = Convert.ToInt32(Math.Ceiling(tamanho/2.0f));

                string content = "";

                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {
                        for (int par = pares-1; par >= 0; par--)
                        {
                            if (i == par || i == tamanho - par -1 || j == tamanho - par -1 || j == par)
                            {
                                matriz[i, j] = par +1;
                            }
                        }
                        if (j != 0)
                            content += " ";
                        content += "  " + matriz[i, j].ToString();
                        

                    }
                    content += "\n";
                }
                Console.WriteLine(content);
            }
        }
    }
}
