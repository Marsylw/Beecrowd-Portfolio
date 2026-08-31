using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        if (N >= 10000)
        {
            return; // Or handle as an error if needed
        }

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            // Check constraints
            if (X <= -10000000 || X >= 10000000)
            {
                continue; // Or handle as an error
            }

            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                string parity = (X % 2 == 0) ? "EVEN" : "ODD";
                string sign = (X > 0) ? "POSITIVE" : "NEGATIVE";
                Console.WriteLine($"{parity} {sign}");
            }
        }
    }
}

