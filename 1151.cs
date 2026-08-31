using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n <= 0 || n >= 46)
            return;

        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a);
            if (i < n - 1)
                Console.Write(" ");
            
            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine(); // Ensures proper newline at the end
    }
}

