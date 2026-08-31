using System;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            n = int.Parse(Console.ReadLine());


            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i + "^2 = " + (i * i));
            }
            Console.ReadLine();
        }
    }
}
