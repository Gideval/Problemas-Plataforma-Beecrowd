using System; 

class URI {

    static void Main(string[] args) { 

        int DDD = int.Parse(Console.ReadLine());
        string DDDCity = "DDD nao cadastrado";
        
        switch(DDD)
        {
            case 61:
                DDDCity = "Brasilia";
                break;
            case 71:
                DDDCity = "Salvador";
                break;
            case 11:
                DDDCity = "Sao Paulo";
                break;
            case 21:
                DDDCity = "Rio de Janeiro";
                break;
            case 32:
                DDDCity = "Juiz de Fora";
                break;
            case 19:
                DDDCity = "Campinas";
                break;
            case 27:
                DDDCity = "Vitoria";
                break;
            case 31:
                DDDCity = "Belo Horizonte";
                break;
            default:
                break;
        }
        
        Console.WriteLine (DDDCity);

    }

}
