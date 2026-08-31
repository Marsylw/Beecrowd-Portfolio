using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, duracao;
            string[] data = Console.ReadLine().Split(' ');
            start = Convert.ToInt32(data[0]);
            end = Convert.ToInt32(data[1]);
            duracao = 0;

            if ((end - start <= 0))
            {
                duracao = 24 + (end - start);
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            }
            else
            {
                duracao = end - start;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
            }

            Console.ReadLine();
        }
    }
}

