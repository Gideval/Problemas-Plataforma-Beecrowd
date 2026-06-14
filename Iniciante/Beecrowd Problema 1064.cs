using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double[] number = new double[6];
        double average;
        int cont = 0;
        double sum = 0.0;
        
        for(int i = 0; i < 6; i++)
        {
            number[i] = double.Parse(Console.ReadLine());
            
            if(number[i] > 0)
            {
                cont++;
                sum = sum + number[i];
            }
        }
        
        average = sum / cont;
        
        Console.WriteLine ($"{cont} valores positivos");
        Console.WriteLine ($"{average.ToString("F1", CultureInfo.InvariantCulture)}");

    }

}
