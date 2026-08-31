using System; 

class URI {

    static void Main(string[] args) { 

       double i = 0;
double j = 1;


while (true)
{
    if (i > 2) { break; }
    Console.WriteLine($"I={i} J={j}");
    Console.WriteLine($"I={i} J={j + 1}");
    Console.WriteLine($"I={i} J={j + 2}");

        i += 0.2; j += 0.2;
       

}

    }

}
