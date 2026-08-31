using System;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1;
            var line = Console.ReadLine();
            var data = line.Split(' ');
            x1 = double.Parse(data[0]);
            y1 = double.Parse(data[1]);

            double x2, y2;
            var line2 = Console.ReadLine();
            var data2 = line2.Split(' ');
            x2 = double.Parse(data2[0]);
            y2 = double.Parse(data2[1]);

            double distance;
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(Math.Round(distance, 4));

            Console.ReadLine();
        }
    }
}

