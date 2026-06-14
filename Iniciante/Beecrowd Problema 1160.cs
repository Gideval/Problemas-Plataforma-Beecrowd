using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int T = int.Parse(Console.ReadLine());
        string[] valores = new string[4];
        int PA = 0;
        int PB = 0;
        double GA = 0.0;
        double GB = 0.0;
        int cont = 0;
        List<string> time = new List<string>();
        
        for(int i = 0; i < T; i++)
        {
            valores = Console.ReadLine().Split(' ');
            PA = int.Parse(valores[0]);
            PB = int.Parse(valores[1]);
            GA = double.Parse(valores[2]);
            GB = double.Parse(valores[3]);
            
            while(PA <= PB && cont <= 100)
            {
                PA = (int)(PA + (PA * (GA/100)));
                PB = (int)(PB + (PB * (GB/100)));
                
                cont++;
            }
            
            if(cont > 100)
            {
                time.Add("Mais de 1 seculo.");
            }
            else
            {
                time.Add($"{cont} anos.");
            }
            
            cont = 0;
        }
        
        foreach(string item in time)
        {
            Console.WriteLine(item);
        }

    }

}
