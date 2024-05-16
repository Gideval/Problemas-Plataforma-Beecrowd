using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        double income, tax, lowerRate;
        income = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
        
        if(income > 4500.00)
        {
            lowerRate = income - 4500.00;
            tax = (lowerRate * 0.28) + 270 + 80;
            
            Console.WriteLine ($"R$ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else if(income > 3000.00)
        {
            lowerRate = income - 3000.00;
            tax = (lowerRate * 0.18) + 80;
            
            Console.WriteLine ($"R$ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else if(income > 2000.00)
        {
            lowerRate = income - 2000.00;
            tax = lowerRate * 0.08;
            
            Console.WriteLine ($"R$ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            Console.WriteLine ("Isento");
        }
    }

}
