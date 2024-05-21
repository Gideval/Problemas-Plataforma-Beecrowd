using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double[] X = new double[100];
        
        for(int i = 0; i < 100; i++)
        {
            X[i] = double.Parse(Console.ReadLine());
        }
        
        for(int i = 0; i < 100; i++)
        {
            if(X[i] <= 10)
            {
                Console.WriteLine($"A[{i}] = {X[i].ToString("F1", CultureInfo.InvariantCulture)}");
            }
            
        }

    }

}
