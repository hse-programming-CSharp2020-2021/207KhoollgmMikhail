using System;

namespace Task_02
{
    class Program
    {
        public static int FindTheBiggest(int x)
        {
            int a, b, c, min, max, mid;

            a = x / 100;
            b = x / 10 % 10;
            c = x % 10;

            max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
            min = (a < b) ? ((a < c) ? a : c) : ((b < c) ? b : c);
            mid = a + b + c - max - min;

            return max * 100 + mid * 10 + min;
        }

        static void Main(string[] args)
        {
            int x;

            if (!(int.TryParse(Console.ReadLine(), out x) && (x > 99) && (x < 1000))){
                Console.WriteLine("Неверное значение");
                return;
            }

            Console.WriteLine(FindTheBiggest(x));

        }
    }
}
