using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int age = 0;
        int sum = 0;
        double cont = 0.0;
        double average = 0.0;
        
        do
        {
            age = int.Parse(Console.ReadLine());
            
            if(age >= 0)
            {
                sum = sum + age;
                cont++;
            }
            
        }while(age >= 0);
        
        average = sum / cont;
        
        Console.WriteLine ($"{average.ToString("F2", CultureInfo.InvariantCulture)}");

    }

}
