using System;

namespace Homework_image
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowLenght = 3;
            int numberOfImage = 52;
            int fullLines = numberOfImage / rowLenght;
            int remainsImage = numberOfImage - (fullLines * 3);
            Console.WriteLine($"Заполненых рядов {fullLines}, остаток картинок {remainsImage}");
            Console.ReadKey();
        }
    }
}
