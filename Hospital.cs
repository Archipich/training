using System;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
           int reseptionTime = 10;
            int minutesInHouer = 60;
            int minutesOfWating;
            int houresOfWaiting;
            int queue;
            int waitingMinutesTotal;

            Console.Write("Сколько человек перед вами в очереди: ");
            queue = Convert.ToInt32(Console.ReadLine());

            waitingMinutesTotal = queue * reseptionTime;
            houresOfWaiting = waitingMinutesTotal / minutesInHouer;
            minutesOfWating = waitingMinutesTotal % minutesInHouer;
            Console.WriteLine($"Вам осталось ждать {houresOfWaiting} часов и {minutesOfWating} минут");
        }
    }
}
