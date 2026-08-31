using System;

namespace UriMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string name = Console.ReadLine();

            double s, t, total;

            s = double.Parse(Console.ReadLine());
            t = double.Parse(Console.ReadLine());

             

            total = s + t * 0.15;
            
            


            
            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));



            Console.ReadLine();
        }
    }
}

