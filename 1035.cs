using System;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
           int A, B, C, D;
            string[] data = Console.ReadLine().Split(' ') ;
            

            A = int.Parse(data[0]);
            B = int.Parse(data[1]);
            C = int.Parse(data[2]);
            D = int.Parse(data[3]);

            int soma1, soma2;
            soma1 = C + D;
            soma2 = A + B;

            if ( B > C && D > A && soma1 > soma2 && C >0 && D >0 && (A %2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            
            
            else
            {
                Console.WriteLine("Valores nao aceitos");
                

            }


            Console.ReadLine();
        }
    }
}

