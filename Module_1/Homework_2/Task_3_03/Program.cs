using System;

namespace Task_3_03
{
    class Program
    {
        public static bool Function(double x, double y)
        {
            // Фигура G это - пересечение внутренней области окружности с радиусом 2, области ниже прямой x = y и области правее прямой x = 0

            return ((x * x) + (y * y) <= 4) && (x >= y) && (x >= 0);
        }


        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Введите координаты точки x, y: ");

            if (!(double.TryParse(Console.ReadLine(), out x) && (double.TryParse(Console.ReadLine(), out y))))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Console.WriteLine(Function(x, y));

        }
    }
}
