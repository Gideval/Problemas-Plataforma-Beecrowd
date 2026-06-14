using System; 

class URI {

    static void Main(string[] args) { 

        int i = 1; 
        
        while( i <= 9)
        {
            Console.WriteLine ($"I={i} J=7");
            Console.WriteLine ($"I={i} J=6");
            Console.WriteLine ($"I={i} J=5");
            
            i = i + 2;
        }

    }

}
