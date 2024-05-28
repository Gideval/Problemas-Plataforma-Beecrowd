using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int x = 0;
        List<string> lista = new List<string>();
        int?[] par = new int?[5];
        int?[] impar = new int?[5];
        int contPar = 0;
        int contImpar = 0;
        
        for(int i = 0; i < 15; i++)
        {
            x = int.Parse(Console.ReadLine());
            
            if(x % 2 == 0)
            {
                par[contPar] = x;
                contPar++;
            }
            else
            {
                impar[contImpar] = x;
                contImpar++;
            }
            
            if(contPar == 5)
            {
                for(int j = 0; j < 5; j++)
                {
                    lista.Add($"par[{j}] = {par[j]}");
                    par[j] = null;
                }
                contPar = 0;
            }
            
            if(contImpar == 5)
            {
                for(int j = 0; j < 5; j++)
                {
                    lista.Add($"impar[{j}] = {impar[j]}");
                    impar[j] = null;
                }
                contImpar = 0;
            }
        }
        
        
        for(int i = 0; i < 5; i++)
        {
            int? valor = impar[i];
            
            if (valor.HasValue)
            {
                lista.Add($"impar[{i}] = {impar[i]}");
            }
        }
        
        for(int i = 0; i < 5; i++)
        {
            int? valor = par[i];
            
            if (valor.HasValue)
            {
                lista.Add($"par[{i}] = {par[i]}");
            }
        }
        
        foreach(string val in lista)
        {
            Console.WriteLine(val);
        }

    }

}
