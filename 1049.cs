using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string categoria1, categoria2, categoria3;
            categoria1 = Console.ReadLine();
            categoria2 = Console.ReadLine();
            categoria3 = Console.ReadLine();

            if (categoria1 == "vertebrado")
            {
                if (categoria2 == "ave")
                {
                    if (categoria3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (categoria3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (categoria2 == "mamifero")
                {
                    if (categoria3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (categoria3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (categoria1 == "invertebrado")
            {
                if (categoria2 == "inseto")
                {
                    if (categoria3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (categoria3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (categoria2 == "anelideo")
                {
                    if (categoria3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (categoria3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }

            
        
    }
}
