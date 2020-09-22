using System;

namespace Task_3_04
{
    class Program
    {
        public static double Function(double x, double y)
        {
            if ((x < y) && (x > 0)) return x + Math.Sin(y);
            else if ((x > y) && (x < 0)) return y - Math.Cos(x);
            else return 0.5 * x * y;
        }


        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Введите переменные x, y: ");

            if (!(double.TryParse(Console.ReadLine(), out x) && (double.TryParse(Console.ReadLine(), out y))))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Console.WriteLine("G = " + Function(x, y));

        }
    }
}