using System; 

class URI {

    static void Main(string[] args) { 

        int T = int.Parse(Console.ReadLine());
        int[] N = new int[1000];
        int i = 0;
        int k = 0;
        
        while(i < 1000)
        {
            while(k < T && i < 1000)
            {
                N[i] = k;
                k++;
                i++;
            }
            k = 0;
        }
        
        for(int j = 0; j < 1000; j++)
        {
            Console.WriteLine($"N[{j}] = {N[j]}");
        }

    }

}
