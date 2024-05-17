using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int previous = 0;
        int current = 1;
        int aux = previous;
        string fibonacci = "0 1";
        
        for(int i = 2; i < N; i++)
        {
            aux = previous + current;
            previous = current;
            current = aux;
            
            fibonacci = fibonacci + " " + $"{current}";
        }
        
        Console.WriteLine (fibonacci);

    }

}
