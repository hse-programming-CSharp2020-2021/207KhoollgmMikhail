using System;

namespace SemTask_3_06
{
    class Program
    {
        static double Total(double k, double r, uint n)
        {
            Console.WriteLine("Год: \t\t Итоговая сумма: ");

            for (int i = 1; i <= n; i++)
            {
                k += k * r / 100;
                Console.WriteLine($"{i}  \t\t {k:f3}");
            }
            return k;
        }

        static void Main()
        {
            double k, r, s;
            uint n;
            do Console.Write("Введите начальный капитал: ");
            while (!double.TryParse(Console.ReadLine(), out k) | k <= 0);   // Капитал не отрицателен
           
            do Console.Write("Введите годовую процентную ставку: ");
            while (!double.TryParse(Console.ReadLine(), out r) | r <= 0); // Процент не отрицателен
           
            do Console.Write("Введите число лет: ");
            while (!uint.TryParse(Console.ReadLine(), out n) | n == 0);  // Число лет не равно нулю

            s = Total(k, r, n);         // обращение к методу
            Console.WriteLine("Итоговая сумма: " + s.ToString("F3"));
        } 
    } 
}

