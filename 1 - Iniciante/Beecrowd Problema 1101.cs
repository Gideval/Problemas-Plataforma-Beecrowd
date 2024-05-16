using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        List<string> sequencia = new List<string>();
        string[] userInput = new string[2];
        string seqString = "";
        int N, M = 0;
        int sum = 0;

        do
        {
            userInput = Console.ReadLine().Split(' ');
            N = int.Parse(userInput[0]);
            M = int.Parse(userInput[1]);
            
            if(N > M)
            {
                int aux = N;
                N = M;
                M = aux;
            }
            
            if(N > 0)
            {
                for(int j = N; j <= M; j++)
                {
                    sum = sum + j;
                    
                    if(j == N)
                    {
                        seqString = j.ToString();
                    }
                    else
                    {
                        seqString = seqString + " " + j.ToString();
                    }
                }
                seqString = seqString + " Sum=" + sum.ToString();
                
                sequencia.Add(seqString);
                seqString = "";
                sum = 0;
            }
        }while(N > 0);
        
        foreach(string item in sequencia)
        {
            Console.WriteLine(item);
        }
    }

}
