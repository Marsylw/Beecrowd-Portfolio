using System; 

class URI {

    static void Main(string[] args) { 

double salario, salario2,percentual;
            salario = Double.Parse(Console.ReadLine());
            if (salario >= 0 && salario <= 400.00)
            {
                salario2 = (salario * 0.15);
                salario = salario + salario2;
                percentual=15;
                Console.WriteLine("Novo salario: {0:f2}\nReajuste ganho: {1:f2}\nEm percentual: {2} %", salario, salario2,percentual);
            }
            else
            if (salario >= 400.01 && salario <= 800.00)
            {
                salario2 = (salario * 0.12);
                salario = salario + salario2;
                percentual=12;
                Console.WriteLine("Novo salario: {0:f2}\nReajuste ganho: {1:f2}\nEm percentual: {2} %", salario, salario2,percentual);
            }
            else
            if (salario >= 800.01 && salario <= 1200.00)
            {
                salario2 = (salario * 0.10);
                salario = salario + salario2;
                percentual=10;
                Console.WriteLine("Novo salario: {0:f2}\nReajuste ganho: {1:f2}\nEm percentual: {2} %", salario, salario2,percentual);
            }
            else
            if (salario >= 1200.01 && salario <= 2000.00)
            {
                salario2 = (salario * 0.07);
                salario = salario + salario2;
                               percentual=7;
                Console.WriteLine("Novo salario: {0:f2}\nReajuste ganho: {1:f2}\nEm percentual: {2} %", salario, salario2,percentual);
            }
            else
            if (salario > 2000.00)
            {
                salario2 = (salario * 0.04);
                salario = salario + salario2;
                                percentual=4;
                Console.WriteLine("Novo salario: {0:f2}\nReajuste ganho: {1:f2}\nEm percentual: {2} %", salario, salario2,percentual);
    }

    }

}
