using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z;

            // Keep reading until z > x
            do
            {
                z = int.Parse(Console.ReadLine());
            } while (z <= x);

            int sum = 0;
            int count = 0;

            // Start from x and keep summing until sum > z
            for (int i = x; sum <= z; i++)
            {
                sum += i;
                count++;
            }

            Console.WriteLine(count);


        }
    }
}

