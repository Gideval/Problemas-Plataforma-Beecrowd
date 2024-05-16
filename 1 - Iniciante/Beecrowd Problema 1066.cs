using System; 

class URI {

    static void Main(string[] args) { 

       int[] number = new int[5];
        int contPositive = 0;
        int contNegative = 0;
        int contOdd = 0;
        int contPair = 0;
        
        for(int i = 0; i < 5; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
            
            if(number[i]%2 == 0)
            {
                contPair++;
            }
            else
            {
                contOdd++;
            }
            
            if(number[i] > 0)
            {
                contPositive++;
            }
            else if(number[i] < 0)
            {
                contNegative++;
            }
        }
        
        Console.WriteLine ($"{contPair} valor(es) par(es)");
        Console.WriteLine ($"{contOdd} valor(es) impar(es)");
        Console.WriteLine ($"{contPositive} valor(es) positivo(s)");
        Console.WriteLine ($"{contNegative} valor(es) negativo(s)");
	}
}
