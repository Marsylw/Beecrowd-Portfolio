using System;

class Program
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        int cents = (int)Math.Round(input * 100);  // Convert to cents

        int[] noteValues = { 10000, 5000, 2000, 1000, 500, 200 };
        int[] coinValues = { 100, 50, 25, 10, 5, 1 };

        Console.WriteLine("NOTAS:");
        foreach (int note in noteValues)
        {
            int count = cents / note;
            Console.WriteLine($"{count} nota(s) de R$ {(note / 100.0):0.00}");
            cents %= note;
        }

        Console.WriteLine("MOEDAS:");
        foreach (int coin in coinValues)
        {
            int count = cents / coin;
            Console.WriteLine($"{count} moeda(s) de R$ {(coin / 100.0):0.00}");
            cents %= coin;
        }
    }
}

