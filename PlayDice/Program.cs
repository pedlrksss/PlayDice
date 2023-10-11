using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

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
            int n = 3;
            int sum1 = 0;
            int sum2 = 0;

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rodada #{i}");
                int result1 = random.Next(1, 7);
                Console.WriteLine($"{name1} tirou {result1}");
                sum1 += result1;

                int result2 = random.Next(1, 7);
                Console.WriteLine($"{name2} tirou {result2}");
                sum2 += result2;
            }
            
            Console.WriteLine($"Total de {name1}: {sum1}");
            Console.WriteLine($"Total de {name2}: {sum2}");

            if (sum1 > sum2)
            {
                Console.WriteLine($"{name1} ganhou");
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine($"{name2} ganhou");
            }
            else
            {
                Console.WriteLine("EMPATE");
            }



        }
    }
}
