using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n < 13)
            {
                int factorial = 1;

                for (int i = 1; i < n; i++)
                {
                    factorial += factorial * i;
                }
                Console.WriteLine(factorial);
            }

        }
    }
}

