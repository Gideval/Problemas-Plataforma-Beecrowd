using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        double[] vetAverage = new double[N];
        
        string[] valores = new string[3];
        double A, B, C;
        
        for(int i = 0; i < N; i++)
        {
            valores = Console.ReadLine().Split(' ');
            A = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
            B = Convert.ToDouble(valores[1], CultureInfo.InvariantCulture);
            C = Convert.ToDouble(valores[2], CultureInfo.InvariantCulture);
            
            vetAverage[i] = ((A * 2) + (B * 3) + (C * 5)) / 10;
        }
        
        for(int i = 0; i < N; i++)
        {
            Console.WriteLine (vetAverage[i].ToString("F1", CultureInfo.InvariantCulture));
        }

    }

}
