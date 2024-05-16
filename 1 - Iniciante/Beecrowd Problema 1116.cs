using System; 
using System.Collections.Generic;
using System.Globalization;

class URI {

    static void Main(string[] args) { 
int N = int.Parse(Console.ReadLine());
        string[] valores = new string [2];
        double X, Y, divid= 0.0;
        List<string> sequencia = new List<string>();
        
        for(int i = 0; i < N; i++)
        {
            valores = Console.ReadLine().Split(' ');
            X = double.Parse(valores[0]);
            Y = double.Parse(valores[1]);
            
            if(Y == 0)
            {
                sequencia.Add("divisao impossivel");
            }
            else
            {
                divid = X / Y;
                sequencia.Add(divid.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        
        foreach(string item in sequencia)
        {
            Console.WriteLine(item);
        }

    }

}
