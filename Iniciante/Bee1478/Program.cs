using System;

class URI
{
    static void Main(string[] args)
    {
        List<int> numbers = [];
        int N = int.Parse(Console.ReadLine());

        while(N != 0)
        {
            numbers.Add(N);
            N = int.Parse(Console.ReadLine());
        }

        foreach(int num in numbers)
        {
            int[,] matriz = new int[num, num];

            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    if(i == 0)
                    {
                        matriz[i,j] = j + 1;
                    }
                    else if(j == 0)
                    {
                        matriz[i,j] = matriz[i-1, j] + 1;
                    }
                    else
                    {
                        matriz[i,j] = matriz[i-1, j-1];
                    }
                }
            }

            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    if(j > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($"{matriz[i,j], 3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}

/*
Versão aceita pela plataforma para 
C# (mono 5.10.1.20)

using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int N = int.Parse(Console.ReadLine());

        while (N != 0)
        {
            numbers.Add(N);
            N = int.Parse(Console.ReadLine());
        }

        foreach (int num in numbers)
        {
            int[,] matriz = new int[num, num];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == 0)
                    {
                        matriz[i, j] = j + 1;
                    }
                    else if (j == 0)
                    {
                        matriz[i, j] = matriz[i - 1, j] + 1;
                    }
                    else
                    {
                        matriz[i, j] = matriz[i - 1, j - 1];
                    }
                }
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j > 0)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(String.Format("{0,3}", matriz[i, j]));
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}

*/