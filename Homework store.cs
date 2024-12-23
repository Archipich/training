using System;

namespace Homework_store
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystal;
            int crystalPrice = 100;
            
            Console.WriteLine($"Приветствую тебя в магазине кристалов странник, сегодня кристалы по {crystalPrice} золота");
            Console.Write("Сколько у тебя золота?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристалов тебе нужно?");
            crystal = Convert.ToInt32(Console.ReadLine());

           
            gold -= crystal * crystalPrice;
            Console.WriteLine($"Вы купили {crystal} кристалов и у вас осталось {gold} золота");


        }
    }
}
