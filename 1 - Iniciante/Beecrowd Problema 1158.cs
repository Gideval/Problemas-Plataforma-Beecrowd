using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        string[] valores = new string[2];
        int X = 0;
        int Y = 0;
        int cont = 1;
        int sum = 0;
        List<int> somas = new List<int>();
        
        for(int i = 0; i < N; i++)
        {
            valores = Console.ReadLine().Split(' ');
            X = int.Parse(valores[0]);
            Y = int.Parse(valores[1]);
            
            while(cont <= Y)
            {
                if(X%2 == 0)
                {
                    X++;
                }
                sum = sum + X;
                X = X + 2;
                
                cont++;
            }
            somas.Add(sum);
            sum = 0;
            cont = 1;
        }
        
        foreach(int item in somas)
        {
            Console.WriteLine(item);
        }

    }

}
