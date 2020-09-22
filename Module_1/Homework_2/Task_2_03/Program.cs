using System;
using System.Reflection.Metadata.Ecma335;

namespace Task_03
{
    class Program
    {
        public static void CalculQuadr(double a, double b, double c) // Расчёт корней квадратного уравнения
        {
            double D, x1, x2, cntr;

            D = b * b - 4 * a * c;
            cntr = (D < 0) ? -1 : (D == 0) ? 0 : 1; // Переменная cntr используется вместо операторов if...else

            switch(cntr)
            {
                case 1:
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"x1 = {x1:f3} \nx2 = {x2:f3}");
                    return;

                case 0:
                    Console.WriteLine("x = " + (-b / (2 * a)).ToString("F3"));
                    return;

                case -1:
                    Console.WriteLine("Уравнение не имеет корней");
                    return;
            }
        }

        public static void CalculLin(double b, double c) // Расчёт корней линейного уравнения
        {
            switch (b)
            {
                case 0:
                    Console.WriteLine("Уравнение не имеет корней");
                    return;

                default:
                    Console.WriteLine(" x = " + (-c / b).ToString("F3"));
                    return;

            }
        }




        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Введите коэффиценты A, B, C: ");
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);

            switch (a)
            {
                case 0:
                    CalculLin(b, c);
                    return;
                default:
                    CalculQuadr(a, b, c);
                    return;
            }

        }
    }
}
