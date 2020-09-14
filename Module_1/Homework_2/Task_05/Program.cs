using System;

namespace Task_05
{
    class Program
    {
        public static bool CheckTriangle(double a, double b, double c)
        {
            bool a1, b1, c1;

            a1 = (a < b + c);
            b1 = (b < a + c);
            c1 = (c < a + b);

            return a1 && b1 && c1;
        }



        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Введите три вещественных числа: ");

            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            if (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Неверное значение");
                return;
            }


            switch (CheckTriangle(a, b, c))
            {
                case true:
                    Console.WriteLine("Неравенство верно");
                    return;
                case false:
                    Console.WriteLine("Неравенство неверно");
                    return;
            }
        }
    }
}
