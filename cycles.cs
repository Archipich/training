using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int repetitions;
            string sequenceOutput = "Обязательно посмотри сегодня курсы";

            Console.Write("Сколько раз вам нужно напомнить посмотреть курсы? ");
            repetitions = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine(sequenceOutput);
            }
        }
    }
}
