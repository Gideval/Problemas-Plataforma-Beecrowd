using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());;
        int cont = 0;
        
        while(cont < 6)
        {
            if(X%2 != 0)
            {
                Console.WriteLine (X);
                cont++;
            }
            X++;
        }

    }

}
