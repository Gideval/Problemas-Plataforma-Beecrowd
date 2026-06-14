using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine()); 
        string[] userInput = new string[2];
        int X, Y = 0;
        int sum = 0;
        int[] vetSum = new int[N];
        
        for(int i = 0; i < N; i++)
        {
            userInput = Console.ReadLine().Split(' ');
            X = int.Parse(userInput[0]);
            Y = int.Parse(userInput[1]);
            
            if(X > Y)
            {
                int aux = X;
                X = Y;
                Y = aux;
            }
            
            for(int j = X +1; j < Y; j++)
            {
                if(j%2 != 0)
                {
                    sum = sum + j;
                }
            }
            
            vetSum[i] = sum;
            sum = 0;
        }
        
        for(int i = 0; i < N; i++)
        {
            Console.WriteLine (vetSum[i]);
        }
    }

}
