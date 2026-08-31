using System; 

class URI {

    static void Main(string[] args) { 

        double[] vector = new double[6];
                double positivos = 0;
                double media = 0;



                for (int i = 0; i < 6; i++)
                {
                    vector[i] = Convert.ToDouble(Console.ReadLine());
                    if (vector[i] > 0)
                    {
                        positivos++;
                        media += vector[i];

                    }


                }
                double average = media / positivos;
                double roundaverage = Math.Round(average, 1);
                Console.WriteLine($"{positivos} valores positivos\n{roundaverage}");

    }

}
