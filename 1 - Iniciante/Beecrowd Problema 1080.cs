using System; 

class URI {

    static void Main(string[] args) { 

        int N;
        int maior = 0;
        int posicao = 0;
        
        for(int i = 1; i <= 100; i++)
        {
            N = int.Parse(Console.ReadLine());
            
            if(i == 1)
            {
                maior = N;
                posicao = i;
            }
            else if(N > maior)
            {
                maior = N;
                posicao = i;
            }
        }
        Console.WriteLine (maior);
        Console.WriteLine (posicao);

    }

}
