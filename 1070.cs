using System; 

class URI {

    static void Main(string[] args) { 

       int value;
            value = int.Parse(Console.ReadLine());
            int[] vector = new int[value];
            
            int oddtotal = value + 20;
            int odd = 0;
            
           
            

            for (int i =value; i <=oddtotal; i++)
            {
               
                if ( i % 2 != 0 )
                {
                    odd++;
                   if (odd < 7)
                    {
                        Console.WriteLine(i);
                    }
                }
               
            }

    }

}
