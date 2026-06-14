using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        int hourStart, minutStart, hourEnd, minutEnd, hour, minut, calcHour;
        hourStart = Convert.ToInt32(valores[0]);
        minutStart = Convert.ToInt32(valores[1]);
        hourEnd = Convert.ToInt32(valores[2]);
        minutEnd = Convert.ToInt32(valores[3]);
        
        if(hourStart == 0)
        {
            hourStart = 24;
        }
        
        if(hourEnd == 0)
        {
            hourEnd = 24;
        }
        
        if((hourStart * 60 + minutStart) >= (hourEnd * 60 + minutEnd))
        {
            hourEnd = hourEnd + 24;
        }
        
        calcHour = (hourEnd * 60 + minutEnd) - (hourStart * 60 + minutStart);
        
        hour = calcHour / 60;
        minut = calcHour % 60;
        
        if( hour == 0 && minut == 0)
        {
            Console.WriteLine ("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
        }
        else if(hourStart == 0 && minutStart == 0)
        {
            Console.WriteLine ($"O JOGO DUROU {hourEnd} HORA(S) E {minutEnd} MINUTO(S)");
        }
        else
        {
            Console.WriteLine ($"O JOGO DUROU {hour} HORA(S) E {minut} MINUTO(S)");
        }

    }

}
