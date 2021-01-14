using System;

namespace Task_1
{
    class Program
    {
        public delegate int[] ValNum(int value);
        public delegate void PrAr(int[] arr);

        public static int[] ValueNumbers(int value)
        {
            int n = value.ToString().Length;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[n - 1 - i] = value % 10;
                value /= 10;
            }
            return a;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            ValNum first = ValueNumbers;
            PrAr second = PrintArray;
            second?.Invoke(first?.Invoke(12345));
            second?.Invoke(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90, 37 });
            Console.WriteLine(first.Method);
            Console.WriteLine(first.Target);
            Console.WriteLine(second.Method);
            Console.WriteLine(second.Target);
        }
    }
}
