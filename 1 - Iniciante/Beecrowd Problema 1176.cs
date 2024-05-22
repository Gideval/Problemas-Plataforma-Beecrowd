using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int T = int.Parse(Console.ReadLine());
        int N = 0;
        long ant = 0;
        long atual = 1;
        long aux = atual;
        List<string> fibo = new List<string>();
        
        for(int i = 0; i < T; i++)
        {
            N = int.Parse(Console.ReadLine());
            
            if(N == 0)
            {
                fibo.Add("Fib(0) = 0");
            }
            else if(N == 1)
            {
                fibo.Add("Fib(1) = 1");
            }
            else
            {
                for(int j = 2; j <= N; j++)
                {
                    aux = atual;
                    atual = ant + atual;
                    ant = aux;
                }
                fibo.Add($"Fib({N}) = {atual}");
                
                ant = 0;
                atual = 1;
            }

        }
        
        foreach(string item in fibo)
        {
            Console.WriteLine(item);
        }

    }

}
