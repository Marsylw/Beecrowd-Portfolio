using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int item1 = int.Parse(Console.ReadLine());
            int item2 = int.Parse(Console.ReadLine());
            

            int PROD;
            PROD = item1 * item2;

            Console.WriteLine("PROD = " + PROD);

            Console.ReadLine();
        }
    }
}

