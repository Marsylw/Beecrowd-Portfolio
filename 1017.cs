using System;

class URI {

    static void Main(string[] args) {
       
        int s=Convert.ToInt32(Console.ReadLine());
        int f=Convert.ToInt32(Console.ReadLine());
        int r=(s*f);
        double j=r/12.0;
        Console.WriteLine(j.ToString("0.000"));
    }

}
