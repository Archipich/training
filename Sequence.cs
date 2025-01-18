using System;

namespace sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSequence = 5;
            int endSequence = 103;
            int stepSequence = 7;

            for (int i = startSequence; i <= endSequence; i += stepSequence)
            {
                Console.WriteLine(i);
            }

        }
    }
}
