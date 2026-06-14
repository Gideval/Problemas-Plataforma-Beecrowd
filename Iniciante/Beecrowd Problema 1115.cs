using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

       string[] coordenada = new string [2];
        int X, Y = 0;
        List<string> sequencia = new List<string>();
        
        do
        {
            coordenada = Console.ReadLine().Split(' ');
            X = int.Parse(coordenada[0]);
            Y = int.Parse(coordenada[1]);
            
            if(X > 0 && Y > 0)
            {
                sequencia.Add("primeiro");
            }
            else if(X < 0 && Y > 0)
            {
                sequencia.Add("segundo");
            }
            else if(X < 0 && Y < 0)
            {
                sequencia.Add("terceiro");
            }
            else if(X > 0 && Y < 0)
            {
                sequencia.Add("quarto");
            }
            
        }
        while(X != 0 || Y != 0);
        
        foreach(string item in sequencia)
        {
            Console.WriteLine(item);
        }

    }

}
