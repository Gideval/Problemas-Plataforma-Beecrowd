using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int L = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        double number = 0.0;
        double[,] matriz = new double[12,12];
        double soma = 0.0;
        double media = 0.0;
        
        
        for(int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                number = double.Parse(Console.ReadLine());
                
                matriz[i,j] = number;
                
                if(i == L)
                {
                    soma = soma + number;
                }
            }
        }
        
        if(T == "S")
        {
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            media = soma / 12.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }

    }

}
