using System; 

class URI {

    static void Main(string[] args) { 

       int N = int.Parse(Console.ReadLine());
        int[] number = new int[N];
        
        for(int i = 0; i < N; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }
        
        for(int i = 0; i < N; i++)
        {
            if(number[i] == 0)
            {
                Console.WriteLine ("NULL");
            }
            else if(number[i]%2 == 0)
            {
                if(number[i] > 0)
                {
                    Console.WriteLine ("EVEN POSITIVE");
                }
                else
                {
                    Console.WriteLine ("EVEN NEGATIVE");
                }
            }
            else
            {
                if(number[i] > 0)
                {
                    Console.WriteLine ("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine ("ODD NEGATIVE");
                }
            }
        }
    }

}
