using System;

public class beecrowd
{
    public static void Main(string[] args)
    {
        int[] X = new int[10];
        int V = int.Parse(Console.ReadLine());

        X[0] = V;
        for (int i = 1; i < 10; i++)
        {
            X[i] = X[i - 1] * 2;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"N[{i}] = {X[i]}");
        }
    }
}
