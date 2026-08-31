using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);


            Console.WriteLine("A={0:F4}", area);
            //or console.WriteLIne("A="+area.ToString("0.0000"));
            
            Console.ReadLine();
        }
    }
}

