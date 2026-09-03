using System;

public class beecrowd
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int min = Math.Min(x, y);
        int max = Math.Max(x, y);

        
        for (int i = min + 1; i < max; i++)
        {
            int remainder = i % 5;
            if (remainder < 0) remainder += 5; // get positive remainder

            if (remainder == 2 || remainder == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
