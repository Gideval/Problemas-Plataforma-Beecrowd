using System; 

class URI {

    static void Main(string[] args) { 

        double[] number = new double[6];
        int cont = 0;
        
        for(int i = 0; i < 6; i++)
        {
            number[i] = double.Parse(Console.ReadLine());
            
            if(number[i] > 0)
            {
                cont++;
            }
        }
        
        Console.WriteLine ($"{cont} valores positivos");

    }

}
