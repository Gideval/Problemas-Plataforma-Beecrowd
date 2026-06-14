using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        List<string> sequencia = new List<string>();
        string[] userInput = new string[2];
        int X, Y = 0;

        do
        {
            userInput = Console.ReadLine().Split(' ');
            X = int.Parse(userInput[0]);
            Y = int.Parse(userInput[1]);
            
            if(X != Y)
            {
                if(X < Y)
                {
                    sequencia.Add("Crescente");
                }
                else
                {
                    sequencia.Add("Decrescente");
                }
            }
            
        }while(X != Y);
        
        foreach(string item in sequencia)
        {
            Console.WriteLine(item);
        }

    }

}
