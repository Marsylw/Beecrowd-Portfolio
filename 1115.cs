using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true){
          string[] input = Console.ReadLine().Split(' ');
          int primeiro = int.Parse(input[0]);
          int segundo = int.Parse(input[1]);

          if (primeiro == 0 || segundo == 0){
            break;
          } else {
            if(primeiro<0 && segundo >0){
              Console.WriteLine("segundo");
            } else if(primeiro>0 && segundo >0){
              Console.WriteLine("primeiro");
            } else if(primeiro <0 && segundo <0){
              Console.WriteLine("terceiro");
            }else if (primeiro >0 && segundo <0){
              Console.WriteLine("quarto");
            }
          }
        }
    }
}
