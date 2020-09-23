using System;

namespace SemTask_3_02
{
    class Program
    {
        public static bool Function(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }



        static void Main()
        {
            bool p = true, q, res;
            Console.WriteLine("Таблица истинности !(p & q) & !(p | !q)");
            Console.WriteLine(" p \t q \t F");
            do
            {
                q = true;
                do
                {
                    res = Function(p, q); // Вызов Function()
                    Console.WriteLine("{0}\t{1}\t{2}", p, q, res);
                    q = !q;
                } while (!q);
                p = !p;
            } while (!p);
            Console.WriteLine("Для выхода нажмите ENTER");
            Console.ReadLine();
        }

    }
}
