using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int remindersCounters;

            Console.Write("Сколько раз вам нужно напомнить посмотреть курсы? ");
            remindersCounters = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < remindersCounters; i++)
            {
                Console.WriteLine("Обязательно посмотри сегодня курсы");
            }
        }
    }
}
