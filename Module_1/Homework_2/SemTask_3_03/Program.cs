using System;

namespace SemTask_3_03
{
    class Program
    {
        public static double Integral(double A, double delta) // Метод для вычисления площади под графиком методом трапеции
        {
            int i, n = (int)(A / delta); // Количество элементарных отрезков
            double S = 0, x1, x2; // Интегральная сумма, границы элементарных отрезков
            for (i = 0; i < n; i++)
            {
                x1 = i * delta;
                x2 = (i + 1) * delta;

                S += (x1 * x1 + x2 * x2) * delta / 2;
            }

            if (n * delta != A) // В случае если элементарные отрезки не покрывают весь отрезок [0;A]
            {
                x1 = n * delta;
                x2 = A;

                S += (x1 * x1 + x2 * x2) * (x2 - x1) / 2;

            }
            return S;
        }


        static void Main(string[] args)
        {
            double A = 0, delta = 0;

            Console.WriteLine("Введите вещественную точку A и шаг интегрирования delta: ");

            
            if (!double.TryParse(Console.ReadLine(), out A) || !double.TryParse(Console.ReadLine(), out delta))
            {
                Console.WriteLine("Неверное значение");
                return;
            }
            

            Console.WriteLine($"Интеграл функции x^2 на отрезке [0;{A:f3}] равен: {Integral(A, delta)}");
        }
    }
}
