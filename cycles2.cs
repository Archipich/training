using System;

namespace cycles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeWord = "exit";
            string playerInput;

            Console.Write("Вы попали в зазеркалье и стоите перед порталом домой\nСкажите кодовое слово чтобы попасть домой:");
            playerInput = Console.ReadLine();

            while(playerInput != codeWord)
            {
                Console.Write("Чёрт, похоже не сработало, надо попробовать еще раз, как там это слово... , точно это ");
                codeWord = Console.ReadLine();
            }
           
            Console.WriteLine("*Вы проснулись*\nФух, это был лишь сон");
        }
    }
}
