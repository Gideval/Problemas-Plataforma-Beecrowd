using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int password = int.Parse(Console.ReadLine());
        List<string> sequencia = new List<string>();
        
        do
        {
            sequencia.Add("Senha Invalida");
            password = int.Parse(Console.ReadLine());
        }
        while(password != 2002);
        
        sequencia.Add("Acesso Permitido");
        
        foreach(string item in sequencia)
        {
            Console.WriteLine(item);
        }

    }

}
