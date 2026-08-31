using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int coelho = 0;
            int rato = 0;
            int sapo = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(entrada[0]);
                char tipo = char.ToUpper(entrada[1][0]);

                total += quantidade;

                if (tipo == 'C')
                {
                    coelho += quantidade;
                }
                else if (tipo == 'R')
                {
                    rato += quantidade;
                }
                else if (tipo == 'S')
                {
                    sapo += quantidade;
                }

            }

            double percoelhos = (coelho * 100.0) / total;
            double perrato = (rato * 100.0) / total;
            double persapo = (sapo  * 100.0) / total;

            
            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");

            Console.WriteLine($"Percentual de coelhos: {percoelhos:f2} %");
            Console.WriteLine($"Percentual de ratos: {perrato:f2} %");
            Console.WriteLine($"Percentual de sapos: {persapo:f2} %");
        }
    }
}
