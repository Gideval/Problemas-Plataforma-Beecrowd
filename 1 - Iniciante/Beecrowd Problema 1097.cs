using System; 

class URI {

    static void Main(string[] args) { 

        int i = 1; 
        int j = 7;
        
        while( i <= 9)
        {
            Console.WriteLine ($"I={i} J={j}");
            Console.WriteLine ($"I={i} J={j-1}");
            Console.WriteLine ($"I={i} J={j-2}");
            
            i = i + 2;
            j = j + 2;
        }

    }

}
