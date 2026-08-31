using System; 

class URI {

    static void Main(string[] args) { 

        int entrada = int.Parse(Console.ReadLine());


for (int i = 0; i < entrada; i++)
{  
    string[] n = Console.ReadLine().Split(' ');
    int x = int.Parse(n[0]);
    int y = int.Parse(n[1]);
   

    if (y == 0)
    {
        Console.WriteLine("divisao impossivel");
    } else
    {
        double divisao = (double)x / y;
        double arredondado = Math.Round(divisao, 1, MidpointRounding.AwayFromZero);
        Console.WriteLine($"{arredondado:0.0}");
        
    }
    


}

    }

}
