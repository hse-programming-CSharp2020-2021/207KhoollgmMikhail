using System;

namespace SemTask_3_07
{
    class Program
    {
        public static bool CalculQuadr(double a, double b, double c, ref double x1, ref double x2) // Расчёт корней квадратного уравнения
        {

            if (a != 0) // Если уравнение квадратичное
            {
                double D;
                D = b * b - 4 * a * c;

                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    return true;
                }
                else if (D == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    return true;
                }
                else return false;
            }
            else // Если уравнение линейное
            {
                if (b != 0)
                {
                    x1 = x2 = -c / b;
                    return true;
                }
                else return false;
            }
        }

        static void Main(string[] args)
        {
            double a, b, c, x1 = 0, x2 = 0;

            Console.WriteLine("Введите коэффиценты A, B, C: ");


            if (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out b) || !double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            if (CalculQuadr(a, b, c, ref x1, ref x2) && (x1 != x2)) Console.WriteLine($"x1 = {x1:f3} \nx2 = {x2:f3}");
            else if (CalculQuadr(a, b, c, ref x1, ref x2) && (x1 == x2)) Console.WriteLine($"x = {x1:f3}");
            else Console.WriteLine("Уравнение не имеет корней");


        }
    }
}
