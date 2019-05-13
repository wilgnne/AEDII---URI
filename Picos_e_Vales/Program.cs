using System;

namespace Picos_e_Vales
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] strmedidas = Console.ReadLine().Split(new char[] {' '});
            int[] medidas = new int [num];

            for (int i = 0; i < num; i++)
            {
                medidas[i] = int.Parse(strmedidas[i]);
            }


            bool previewVale, accepted;
            previewVale = (medidas[0] > medidas[1]) ? true : false;
            accepted = true;

            if (medidas[0] != medidas[1])
            {
                for (int i = 2; i < num; i++)
                {
                    if (previewVale)
                    {
                        if (medidas[i] > medidas[i-1])
                        {
                            previewVale = false;
                        }
                        else
                        {
                            accepted = false;
                            Console.WriteLine("0");
                            break;
                        }
                    }
                    else
                    {
                        if (medidas[i] < medidas[i-1])
                        {
                            previewVale = true;
                        }
                        else
                        {
                            accepted = false;
                            Console.WriteLine("0");
                            break;
                        }
                    }
                }
            }
            else
            {
                accepted = false;
                Console.WriteLine("0");
            }

            if (accepted == true)
            {
                Console.WriteLine("1");
            }
        }
    }
}
