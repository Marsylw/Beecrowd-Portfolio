using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] n = new int[20];

        
        for (int i = 0; i < 20; i++)
            n[i] = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < 20; i++)
            Console.WriteLine($"N[{i}] = {n[19 - i]}");
    }
}
