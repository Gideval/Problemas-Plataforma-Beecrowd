using System; 

class URI {

    static void Main(string[] args) { 

        int i = 0; 
        int j = 1;
        int cont = 0;
        
        while( i < 2)
        {
            if(cont == 10)
            {
                cont = 0;
                i = i + 1;
                j = j + 1;
            }
            
            if(cont == 0)
            {
                Console.WriteLine ($"I={i} J={j}");
                Console.WriteLine ($"I={i} J={j+1}");
                Console.WriteLine ($"I={i} J={j+2}");
            }
            else
            {
                Console.WriteLine ($"I={i}.{cont} J={j}.{cont}");
                Console.WriteLine ($"I={i}.{cont} J={j+1}.{cont}");
                Console.WriteLine ($"I={i}.{cont} J={j+2}.{cont}");
            }
            
            cont = cont + 2;
        }

    }

}
