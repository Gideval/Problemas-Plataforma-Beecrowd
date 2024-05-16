using System; 

class URI {

    static void Main(string[] args) { 

        int valor = 0;
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        
        do
        {
            valor = int.Parse(Console.ReadLine());
            
            if(valor == 1)
            {
                alcool++;
            }
            else if(valor == 2)
            {
                gasolina++;
            }
            else if(valor == 3)
            {
                diesel++;
            }
            
        }while(valor != 4);
        
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");

    }

}
