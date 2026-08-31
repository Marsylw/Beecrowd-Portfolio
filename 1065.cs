using System; 

class URI {

    static void Main(string[] args) { 

        int[] vector = new int[5];

            int even = 0;



            for (int i = 0; i < 5; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());

                if(vector[i] % 2 == 0)
                {
                    even++;
                }

            }

            
            Console.WriteLine($"{even} valores pares");

    }

}
