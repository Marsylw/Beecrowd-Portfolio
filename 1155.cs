using System; 

class URI {

    static void Main(string[] args) { 

        double s = 1.0; // start with 1, the first term
for (int i = 2; i <= 100; i++)
{
    s += 1.0 / i; // just add 1/i
}
Console.WriteLine($"{s:F2}");

    }

}
