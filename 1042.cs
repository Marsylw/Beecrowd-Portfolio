using System; 

class URI {

    static void Main(string[] args) { 

        int a, b, c;
            string[] data = Console.ReadLine().Split(' ');
            a = int.Parse(data[0]);
            b = int.Parse(data[1]);
            c = int.Parse(data[2]);

            int[] numbers = { a, b, c };

            Array.Sort(numbers);
            for (int i=0; i<numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\n");
            }

            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


    }

}
