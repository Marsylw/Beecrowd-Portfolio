using System; 

class URI {

    static void Main(string[] args) { 

        double incremento = 2;
        double s = 1;
        
        for (int i = 3; i <=39; i+=2)
        {
            double calculo = i/(double)incremento;
            incremento *= 2;
            s += calculo;
        }
        Console.WriteLine($"{s:f2}");

    }

}
