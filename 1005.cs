using System;

namespace Uri_1002
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, MEDIA;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());


            MEDIA = (A * 3.5 + B * 7.5) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.00000"));


            
        }
    }
}

