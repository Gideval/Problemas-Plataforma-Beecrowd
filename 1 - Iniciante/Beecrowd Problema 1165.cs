using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int X = 0;
        int j = 2;
        int cont = 1;
        List<string> perfectNumbers = new List<string>();
        
        for(int i = 0; i < N; i++)
        {
            X = int.Parse(Console.ReadLine());
            
            while(cont <= 2 && j <= X)
            {
                if(X%j == 0)
                {
                    cont++;
                }
                j++;
            }
            
            if(cont == 2)
            {
                perfectNumbers.Add($"{X} eh primo");
            }
            else
            {
                perfectNumbers.Add($"{X} nao eh primo");
            }
            
            cont = 1;
            j = 2;
        }
        
        foreach(string item in perfectNumbers)
        {
            Console.WriteLine(item);
        }

    }

}
