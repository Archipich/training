using System;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandClear = "Clear";
            const string CommandText1 = "Text1";
            const string CommandText2 = "Text2";
            const string CommandRandom = "Random";

            Random rand = new Random();
            string exite = "Exit";
            string text1 = "Самое время решить несколько задач, вперед, у тебя получится!";
            string text2 = "Если заблудился в лесу, иди домой.*все это лишь шутка*";
            string playerInput =  "defult";
            int randomNumb;

            Console.WriteLine($"Приветствую тебя в нашем простеньком меню странник\nПозволь ознакомлю " +
                $"тебя со скудными возможностями:\n{CommandText1} - мотивационное сообщение\n{CommandText2} - цитата Стэтхэма" +
                $"{CommandRandom} - рандомное число\n{CommandClear} - очистить все(будь осторожен с этим)\n{exite} - выйти из нашего меню ");
            Console.Write($"Введи любую из этих команд и начнем:");

            while (playerInput != exite)
            {
                playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case CommandClear:
                        Console.Clear();
                        break;
                    case CommandText1:
                        Console.WriteLine(text1);
                        break;
                    case CommandText2:
                        Console.WriteLine(text2);
                        break;
                    case CommandRandom:
                        randomNumb = rand.Next(0, 100);
                        Console.WriteLine(randomNumb);
                        break;
                    default:
                        Console.WriteLine("Увы такой команды еще нет");
                        break;
                }

                Console.WriteLine("Что желаете сделать дальше?");
            }

            Console.WriteLine("Будем рады видеть вас снова!!!");
        }
    }
}
