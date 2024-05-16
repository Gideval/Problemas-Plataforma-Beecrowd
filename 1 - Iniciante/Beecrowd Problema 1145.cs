using System; 

class URI {

    static void Main(string[] args) { 

        string[] valor = Console.ReadLine().Split(' ');
        int X = int.Parse(valor[0]);
        int Y = int.Parse(valor[1]);
        int i = 1;
        int j = 1;
        
        while(i <= Y)
        {
            while(j <= X)
            {
                if(j == X)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write($"{i} ");
                }
                i++;
                j++;
            }
            
            j = 1;
        }

    }

}
