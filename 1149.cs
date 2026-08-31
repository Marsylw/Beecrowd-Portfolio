using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0]);
            int n = int.Parse(entrada[1]);
            int index = 1;

            while (true)
            {
                n = int.Parse(entrada[index]);
                if (n > 0)
                {
                    break;
                }
                index++;
            }

            int sum = 0;
            for (int i = 0; i < n; i++) 
            {
                sum +=a + i;
            }
            Console.WriteLine(sum);
        }
    }
}

