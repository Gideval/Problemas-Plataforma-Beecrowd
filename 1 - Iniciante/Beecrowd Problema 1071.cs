using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        int sum = 0;
        
        if(X > Y)
        {
            int aux = Y;
            Y = X;
            X = aux;
        }
        
        while(X < Y)
        {
            X++;
            
            if(X%2 != 0 && X < Y)
            {
                sum = sum + X;
            }
        }
        
        Console.WriteLine (sum);

    }

}
