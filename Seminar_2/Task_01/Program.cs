using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            uint n;
            double b, un;
            int res;

            Console.Write("Введите номер члена ряда: ");
            line = Console.ReadLine();
            if (!uint.TryParse(line, out n)){
                Console.WriteLine("Ошибка ввода");
                return;
            }

            b = (1 + Math.Sqrt(5)) / 2;
            un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
            res = (int)(un + 0.5);
            Console.WriteLine($"un = {un} , Число Фибоначчи: {res}");


            Console.WriteLine("Для выхода нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
