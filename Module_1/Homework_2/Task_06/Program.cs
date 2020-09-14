using System;
using System.Globalization;

namespace Task_06
{
    class Program
    {
        public static void PrintValue(double value)
        {
            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0:c3}", value / 75, 46));
        }

        static void Main(string[] args)
        {
            double budget, percent;


            Console.WriteLine("Введите бюджет и процент бюджета: ");

            if (!double.TryParse(Console.ReadLine(), out budget))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            if (!double.TryParse(Console.ReadLine(), out percent))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            budget *= percent / 100;

            PrintValue(budget);
        }
    }
}
