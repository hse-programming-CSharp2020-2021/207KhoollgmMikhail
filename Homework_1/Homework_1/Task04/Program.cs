using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpStr;
            double U, R;

            Console.WriteLine("Введите Напряжение (U): ");
            inpStr = Console.ReadLine();
            double.TryParse(inpStr, out U);

            Console.WriteLine("Введите Сопротивление (R): ");
            inpStr = Console.ReadLine();
            double.TryParse(inpStr, out R);

            Console.WriteLine("Сила тока (I) = " + U/R);
            Console.WriteLine("Потребляемая мощность (P) = " + U*U / R);

        }
    }
}
