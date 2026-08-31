using System; 

class URI {

    static void Main(string[] args) { 

       int a, b, c, maior;
            var valor = Console.ReadLine().Split(' ');
            a = int.Parse(valor[0]);
            b = int.Parse(valor[1]);
            c = int.Parse(valor[2]);
            maior = (a + b + Math.Abs(a - b)) / 2;
            maior = (maior + c + Math.Abs(maior - c)) / 2;


            Console.WriteLine("{0} eh o maior", maior);

            Console.ReadLine();
    }

}
