using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int X = 0;
        int sum = 0;
        List<int> somas = new List<int>();
        
        do
        {
            X = int.Parse(Console.ReadLine());
            
            if(X != 0)
            {
                for(int i = 0; i < 5; i++)
                {
                    if(X%2 != 0)
                    {
                        X++;
                    }
                    sum = sum + X;
                    X = X + 2;
                }
                
                somas.Add(sum);
            }
            
            sum = 0;
        }while(X != 0);
        
        foreach(int item in somas)
        {
            Console.WriteLine(item);
        }

    }

}
