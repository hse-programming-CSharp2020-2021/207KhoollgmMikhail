using System;

namespace Task_3_05
{
    class Program
    {
        public static double Function(double x)
        {
            if (x <= 0.5) return Math.Sin(Math.PI / 2);
            else return Math.Sin(Math.PI * (x - 1) / 2);
        }


        static void Main(string[] args)
        {
            double x;

            Console.WriteLine("Введите переменную x: ");

            if (!(double.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Console.WriteLine("G = " + Function(x));

        }
    }
}
