using System;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {

            double entrada = Convert.ToDouble(Console.ReadLine());

            if (entrada >= 0.0 && entrada <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");

            }
            else if (entrada > 25.0 && entrada <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");

            }
            else if (entrada > 50.0 && entrada <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
                
            }
            else if (entrada > 75.0 && entrada <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");

            }
            else if (entrada < 0.0 || entrada >100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            

            Console.ReadLine();
        }
    }
}
