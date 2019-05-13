using System;
using System.Collections.Generic;

namespace C_Mais_ou_Menos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            Dictionary<string, int> tabela = new Dictionary<string, int>()
            {
                ["suco"] = 120,
                ["morango"] = 85,
                ["mamao"] = 85,
                ["goiaba"] = 70,
                ["manga"] = 56,
                ["laranja"] = 50,
                ["brocolis"] = 34,
            };

            while (numero != 0)
            {
                int total = 0;
                for (int i = 0; i < numero; i++)
                {
                    string[] comida = Console.ReadLine().Split(new char[] {' '});
                    total = total + (int.Parse(comida[0]) * tabela[comida[1]]);
                }
                if (total >= 110 )
                {
                    if(total <= 130)
                    {
                        Console.WriteLine("{0} mg", total);
                    }
                    else
                    {
                        Console.WriteLine("Menos {0} mg", total - 130);
                    }
                }
                else
                {
                    Console.WriteLine("Mais {0} mg", 110 - total);
                }

                numero = int.Parse(Console.ReadLine());
            }
        }
    }
}
