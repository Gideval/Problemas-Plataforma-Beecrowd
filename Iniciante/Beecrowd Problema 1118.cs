using System; 
using System.Collections.Generic;
using System.Globalization;

class URI {

    static void Main(string[] args) { 
        int cont = 0;
        double sum = 0.0;
        double media = 0.0;
        double nota = 0.0;
        int escolha = 0;
        
        do {
            sum = 0.0;
            cont = 0;
            List<string> sequencia = new List<string>(); // Reinicializa a lista a cada iteração
            
            while(cont < 2) {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(nota >= 0.0 && nota <= 10.0) {
                    cont++;
                    sum += nota;
                } else {
                    sequencia.Add("nota invalida");
                }
            }
            
            media = sum / 2.0;
            
            foreach(string item in sequencia) {
                Console.WriteLine(item);
            }
            
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            
            do {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                escolha = int.Parse(Console.ReadLine());
            } while(escolha != 2 && escolha != 1); // Correção do operador lógico
            
        } while(escolha != 2);

    }

}
