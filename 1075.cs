using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
            if (N <10000)
            {
                for (int i=1; i<=10000; i++)
            {
                
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
               
            }
            }
            

    }

}
