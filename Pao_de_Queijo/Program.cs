using System;

namespace Pao_de_Queijo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string entrada = Console.ReadLine();

                if (String.IsNullOrEmpty(entrada))
                    break;
                string[] indexs = entrada.Split(new char[] {' '});
                int linhas = int.Parse(indexs[0]);
                int colunas = int.Parse(indexs[1]);

                string[,] matriz = new string[linhas, colunas];

                for (int i = 0; i < linhas; i++)
                {
                    string linha = Console.ReadLine();
                    string[] elementos = linha.Split(new char[] {' '});

                    for (int j = 0; j < elementos.Length; j++)
                    {
                        matriz[i, j] = elementos[j];
                    }
                }

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        int adjacentes = 0;

                        if (matriz[i, j] == "1")
                        {
                            Console.Write('9');
                        }
                        else
                        {
                             //Em cima
                            if (i > 0)
                                if (matriz[i-1, j] == "1")
                                    adjacentes += 1;
                            //Em baixo
                            if (i < linhas - 1)
                                if (matriz[i+1, j] == "1")
                                    adjacentes += 1;
                            //Na esquerda
                            if (j > 0)
                                if (matriz[i, j-1] == "1")
                                    adjacentes += 1;
                            //Na direita
                            if (j < colunas - 1)
                                if (matriz[i, j+1] == "1")
                                    adjacentes += 1;
                        
                            Console.Write(adjacentes);
                        }
                    }
                    Console.Write('\n');
                }
            }
        }
    }
}
