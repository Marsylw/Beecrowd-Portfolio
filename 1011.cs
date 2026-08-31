using System;
namespace _1011
{
    class Program
    {
        static void Main(string[] args)
       {
            double radius;
            radius = double.Parse(Console.ReadLine());
            double pi, volume;
            pi = 3.14159;
            volume = (4 / 3.0);
            decimal sphere;
            sphere = Convert.ToDecimal(volume * pi * Math.Pow(radius, 3));

           


            Console.WriteLine("VOLUME = " + Math.Round(sphere, 3));

            Console.ReadLine();
        }
    }
}
