using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string entrada = Console.ReadLine();
        string[] partes = entrada.Split();
int h1 = int.Parse(partes[0]);
int m1 = int.Parse(partes[1]);
int h2 = int.Parse(partes[2]);
int m2 = int.Parse(partes[3]);
        int start = h1 * 60 + m1;
        int end = h2 * 60 + m2;

        if (end <= start)
        {
            end += 24 * 60;
        }

        int duration = end - start;
        int horas = duration / 60;
        int minutos = duration % 60;

        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
    }
}
