using System; 

class URI {

    static void Main(string[] args) { 

        int maiornumero = int.MinValue;
int posicao = 1;

for (int i = 1; i <= 100; i++)
{

    int numero = int.Parse(Console.ReadLine());
    
    if (numero > maiornumero)
    {
        maiornumero = numero;
        posicao = i;

    }
    

}

Console.WriteLine(maiornumero);
Console.WriteLine(posicao);
    }

}
