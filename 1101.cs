using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            if (m <= 0 || n <= 0)
                break;

            int min = Math.Min(m, n);
            int max = Math.Max(m, n);
            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine($"Sum={sum}");
        }
    }
}
