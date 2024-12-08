using System;

namespace Homework_work_with_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Здравствуйте, напишите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Отлично, продолжим, назовите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Теперь назовите ваш знак зодиака: ");
            string zodiacSign = Console.ReadLine();
            Console.Write("И последнее, укажите где вы работаете: ");
            string placeOfWork = Console.ReadLine();
            Console.WriteLine("Теперь давайте проверим вашу анкету");
            Console.WriteLine($"Вас зовут {name}, вам {age}, ваш знак зодиака {zodiacSign}, и вы работаете {placeOfWork}");

            
        }
    }
}
