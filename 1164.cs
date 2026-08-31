using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        if (n>=1 && n <100)
        {
            for (int i =0; i <n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            
            if (x >= 1 && x <= 100000000)
            {
                int perfeito = 0;
            
            for (int j = 1; j< x;j++)
            {
                if (x % j ==0)
                {
                    perfeito +=j;
                }
            }
            if (perfeito == x)
        {
            Console.WriteLine($"{x} eh perfeito");
        }
        else {
            Console.WriteLine($"{x} nao eh perfeito");
        }
            }
        
        }
        }
        
    }
}
