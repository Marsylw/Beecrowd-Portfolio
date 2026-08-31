using System; 

class URI {

    static void Main(string[] args) { 

      double x, y;
            var data = Console.ReadLine().Split(' ');
            x = double.Parse(data[0]);
            y = double.Parse(data[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");

            }
            
            Console.ReadLine();
    }

}
