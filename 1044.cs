using System; 

class URI {

    static void Main(string[] args) { 

        int A, B;
            string[] data = Console.ReadLine().Split(' ');
            A = int.Parse(data[0]);
            B = int.Parse(data[1]);

            if (A%B==0||B%A==0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadLine();

    }

}
