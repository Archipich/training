using System;

namespace Homework_image
{
    class Program
    {
        static void Main(string[] args)
        {
            int imagesInRowt = 3;
            int images = 52;
            int fullLines = images / imagesInRow;
            int remainsImage = images - (fullLines * 3);
            Console.WriteLine($"Заполненых рядов {fullLines}, остаток картинок {remainsImage}");
            Console.ReadKey();
        }
    }
}
