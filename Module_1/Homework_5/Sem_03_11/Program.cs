using System;

namespace Sem_03_11
{
    class Program
    {
        public static void PrintArray(int[] Array)
        {
            foreach (int a in Array)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        public static void FillArray(int[] array)
        {
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = 34 * array[i - 1] - array[i - 2] + 2;
            }


        }

        static void Main(string[] args)
        {
            int N;

            if (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            int[] values = new int[N];
            values[0] = 0;
            values[1] = 1;

            FillArray(values);
            PrintArray(values);

        }
    }
}
