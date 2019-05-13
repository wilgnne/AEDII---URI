using System;

namespace Iu_Di_Oh
{
    public struct Jogador
    {
        public int[,] cartas;
    }

    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string a = Console.ReadLine();
                if (string.IsNullOrEmpty(a))
                    break;

                int atributos = int.Parse(a);


                Jogador Marcos = new Jogador();
                Jogador Leonardo = new Jogador();

                string[] lenBaralho = Console.ReadLine().Split(new char[] {' '});

                int lenMarcos = int.Parse(lenBaralho[0]);
                int lenLeonardo = int.Parse(lenBaralho[1]);

                Marcos.cartas = new int[lenMarcos, atributos];
                Leonardo.cartas = new int[lenLeonardo, atributos];

                for (int i = 0; i < lenMarcos; i++)
                {
                    string[] infoCarta = Console.ReadLine().Split(new char[] {' '});
                    for (int j = 0; j < atributos; j++)
                    {
                        Marcos.cartas[i, j] = int.Parse(infoCarta[j]);
                    }
                }

                for (int i = 0; i < lenLeonardo; i++)
                {
                    string[] infoCarta = Console.ReadLine().Split(new char[] {' '});
                    for (int j = 0; j < atributos; j++)
                    {
                        Leonardo.cartas[i, j] = int.Parse(infoCarta[j]);
                    }
                }

                string[] selectedCard = Console.ReadLine().Split(new char[] {' '});
                int selectedAtribut = int.Parse(Console.ReadLine()) -1;

                int forceMarcos = Marcos.cartas[int.Parse(selectedCard[0]) -1, selectedAtribut];
                int forceLeonardo = Leonardo.cartas[int.Parse(selectedCard[1]) -1, selectedAtribut];

                if (forceLeonardo > forceMarcos)
                {
                    Console.WriteLine("Leonardo");
                }
                else if (forceLeonardo < forceMarcos)
                {
                    Console.WriteLine("Marcos");
                }
                else
                {
                    Console.WriteLine("Empate");
                }
            }
        }
    }
}
