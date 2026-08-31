using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        int i = 1;
        while(i<=n)
        {
            
            if (n%i ==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }

    }

}
