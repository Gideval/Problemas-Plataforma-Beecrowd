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
        
        for(int i = X; i <= Y; i++)
        {
            if(i%13 != 0)
            {
                sum = sum + i;
            }
        }
        
        Console.WriteLine(sum);

    }

}
