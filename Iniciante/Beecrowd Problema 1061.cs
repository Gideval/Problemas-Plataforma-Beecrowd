using System; 

class URI {

    static void Main(string[] args) { 

        int dayStart = int.Parse(Console.ReadLine().Split(' ')[1]);
        string[] timeStart = Console.ReadLine().Split(' ');
        int hourStart, minutStart, secondsStart;
        hourStart = int.Parse(timeStart[0]);
        minutStart = int.Parse(timeStart[2]);
        secondsStart = int.Parse(timeStart[4]);
        
        int dayEnd = int.Parse(Console.ReadLine().Split(' ')[1]);
        string[] timeEnd = Console.ReadLine().Split(' ');
        int hourEnd, minutEnd, secondsEnd;
        hourEnd = int.Parse(timeEnd[0]);
        minutEnd = int.Parse(timeEnd[2]);
        secondsEnd = int.Parse(timeEnd[4]);
        
        DateTime dataStart = new DateTime(DateTime.Now.Year, 4, dayStart, hourStart, minutStart, secondsStart);
        DateTime dataEnd = new DateTime(DateTime.Now.Year, 4, dayEnd, hourEnd, minutEnd, secondsEnd);
        
        TimeSpan diference;
        
        if (dataStart > dataEnd)
        {
            diference = dataStart - dataEnd;
        }
        else
        {
            diference = dataEnd - dataStart;
        }
        
        Console.WriteLine($"{diference.Days} dia(s)");
        Console.WriteLine($"{diference.Hours} hora(s)");
        Console.WriteLine($"{diference.Minutes} minuto(s)");
        Console.WriteLine($"{diference.Seconds} segundo(s)");

    }

}
