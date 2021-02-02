using System;

namespace Task_4
{

    class Program
    {
        static void Main(string[] args)
        {
            Series series = new Series();
            series.Order(StraightOrder);
            series.Order(ReverseOrder);
            series.Order(EvenOrder);
        }

        static bool StraightOrder(int a, int b) => a > b;
        static bool ReverseOrder(int a, int b) => a < b;
        static bool EvenOrder(int a, int b) => a % 2 == 0;

    }

    class Series
    {
        int[] arr = new int[] { 3, 4, 8, 3, 5, 0, 9, 11, 178, 111 };
        public void Order(Func<int, int, bool> order)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (order(arr[j], arr[j + 1]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var a in arr) Console.Write(a + " ");
            Console.WriteLine();
        }
    }
}
