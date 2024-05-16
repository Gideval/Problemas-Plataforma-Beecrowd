using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = new string[2];
        int vt1, vt2 = 0;
        int opcao = 2;
        int grenais = 0;
        int vitInter = 0;
        int vitGremio = 0;
        int empates = 0;
        
        do 
        {
            grenais++;
            entrada = Console.ReadLine().Split(' ');
            vt1 = int.Parse(entrada[0]);
            vt2 = int.Parse(entrada[1]);
            
            if(vt1 > vt2)
            {
                vitInter++;
            }
            else if(vt1 < vt2)
            {
                vitGremio++;
            }
            else
            {
                empates++;
            }
            
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            opcao = int.Parse(Console.ReadLine());
        }while(opcao != 2);
        
        Console.WriteLine($"{grenais} grenais");
        Console.WriteLine($"Inter:{vitInter}");
        Console.WriteLine($"Gremio:{vitGremio}");
        Console.WriteLine($"Empates:{empates}");
        
        if(vitInter > vitGremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if(vitInter < vitGremio)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }

    }

}
