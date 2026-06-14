using System;

class URI
{
    static void Main(string[] args)
    {
        List<int> numbers = [];
        string? line;

        while ((line = Console.ReadLine()) != null)
        {
            numbers.Add(int.Parse(line));
        }

        foreach (int N in numbers)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (N - (i + j) == 1)
                    {
                        Console.Write(2);
                    }
                    else if (i - j == 0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(3);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

/*
Versão aceita pelo compilador da plataforma 
C# (mono 5.10.1.20)

using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string line;

        while ((line = Console.ReadLine()) != null)
        {
            numbers.Add(int.Parse(line));
        }

        foreach (int N in numbers)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (N - (i + j) == 1)
                    {
                        Console.Write(2);
                    }
                    else if (i - j == 0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(3);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
*/