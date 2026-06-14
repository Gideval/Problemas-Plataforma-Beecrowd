using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int N = 0;
        int sum = 0;
        int j = 1;
        
       while(int.Parse(valores[j]) <= 0)
       {
           j++;
       }
       
       N = int.Parse(valores[j]);
        
        for(int i = 0; i < N; i++)
        {
            sum = sum + A + i;
        }
        Console.WriteLine(sum);

    }

}
