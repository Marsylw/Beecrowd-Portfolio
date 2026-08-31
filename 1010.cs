using System;

namespace Uripractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int product1; int prou1; decimal prop1;

            string[] linha1 = Console.ReadLine().Split(' '); product1 = Convert.ToInt32(linha1[0]); prou1 = Convert.ToInt32(linha1[1]); prop1 = Convert.ToDecimal(linha1[2]);

            int product2; int prou2; decimal prop2;

            string[] linha2 = Console.ReadLine().Split(' '); product2 = Convert.ToInt32(linha2[0]); prou2 = Convert.ToInt32(linha2[1]); prop2 = Convert.ToDecimal(linha2[2]);
            decimal total = (prou1 * prop1) + prou2 * prop2;
            
            Console.WriteLine("VALOR A PAGAR: R$ " + total);


            Console.ReadLine();
        }
    }
}

