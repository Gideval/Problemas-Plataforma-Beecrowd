using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string O = Console.ReadLine();
        double[,] matriz = new double[12,12];
        double soma = 0.0;
        double media = 0.0;
        double cont = 0.0;
        
        for(int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                matriz[i,j] = double.Parse(Console.ReadLine());
                
                if(j < i && i < 11 - j)
                {
                    soma = soma + matriz[i,j];
                    cont++;
                }
            }
        }
        
        if(O == "S")
        {
            Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
        }
        else
        {
            media = soma / cont;
            Console.WriteLine (media.ToString("F2", CultureInfo.InvariantCulture));
        }

    }

}
