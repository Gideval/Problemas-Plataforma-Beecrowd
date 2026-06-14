using System; 

class URI {

    static void Main(string[] args) { 

        int[] X = new int[10];
        int x = 0;
        
        for(int i = 0; i < 10; i++)
        {
            x = int.Parse(Console.ReadLine());
            
            if(x <= 0)
            {
                x = 1;
            }
            
            X[i] = x;
        }
        
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"X[{i}] = {X[i]}");
        }

    }

}
