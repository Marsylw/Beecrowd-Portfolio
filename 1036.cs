using System; 

class URI {

    static void Main(string[] args) { 
double a, b, c, r1, r2, del;
        string[] valores = Console.ReadLine().Split(' ');
        a = Double.Parse(valores[0]);
        b = Double.Parse(valores[1]);
        c = Double.Parse(valores[2]);
        del = (b * b) - (4 * a * c);
        r1 = (-b + Math.Sqrt(del)) / (2 * a);
        r2 = (-b - Math.Sqrt(del)) / (2 * a);
        if (a != 0 && del > 0)
        {
            Console.WriteLine("R1 = {0:f5}\nR2 = {1:f5}", r1, r2);
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
        }
    }

}
