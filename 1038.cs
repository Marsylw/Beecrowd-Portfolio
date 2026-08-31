using System; 

class URI {

    static void Main(string[] args) { 

       int x, y;
            var data = Console.ReadLine().Split(' ');
            x = int.Parse(data[0]);
            y = int.Parse(data[1]);

            double total;

            if (x == 1)
            {
                total = y * 4;
                Console.WriteLine("Total: R$ {0:f2}", total);
            }
            else if (x == 2)
            {
                total = y * 4.50;
                Console.WriteLine("Total: R$ {0:f2}", total);

            }
            else if (x == 3)
            {
                total = y * 5;
                Console.WriteLine("Total: R$ {0:f2}", total);
            }
            else if (x == 4)
            {
                total = y * 2;
                Console.WriteLine("Total: R$ {0:f2}", total);
            }
            else if (x == 5)
            {
                total = y * 1.50;
                Console.WriteLine("Total: R$ {0:f2}", total);
            }



            Console.ReadLine();
    }

}
