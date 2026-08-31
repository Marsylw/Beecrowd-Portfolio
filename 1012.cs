using System; 

class URI {

static void Main(string[] args) { 
string[] numeros;
double a,b,c;
double pi=3.14159;
numeros=Console.ReadLine().Split(' ');
a=Double.Parse(numeros[0]);
b=Double.Parse(numeros[1]);
c=Double.Parse(numeros[2]);
Console.WriteLine("TRIANGULO: {0:f3}", a * c / 2);
  Console.WriteLine("CIRCULO: {0:f3}", c * c * pi);
  Console.WriteLine("TRAPEZIO: {0:f3}", c * (a + b) / 2);
  Console.WriteLine("QUADRADO: {0:f3}", b * b);
Console.WriteLine("RETANGULO: {0:f3}", a * b);
    }

}
