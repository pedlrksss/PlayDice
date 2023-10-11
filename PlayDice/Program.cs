using System;

namespace PlayDice
{
    class project
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do primeiro jogador: ");
            string name1 = Console.ReadLine();

            Console.Write("Nome do segundo jogador: ");
             string name2 = Console.ReadLine();

            if (name1 != name2)
            {
                int n = 3;
                int[] dados = new int[] {1,2,3,4,5,6};
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Rodada #{i}");

                }
            }

        }
    }
}
