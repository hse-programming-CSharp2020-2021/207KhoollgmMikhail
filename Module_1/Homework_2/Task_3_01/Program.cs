using System;

namespace Task_3_01
{
    class Program
    {

        public static void Searching(out int i, out int s) // Метод для поиска такого числа
        {
            s = 0;
            for (i = 1; !((s / 100 == s % 10) && (s / 10 % 10 == s % 10) && (s > 99)); i++)
            {
                s += i;
            }

        }



        static void Main(string[] args)
        {

            int i, s;

            Searching(out i, out s);

            Console.WriteLine($"s = {s}");
            Console.WriteLine($"Количество членов ряда: {i}");
            Console.WriteLine($"1+2+3+...+{i-2}+{i-1}+{i}");


        }
    }
}
