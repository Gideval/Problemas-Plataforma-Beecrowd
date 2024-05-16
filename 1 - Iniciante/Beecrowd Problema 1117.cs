using System; 
using System.Collections.Generic;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int cont = 0;
        double sum = 0.0;
        double media = 0.0;
        double nota = 0.0;
        List<string> sequencia = new List<string>();
        
        while(cont != 2)
        {
            nota = double.Parse(Console.ReadLine());
            
            if(nota >= 0.0 && nota < 11)
            {
                cont++;
                sum = sum + nota;
            }
            else
            {
                sequencia.Add("nota invalida");
            }
        }
        media = sum / 2.0;
        
        foreach(string item in sequencia)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine ($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

    }

}
