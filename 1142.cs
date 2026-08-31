using System; 

class URI {

    static void Main(string[] args) { 

int vezes = int.Parse(Console.ReadLine());
int contador = 1;

for (int i = 0; i < vezes; i++) 
{
    Console.WriteLine($"{contador} {contador + 1} {contador + 2} PUM");
    contador += 4;
}


    }

}
