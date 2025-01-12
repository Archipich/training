using System;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int reseptionTime = 10;
            int minInHouer = 60;
            int min;
            int houre;

            Console.Write("Сколько человек перед вами в очереди: ");

            int queue = Convert.ToInt32(Console.ReadLine());
            int waitingMinutes = queue * reseptionTime;

            houre = waitingMinutes / minInHouer;
            min = waitingMinutes % minInHouer;

            Console.WriteLine($"Вам осталось ждать {houre} часов и {min} минут");


        }
    }
}
