using System;
using System.Collections.Generic;

namespace Fibonacci_em_Vetor
{
    class Program
    {
        public static UInt64 fib (UInt64 n, IDictionary<UInt64, UInt64> fibDic)
        {
            if (n == 0 || n == 1)
                return n;
            else 
            {
                if (fibDic.ContainsKey(n))
                    return fibDic[n];
                else
                {
                    UInt64 FibN = fib(n-1, fibDic) + fib(n-2, fibDic);
                    fibDic.Add(n, FibN);
                    return FibN;
                }
            }
        }

        static void Main(string[] args)
        {
            IDictionary<UInt64, UInt64> fibonacci = new Dictionary<UInt64, UInt64>();
            fibonacci.Add(0, 0);
            fibonacci.Add(1, 1);

            UInt64 iteracoes = UInt64.Parse(Console.ReadLine());
            for (UInt64 i = 0; i < iteracoes; i++)
            {
                UInt64 n = UInt64.Parse(Console.ReadLine());
                fib(n, fibonacci);
                Console.WriteLine("Fib({0}) = {1}",n, fibonacci[n]);
            }
        }
    }
}
