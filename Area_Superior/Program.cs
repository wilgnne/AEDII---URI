using System;
using System.Collections.Generic;


// PROBLEMAS COM O DOUBLE DO C#, O MESMO AREDONDA AO LIMITAR O NUMERO DE CASAS
namespace Area_Superior
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = Console.ReadLine();

            float[,] matriz = new float[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = float.Parse(Console.ReadLine());
                }
            }

            int max = 10;
            int min = 1;
            int linha = 0;
            int coluna = min;

            float sum = 0;

            while (max >= 2)
            {
                while (coluna <= max)
                {
                    sum = sum + matriz[linha, coluna];
                    coluna++;
                }
                coluna = ++min;
                linha++;
                max -= 1;
            }

            if (op == "S")
            {
                string val = String.Format("{0:0.000000}", sum).Replace(",", ".");
                Console.WriteLine(val.Substring(0, val.Length - 5));
            }
            else if (op == "M")
            {
                string val = String.Format("{0:0.000000}", sum/30.0f).Replace(",", ".");
                Console.WriteLine(val.Substring(0, val.Length - 5));
            }
        }
    }
}
