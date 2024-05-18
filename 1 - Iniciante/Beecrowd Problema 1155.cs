using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double S = 0.00;
        
        for(int i = 1; i <= 100; i++)
        {
            S = S + (1.00 / i);
        }
        
        Console.WriteLine ($"{S.ToString("F2", CultureInfo.InvariantCulture)}");

    }

}
