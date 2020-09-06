using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpStr;
            double a, b;

            Console.WriteLine("Введите 1-ый катет: ");
            inpStr = Console.ReadLine();
            if (!double.TryParse(inpStr, out a) || a < 0)
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Console.WriteLine("Введите 2-ой катет: ");
            inpStr = Console.ReadLine();
            if (!double.TryParse(inpStr, out b) || b < 0)
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Console.WriteLine("Гипотенуза = " + Math.Sqrt(a*a+b*b));
        }
    }
}
