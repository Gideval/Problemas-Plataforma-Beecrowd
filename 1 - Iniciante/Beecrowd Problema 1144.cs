using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        int i = 1;
        int cont = 1;
        int quadrado = 0;
        int mult = 0;
        
        while(i <= N)
        {
            if(cont == 1)
            {
                quadrado = i * i;
                mult = i * quadrado;
            }
            else
            {
                quadrado++;
                mult++;
            }
            Console.WriteLine ($"{i} {quadrado} {mult}");
            
            if(cont == 2)
            {
                i++;
                cont = 1;
            }
            else
            {
                cont++;
            }
        }

    }

}
