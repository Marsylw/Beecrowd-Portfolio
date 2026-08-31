using System; 

class URI {

    static void Main(string[] args) { 

        int[] vector = new int[5];
            
            int par = 0;
            int impar = 0;
            int positivos = 0;
            int negativos = 0;
            
            

            for (int i =0; i < 5; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i]> 0)
                {
                    positivos++;
                    

                }
                else if (vector[i] < 0)
                {
                    negativos++;
                }
                if(vector[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                
                
            }
            
            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");

    }

}
