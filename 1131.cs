using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int interWins = 0;
            int gremioWins = 0;
            int empates = 0;
            int totalGrenais = 0;

            while (true)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int primeiro = int.Parse(entrada[0]); // Gols Inter
                int segundo = int.Parse(entrada[1]);  // Gols Grêmio

                totalGrenais++;

                if (primeiro > segundo)
                    interWins++;
                else if (segundo > primeiro)
                    gremioWins++;
                else
                    empates++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int novo;
                while (true)
                {
                    novo = int.Parse(Console.ReadLine());
                    if (novo == 1 || novo == 2)
                        break;
                    else
                        Console.WriteLine("Novo grenal (1-sim 2-nao)");
                }

                if (novo == 2)
                    break;
            }

            Console.WriteLine($"{totalGrenais} grenais");
            Console.WriteLine($"Inter:{interWins}");
            Console.WriteLine($"Gremio:{gremioWins}");
            Console.WriteLine($"Empates:{empates}");

            if (interWins > gremioWins)
                Console.WriteLine("Inter venceu mais");
            else if (gremioWins > interWins)
                Console.WriteLine("Gremio venceu mais");
            else
                Console.WriteLine("Não houve vencedor");
        }
    }
}

