using System;
using System.Threading;

namespace SemTask_3_04
{
    class Program
    {
        static void Main()
        {
            double x, result = 0, eps = 0;
            Console.Title = "Формула Ньютона";
            ConsoleKeyInfo keyInfo; // нажатая пользователем клавиша
            do
            {
                do
                {
                    Console.Clear();       // очистка консольного окна
                    Console.Write("x=");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Неверное значение");
                        Thread.Sleep(1000);
                    }
                    else break;
                } while (true);

                if (!Newton(x, out result, out eps))
                {
                    Console.WriteLine("Error!");
                    return;
                }
                Console.WriteLine("root({0}) = {1:f4}, eps = {2:e4}", x, result, eps);

                Console.WriteLine("Для выхода нажмите клавишу ESC");
                keyInfo = Console.ReadKey(true);
            } while (keyInfo.Key != ConsoleKey.Escape);
            Console.Beep(500, 1000);
        }
        static bool Newton(double x, out double sq, out double eps)
        {
            double r1, r2 = x;
            sq = eps = 0.0;
            if (x <= 0.0)
            {
                Console.WriteLine("Ошибка в данных!");
                return false;
            }
            do
            {
                r1 = r2;
                eps = x / r1 / 2 - r1 / 2;
                r2 = r1 + eps;
            } while (r1 != r2);  // пока приближения «различимы» для ЭВМ
            sq = r2;
            return true;
        }
    }
}

