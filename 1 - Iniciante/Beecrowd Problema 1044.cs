using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        int numA, numB;
        numA = Convert.ToInt32(valores[0]);
        numB = Convert.ToInt32(valores[1]);
        
        if(numB % numA == 0 || numA % numB == 0)
        {
            Console.WriteLine ("Sao Multiplos");
        }
        else
        {
            Console.WriteLine ("Nao sao Multiplos");
        }

    }

}
