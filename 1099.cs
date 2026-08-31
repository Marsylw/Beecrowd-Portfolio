using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
int soma = 0;

for (int i = 0; i < n; i++)
{
    string numeros = Console.ReadLine();
    string[] partes = numeros.Split(' ');
    int numeroum = int.Parse(partes[0]);
    int numerodois = int.Parse(partes[1]);

    int inicio = Math.Min(numeroum, numerodois) + 1;
    int fim = Math.Max(numeroum, numerodois) -1;

    

    for (int j = inicio; j <= fim; j++) 
    {
    
        
         if (j % 2!=0)
          {
              soma+=j;
          }
    }

     Console.WriteLine(soma);
    soma = 0;
}
    }

}
