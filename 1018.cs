using System; 

class URI {

    static void Main(string[] args) { 

 int N,valor;
 int n100=0,n50=0,n20=0,n10=0,n5=0,n2=0,n1=0;
 N=int.Parse(Console.ReadLine());
valor=N;
      n100 = N / 100;
        N %= 100;
        n50 = N / 50;
        N %= 50;
        n20 = N / 20;
        N %= 20;
        n10 = N / 10;
        N %= 10;
        n5 = N / 5;
        N %= 5;
        n2 = N / 2;
        N %= 2;
        n1 = N;
        Console.WriteLine("{0}",valor);
        Console.WriteLine("{0} nota(s) de R$ 100,00",n100);
                Console.WriteLine("{0} nota(s) de R$ 50,00",n50);
                  Console.WriteLine("{0} nota(s) de R$ 20,00",n20);
                    Console.WriteLine("{0} nota(s) de R$ 10,00",n10);
                      Console.WriteLine("{0} nota(s) de R$ 5,00",n5);
                        Console.WriteLine("{0} nota(s) de R$ 2,00",n2);
                          Console.WriteLine("{0} nota(s) de R$ 1,00",n1);
    }

}
