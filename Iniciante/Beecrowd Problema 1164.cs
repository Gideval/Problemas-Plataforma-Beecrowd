using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int X = 0;
        int sum = 1;
        List<string> perfectNumbers = new List<string>();
        
        for(int i = 0; i < N; i++)
        {
            X = int.Parse(Console.ReadLine());
            
            for(int j = 2; j < X; j++)
            {
                if(X%j == 0)
                {
                    sum = sum + j;
                }
            }
            
            if(X != sum || X == 1)
            {
                perfectNumbers.Add($"{X} nao eh perfeito");
            }
            else
            {
                perfectNumbers.Add($"{X} eh perfeito");
            }
            
            sum = 1;
        }
        
        foreach(string item in perfectNumbers)
        {
            Console.WriteLine(item);
        }

    }

}
