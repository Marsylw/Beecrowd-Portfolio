using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1118
{
    internal class Program
    {
        int x = 0;
        static void Main(string[] args)
        {

            while (true)
            {
                double first, second;

                // Read and validate 'first'
                while (true)
                {
                    string primeiro = Console.ReadLine();
                    first = double.Parse(primeiro, CultureInfo.InvariantCulture);
                    if (first < 0 || first > 10)
                        Console.WriteLine("nota invalida");
                    else
                        break;
                }

                // Read and validate 'second'
                while (true)
                {
                    string segundo = Console.ReadLine();
                    second = double.Parse(segundo, CultureInfo.InvariantCulture);
                    if (second < 0 || second > 10)
                        Console.WriteLine("nota invalida");
                    else
                        break;
                }

                double media = (first + second) / 2;
                Console.WriteLine($"media = {media:F2}");

                // Ask user if they want another calculation
                int calculo;
                while (true)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    calculo = int.Parse(Console.ReadLine());

                    if (calculo == 1)
                        break; // repeat from top of outer loop
                    else if (calculo == 2)
                        return; // end the program
                   
                }
            }
        }
            
            
          

        
    }
}
