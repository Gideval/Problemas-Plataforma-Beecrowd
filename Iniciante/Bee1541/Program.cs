using System;

class URI
{

    static void Main(string[] args)
    {

        List<int[]> houseArea = new List<int[]>();
        int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        while (values[0] != 0)
        {
            houseArea.Add(values);
            values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        foreach(int[] area in houseArea)
        {
            Console.WriteLine((int)Math.Sqrt((area[0] * area[1] * 100) / area[2]));
        }

    }

}

/*
Versão aceita pela plataforma devido a versão do compilador do C# 
C# (mono 5.10.1.20)

using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        List<int[]> houseArea = new List<int[]>();

        int[] values = Console.ReadLine()
            .Split(' ')
            .Select(x => int.Parse(x))
            .ToArray();

        while (values[0] != 0)
        {
            houseArea.Add(values);

            values = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
        }

        foreach (int[] area in houseArea)
        {
            Console.WriteLine((int)Math.Sqrt((area[0] * area[1] * 100) / area[2]));
        }
    }
}

*/