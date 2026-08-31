using System; 

class URI {

    static void Main(string[] args) { 

       int n= int.Parse(Console.ReadLine());
int contador = 1;

if(n>1 && n < 1000)
{
    for (int i = 0; i < n; i++) 
{ 
    Console.WriteLine($"{contador} {contador * contador} {contador * contador * contador}");
    contador++;
}

}

    }

}
