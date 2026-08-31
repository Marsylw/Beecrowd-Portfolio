using System;

namespace UriMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            media = (A * 2 + B * 3 + C * 5) / (2 + 3 + 5);
            Console.WriteLine("MEDIA = " + media.ToString("F1"));



            
        }
    }
}

