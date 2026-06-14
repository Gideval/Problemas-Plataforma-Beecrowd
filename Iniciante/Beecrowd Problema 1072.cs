using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int contInterval = 0;
        int contOutInterval = 0;
        int userInput;
        
        for(int i = 0; i < N; i++)
        {
            userInput = int.Parse(Console.ReadLine());
            
            if(userInput >= 10 && userInput <= 20)
            {
                contInterval++;
            }
            else
            {
                contOutInterval++;
            }
        }
        
        Console.WriteLine ($"{contInterval} in");
        Console.WriteLine ($"{contOutInterval} out");

    }

}
