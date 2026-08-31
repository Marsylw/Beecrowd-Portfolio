using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true){
            
            int x = int.Parse(Console.ReadLine());
            if (x ==0){break;}
            else
            {
                int soma = 0; int conta = 0;
                for ( int i=x; ; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma += i;
                        conta ++;
                    }
                    if (conta == 5)
                    {
                        Console.WriteLine(soma);
                        break;
                        
                    }
                }
                   
                
            }
            
            
        }
        
    }
}
