using System;

namespace Problem_2_07
{
    class Program
    {
        public static void GetValue(ref bool x)
        {
            int tmp;
            if (!int.TryParse(Console.ReadLine(), out tmp))
            {
                Console.WriteLine("Неверное значение");
                return;
            }
            x = tmp > 0;

        }



        static void Main(string[] args)
        {
            bool x, y, z;   // аргументы логической функции

            x = y = z = false;

            Console.Write("Введите значение x, y, z:\n");

            GetValue(ref x);
            GetValue(ref y);
            GetValue(ref z);

            Console.WriteLine("!(X&&Y||Z) = " + !(x && y || z));

            Console.WriteLine("Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
