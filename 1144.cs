using System; 

class URI {

    static void Main(string[] args) { 

       int n = int.Parse(Console.ReadLine());
int conta = 1; 
double resultado = conta * conta;
double resultado2 = conta * conta * conta;
int checa = 0;

while (n >1 && n < 1000)
{
    Console.WriteLine($"{conta} {resultado} {resultado2}");
    Console.WriteLine($"{conta} {resultado + 1} {resultado2 +1}");

    conta += 1;
    checa += 1;
    resultado = conta * conta;
    resultado2 = conta * conta * conta;
    if (checa >= n) 
    {
        break;
    }
}

    }

}
