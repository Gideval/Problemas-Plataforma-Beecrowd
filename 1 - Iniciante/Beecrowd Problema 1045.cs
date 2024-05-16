using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        double A, B, C;
        A = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
        B = Convert.ToDouble(valores[1], CultureInfo.InvariantCulture);
        C = Convert.ToDouble(valores[2], CultureInfo.InvariantCulture);
        
        if(B > A)
        {
            var aux= 0.0;
            aux = A;
            A = B;
            B = aux;
        }
        
        if(C > A)
        {
            var aux = 0.0;
            aux = A;
            A = C;
            C = aux;
        }
        
        if(A >= B + C)
        {
            Console.WriteLine ("NAO FORMA TRIANGULO");
        }
        else
        {
            if((A*A) == (B*B + C * C))
            {
                Console.WriteLine ("TRIANGULO RETANGULO");
            }
            else if((A*A) > (B*B + C * C))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if((A*A) < (B*B + C * C))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            
            if(A == B && A == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if(A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }

    }

}
