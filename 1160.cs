using System;

public class beecrowd 
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());   

        for (int caso = 0; caso < t; caso++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int pa = int.Parse(entrada[0]);
            int pb = int.Parse(entrada[1]);
            double g1 = double.Parse(entrada[2]);
            double g2 = double.Parse(entrada[3]);

            int anos = 0;
            while (pa <= pb)
            {
                pa += (int)(pa * g1 / 100);
                pb += (int)(pb * g2 / 100);
                anos++;

                if (anos > 100) break;
            }

            if (anos > 100)
                Console.WriteLine("Mais de 1 seculo.");
            else
                Console.WriteLine($"{anos} anos.");
        }
    }
}
