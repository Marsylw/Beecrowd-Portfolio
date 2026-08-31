using System;

namespace UriMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, h;

            number = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());


            double salary, p;

            p = double.Parse(Console.ReadLine());

            salary = h * p;
            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));



            
        }
    }
}
