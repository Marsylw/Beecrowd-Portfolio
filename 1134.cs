using System; 

class URI {

    static void Main(string[] args) { 

       int alcohol = 0;
int gasoline = 0;
int diesel = 0;
int numero; 


while (true)
{
   

    numero = int.Parse(Console.ReadLine());
    
    if (numero == 1)
    {
        alcohol++;

    }
    else if (numero == 2)
    {
        gasoline++;
    }
    else if (numero == 3) 
    {
        diesel++;
    }
    else if(numero == 4) { break; }
    else { continue; }
    

}
Console.WriteLine($"MUITO OBRIGADO");
Console.WriteLine($"Alcool: {alcohol}\nGasolina: {gasoline}\nDiesel: {diesel}");
    }

}
