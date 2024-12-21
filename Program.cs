using System;

namespace Homework_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string surname = "Петр";
            Console.WriteLine($"мы нашли ошибку, на данный момент ваше имя {name}, а фамилия {surname}");
            string swapName = name;
            name = surname;
            surname = swapName;
            Console.WriteLine($"проверьте данные, ваше имя {name}, фамилия {surname}");
        }
    }
}
