using System;

public class beecrowd
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());   // ✅ added ()
            int conta = 0;

            for (int b = 1; b <= x; b++)
            {
                if (x % b == 0)
                    conta++;
            }

            if (conta == 2)
                Console.WriteLine($"{x} eh primo");
            else
                Console.WriteLine($"{x} nao eh primo");
        }
    }
}
