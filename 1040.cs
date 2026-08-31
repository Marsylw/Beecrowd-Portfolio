using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        double N1 = double.Parse(input[0], CultureInfo.InvariantCulture);
        double N2 = double.Parse(input[1], CultureInfo.InvariantCulture);
        double N3 = double.Parse(input[2], CultureInfo.InvariantCulture);
        double N4 = double.Parse(input[3], CultureInfo.InvariantCulture);

        double average = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10.0;
        average = TruncateToOneDecimal(average);

        Console.WriteLine("Media: " + average.ToString("F1", CultureInfo.InvariantCulture));

        if (average >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (average < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            double examGrade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            examGrade = TruncateToOneDecimal(examGrade);

            Console.WriteLine("Nota do exame: " + examGrade.ToString("F1", CultureInfo.InvariantCulture));

            double finalAverage = (average + examGrade) / 2.0;
            finalAverage = TruncateToOneDecimal(finalAverage);

            if (finalAverage >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: " + finalAverage.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

    // Helper method to truncate to one decimal place
    static double TruncateToOneDecimal(double value)
    {
        return Math.Truncate(value * 10) / 10.0;
    }
}

