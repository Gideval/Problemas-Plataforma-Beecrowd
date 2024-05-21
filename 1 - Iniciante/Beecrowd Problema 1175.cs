using System; 

class URI {

    static void Main(string[] args) { 

        int[] N = new int[20];
        
        for(int i = 19; i >= 0; i--)
        {
            N[i] = int.Parse(Console.ReadLine());
        }
        
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine($"N[{i}] = {N[i]}");
        }

    }

}
