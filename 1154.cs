using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int incremento = 0;
            int entrada, total =0;
            double media;

            while (true)
            {
                entrada = int.Parse(Console.ReadLine());
                if (entrada < 0)
                {
                    break;
                }
                incremento++;
                total += entrada;

                
                
            }media = (double)total / incremento;
            Console.WriteLine($"{media:f2}");

        }
    }
}

