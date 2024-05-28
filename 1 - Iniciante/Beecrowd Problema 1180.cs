using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        string[] X = Console.ReadLine().Split(' ');
        int number = 0;
        int[] menor = new int[2];
        
        for(int i = 0; i < N; i++)
        {
            number = int.Parse(X[i]);
            
            if(i == 0)
            {
                menor[0] = number;
                menor[1] = i;
            }
            else if(number < menor[0])
            {
                menor[0] = number;
                menor[1] = i;
            }
        }
        
        Console.WriteLine($"Menor valor: {menor[0]}");
        Console.WriteLine($"Posicao: {menor[1]}");

    }

}
