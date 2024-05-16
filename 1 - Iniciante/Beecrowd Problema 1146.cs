using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int X = 1;
        int i = 1;
        string sequencia = "";
        List<string> numeros = new List<string>();
        
        do
        {
            X = int.Parse(Console.ReadLine());
            
            while(i <= X)
            {
                if(i == 1)
                {
                    sequencia = $"{i}";
                }
                else
                {
                    sequencia = sequencia + " "+ $"{i}";
                }
        
                i++;
            }
            if(X > 0)
            {
                numeros.Add(sequencia);
            }
            
            i = 1;
        }while(X != 0);
        
        foreach(string item in numeros)
        {
            Console.WriteLine(item);
        }

    }

}
