using System;

namespace SemTask_3_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 0, r1 = 0, r2 = 1;

            for (int i = 1; r1 != r2; i++)
            {
                r2 = r1;
                r1 = 1.0 / (i * (i + 1) * (i + 2));
                S += 1.0 / (i * (i + 1) * (i + 2));
            }

            Console.WriteLine($"Приближённое значение суммы = {S:f6}, точность = {r1:f6}");
        }
    }
}
