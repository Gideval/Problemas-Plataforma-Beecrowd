using System; 

class URI {

    static void Main(string[] args) { 

        int X = int.Parse(Console.ReadLine());
        int Z = 0;
        int cont = 0;
        int sum = 0;
        
        do
        {
            Z = int.Parse(Console.ReadLine());
        }while(Z <= X);
        
        while(sum <= Z)
        {
            sum = X + sum;
            X++;
            cont++;
        }
        
        Console.WriteLine (cont);

    }

}
