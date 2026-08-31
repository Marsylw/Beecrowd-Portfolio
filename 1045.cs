using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split();
double[] lados = Array.ConvertAll(entrada, double.Parse);

// Sort descending so that A is the largest
Array.Sort(lados);
Array.Reverse(lados);

double A = lados[0];
double B = lados[1];
double C = lados[2];
        
 if (A >0 && B >0 && C > 0)
 {
     if (A >= B + C)
{
    Console.WriteLine("NAO FORMA TRIANGULO");
}
else
{
    if (A * A == B * B + C * C)
        Console.WriteLine("TRIANGULO RETANGULO");
    else if (A * A > B * B + C * C)
        Console.WriteLine("TRIANGULO OBTUSANGULO");
    else
        Console.WriteLine("TRIANGULO ACUTANGULO");

    if (A == B && B == C)
        Console.WriteLine("TRIANGULO EQUILATERO");
    else if (A == B || B == C || A == C)
        Console.WriteLine("TRIANGULO ISOSCELES");
}
 }    
        // Triangle check

    
    }
}  
