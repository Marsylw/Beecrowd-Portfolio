using System; 

class URI {

    static void Main(string[] args) { 

        int s = int.Parse(Console.ReadLine());

for (int i = 0; i < s; i++)
{
    string[] entrada = Console.ReadLine().Split(' ');
    int x = int.Parse(entrada[0]);
    int y = int.Parse(entrada[1]);

    int soma = 0;
    int count = 0;
    int current = x;

    while (count < y)
    {
        if (current % 2 != 0) // is odd
        {
            soma += current;
            count++;
        }
        current++;
    }

    Console.WriteLine(soma);
}

    }

}
