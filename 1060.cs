using System;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[6];
            int positiveCount = 0;
            
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                if (numbers[i] > 0)
                {
                    positiveCount++;
                    
                }
            }


            Console.WriteLine($"{positiveCount} valores positivos");


            Console.ReadLine();

        }
    }
}

