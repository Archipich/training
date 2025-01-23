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
            string playerInput;
            int randNumb;

            Console.WriteLine("Приветствую тебя в нашем простеньком меню странник\nПозволь ознакомлю " +
                "тебя со скудными возможностями:\nText1 - мотивационное сообщение\nText2 - цитата Стэтхэма" +
                "Random - рандомное число\nClear очистить все(будь осторожен с этим)\nExit - выйти из нашего меню ");
            Console.Write("Введи любую из этих команд и начнем:");
            playerInput = Console.ReadLine();

            while (playerInput != exite)
            {

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
                        randNumb = rand.Next(0, 100);
                        Console.WriteLine(randNumb);
                        break;
                    default:
                        Console.WriteLine("Увы такой команды еще нет");
                        break;
                }

                Console.WriteLine("Что желаете сделать дальше?");
                playerInput = Console.ReadLine();
            }

            Console.WriteLine("Будем рады видеть вас снова!!!");
        }
    }
}
