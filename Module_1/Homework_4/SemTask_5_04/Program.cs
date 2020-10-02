using System;

namespace SemTask_5_04
{
    class Program
    {
        public static void Sequense(ref int[] a)
        {
            for (int i = 0; true; i++)
            {
                Array.Resize(ref a, a.Length + 1);
                a[i + 1] = (a[i] % 2 == 0) ? a[i] / 2 : (3 * a[i] + 1);
                if (a[i + 1] == 1) break;
            }

        }

        public static void PrintIndexAndValues(int[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                if (i % 5 == 0) Console.Write("\n");
                Console.Write($"[{i}] = {myArr[i]}   ");
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            int[] a = new int[1];

            if (!int.TryParse(Console.ReadLine(), out a[0]) || a[0] < 0)
            {
                Console.WriteLine("Неаерное значение");
                return;
            }

            Sequense(ref a);
            PrintIndexAndValues(a);
        }
    }
}
