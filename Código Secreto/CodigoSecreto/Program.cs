using System;

namespace CodigoSecreto
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();

                if (String.IsNullOrEmpty(str))
                    break;
                int.TryParse(str, out int entrada);

                for (int i = 0; i < entrada; i++)
                {
                    string[] codigo = Console.ReadLine().Split(new char[] { ' ' });

                    int numOfPart = codigo.Length;
                    int numOfElem = codigo[0].Length;

                    int elemento = ((numOfPart*3) -3 ) + numOfElem -1;
                    string caracter = Char.ConvertFromUtf32(97 + elemento);

                    Console.WriteLine(caracter);
                }
            }
        }
    }
}
