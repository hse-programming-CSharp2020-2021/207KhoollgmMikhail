using System;

namespace Task_04
{
    class Program
    {

        public static void Reverse(uint a)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(a % 10);
                a /= 10;
            }

        }



        static void Main(string[] args)
        {
            uint a;

            Console.WriteLine("Введите четырёхзначное натуральное число: ");
            if (!uint.TryParse(Console.ReadLine(), out a) || a == 0 || a < 1000 || a > 9999)
            {
                Console.WriteLine("Неверное значение");
                return;
            }
            Reverse(a);

        }
    }
}
