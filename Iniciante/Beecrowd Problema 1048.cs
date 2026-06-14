using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        
        double wage, newWage, readjustment;
        string percentage;
        
        wage = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
        
        if(wage > 0.0 && wage <= 400.00)
        {
            percentage = "15 %";
            newWage = (wage * 0.15) + wage;
            readjustment = wage * 0.15;
        }
        else if(wage > 400.00 && wage <= 800.00)
        {
            percentage = "12 %";
            newWage = (wage * 0.12) + wage;
            readjustment = wage * 0.12;
        }
        else if(wage > 800.00 && wage <= 1200.00)
        {
            percentage = "10 %";
            newWage = (wage * 0.1) + wage;
            readjustment = wage * 0.1;
        }
        else if(wage > 1200.00 && wage <= 2000.00)
        {
            percentage = "7 %";
            newWage = (wage * 0.07) + wage;
            readjustment = wage * 0.07;
        }
        else
        {
            percentage = "4 %";
            newWage = (wage * 0.04) + wage;
            readjustment = wage * 0.04;
        }
        
        Console.WriteLine ($"Novo salario: {newWage.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine ($"Reajuste ganho: {readjustment.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine ($"Em percentual: {percentage}");

    }

}
