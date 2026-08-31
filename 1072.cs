using System;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int integers, dentro, fora;

            integers = int.Parse(Console.ReadLine());

            dentro = 0;
            fora = 0;

            int[] vector = new int[integers];

            for (int i =0; i < integers; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0 ; i < integers; i++)
            {

                if (vector[i] >= 10 && vector[i] <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora ++;
                }
            }
            

            Console.WriteLine($"{dentro} in\n{fora} out");
        }
    }
}

