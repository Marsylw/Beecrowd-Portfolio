using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor <= 10.0)
            {
                Console.WriteLine($"A[{i}] = {valor:F1}"); 
            }
        }
    }
}
