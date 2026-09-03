using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int x = int.Parse(Console.ReadLine());
      int y = int.Parse(Console.ReadLine());
      int comeco = Math.Min(x, y);
      int final = Math.Max(x, y);
      int divi = 0;

      for (int i= comeco; i<=final; i++){
        if (i % 13 != 0){
          divi +=i;
        }
      }
        Console.WriteLine (divi);
    }
}
