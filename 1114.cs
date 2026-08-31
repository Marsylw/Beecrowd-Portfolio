using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1114verdadeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passe = 2002;
            int tentativa = int.Parse(Console.ReadLine());

            while (true)
            {
                if (tentativa != passe)
                {
                    Console.WriteLine("Senha Invalida");
                    tentativa = int.Parse(Console.ReadLine());

                }
                else if (tentativa == passe) 
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
            
            
            }


        }
    }
}

