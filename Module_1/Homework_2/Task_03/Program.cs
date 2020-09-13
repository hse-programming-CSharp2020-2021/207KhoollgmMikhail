using System;

namespace Task_03
{
    class Program
    {
        public static void CalculQuadr(double a, double b, double c) // Расчёт корней квадратного уравнения
        {
            double D, x1, x2;

            D = b * b - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"x1 = {x1:f3} \nx2 = {x2:f3}");
            }
            else if (D == 0)
            {
                Console.WriteLine("x = " + (-b / (2 * a)).ToString("F3"));
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
        }

        public static void CalculLin(double b, double c) // Расчёт корней линейного уравнения
        {
            if (b != 0)
            {
                Console.WriteLine(" x = " + (-c / b).ToString("F3"));
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
        }




        static void Main(string[] args)
        {
            double a, b, c;

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


            if (a == 0) CalculLin(b, c);
            else CalculQuadr(a, b, c);

        }
    }
}
