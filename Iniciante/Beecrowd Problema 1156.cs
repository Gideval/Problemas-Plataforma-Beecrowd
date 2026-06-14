using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double sum = 0.00;
        double i = 1.00;
        int j = 1;
        
        while(i <= 39)
        {
            sum = sum + (i / j);
            
            i = i + 2;
            j = j * 2;
        }
        
        Console.WriteLine ($"{sum.ToString("F2", CultureInfo.InvariantCulture)}");

    }

}
