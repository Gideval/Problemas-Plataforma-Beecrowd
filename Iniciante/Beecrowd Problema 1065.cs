using System; 

class URI {

    static void Main(string[] args) { 

        int[] number = new int[5];
        int cont = 0;
        
        for(int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
            
            if(number[i]%2 == 0)
            {
                cont++;
            }
        }
        
        Console.WriteLine ($"{cont} valores pares");

    }

}
