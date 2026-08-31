using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1179
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                double primeiro = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                double segundo = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                double terceiro = double.Parse(entrada[2], CultureInfo.InvariantCulture);
                double media = (primeiro * 2 + segundo * 3 + terceiro * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

