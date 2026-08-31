using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            if (x > 1 && x <20 && y > x && y < 100000)
            {
                for (int i = 1; i <= y; i++)
                {
                    Console.Write(i);

                    if (i % x != 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }




        }
    }
}

