using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first, second;

            // Read and validate 'first'
            while (true)
            {
                string primeiro = Console.ReadLine();
                first = double.Parse(primeiro, CultureInfo.InvariantCulture);

                if (first < 0 || first > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    break;
                }
            }

            // Read and validate 'second'
            while (true)
            {
                string segundo = Console.ReadLine();
                second = double.Parse(segundo, CultureInfo.InvariantCulture);

                if (second < 0 || second > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    break;
                }
            }

            double media = (first + second) / 2;
            Console.WriteLine($"media = {media:F2}");
        }
    }
}
