using System; 

class URI {

    static void Main(string[] args) { 

       int i = 1;
int j = 7;
int primeiro = 0;

while (true)
{
    if (i > 9) { break; }
    Console.WriteLine($"I={i} J={j}");

    primeiro++; j--;

    if (primeiro == 3)
    {
        i += 2; j += 5; primeiro = 0;
    }


}


    }

}
