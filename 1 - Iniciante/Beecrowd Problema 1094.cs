using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

       int numberCobaias = int.Parse(Console.ReadLine());
        string[] cobaia = new string[2];
        
        int totalCobais = 0;
        int numberCoelhos = 0;
        double percentCoelhos = 0.0;
        int numberRatos = 0;
        double percentRatos = 0.0;
        int numberSapos = 0;
        double percentSapos = 0.0;
        
        for(int i = 0; i < numberCobaias; i++)
        {
            cobaia = Console.ReadLine().Split(' '); 
            totalCobais = totalCobais + int.Parse(cobaia[0]);
            
            if(cobaia[1] == "C")
            {
                numberCoelhos = numberCoelhos + int.Parse(cobaia[0]);
            }
            else if(cobaia[1] == "R")
            {
                numberRatos = numberRatos + int.Parse(cobaia[0]);
            }
            else
            {
                numberSapos = numberSapos + int.Parse(cobaia[0]);
            }
        }
        percentCoelhos = (numberCoelhos * 100.00) / totalCobais;
        percentRatos = (numberRatos * 100.00) / totalCobais;
        percentSapos = (numberSapos * 100.00) / totalCobais;
        
        Console.WriteLine ($"Total: {totalCobais} cobaias");
        Console.WriteLine ($"Total de coelhos: {numberCoelhos}");
        Console.WriteLine ($"Total de ratos: {numberRatos}");
         Console.WriteLine ($"Total de sapos: {numberSapos}");
        
        Console.WriteLine ($"Percentual de coelhos: {percentCoelhos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine ($"Percentual de ratos: {percentRatos.ToString("F2", CultureInfo.InvariantCulture)} %");
        Console.WriteLine ($"Percentual de sapos: {percentSapos.ToString("F2", CultureInfo.InvariantCulture)} %");
    }

}
