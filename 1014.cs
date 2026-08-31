using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
           X = Convert.ToInt32(Console.ReadLine());

            decimal Y;
            Y = Convert.ToDecimal(Console.ReadLine());

            decimal avrg;
            avrg = (X / Y) ;


            Console.WriteLine(Math.Round(avrg, 3, MidpointRounding.AwayFromZero) + " km/l");
            
            

            Console.ReadLine();
        }
    }
}
