   
using System; 

class URI {

    static void Main(string[] args) { 

           string[] valor = Console.ReadLine().Split(' ');
            double A = Double.Parse(valor[0]);
            double B = Double.Parse(valor[1]);
            double C = Double.Parse(valor[2]);
            double resultado;
            if (A < (B + C) && B < (A + C) && C < (B + A))
            {
                resultado = (A + B + C);

                Console.WriteLine("Perimetro = {0:f1}", resultado);
            }
            else
            {

                resultado = ((A + B) * C) / 2;
                Console.WriteLine("Area = {0:f1}", resultado);
          
            }

    }

}
