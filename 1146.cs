using System;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder(); // For efficient output building

        while (true)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0) break; 

            for (int i = 1; i <= x; i++)
            {
                sb.Append(i);
                if (i < x) sb.Append(' '); // Add space only between numbers
            }
            sb.Append('\n'); 
        }

        Console.Write(sb); 
    }
}
