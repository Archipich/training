using System;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int reseptionTime = 10;
            int minutesInHouer = 60;
            int watingMinutes;
            int watingHoures;
            int queue;
            int waitingMinutesTotal;

            Console.Write("Сколько человек перед вами в очереди: ");
            queue = Convert.ToInt32(Console.ReadLine());

            waitingMinutesTotal = queue * reseptionTime;
            watingHoures = waitingMinutesTotal / minutesInHouer;
            watingMinutes = waitingMinutesTotal % minutesInHouer;
            Console.WriteLine($"Вам осталось ждать {watingHoures} часов и {watingMinutes} минут");
        }
    }
}
