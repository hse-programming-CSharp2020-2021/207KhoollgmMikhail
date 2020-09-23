using System;

namespace SemTask_3_01
{
    class Program
    {
        public static void Convert(int mark)
        {
            switch (mark)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Хорошо");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Отлично");
                    break;
            }

        }
        
        
        
        
        static void Main(string[] args)
        {
            int mark;

            if (!int.TryParse(Console.ReadLine(), out mark) || mark < 1 || mark > 10)
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Convert(mark);

        }
    }
}
