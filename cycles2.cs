using System;

namespace cycles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeWord;

            Console.Write("Вы попали в зазеркалье и стоите перед порталом домой\nСкажите кодовое слово чтобы попасть домой:");
            codeWord = Console.ReadLine();

            while(codeWord != "exit")
            {
                Console.Write("Чёрт, похоже не сработало, надо попробовать еще раз, как там это слово... , точно это ");
                codeWord = Console.ReadLine();
            }
            Console.WriteLine("*Вы проснулись*\nФух, это был лишь сон");
        }
    }
}
