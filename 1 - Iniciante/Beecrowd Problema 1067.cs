using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());;
        int i = 1;
        
        while( i < X)
        {
            Console.WriteLine (i);
            
            i = i + 2;
        }
        
        if(X%2 != 0)
        {
            Console.WriteLine (X);
        }

    }

}
