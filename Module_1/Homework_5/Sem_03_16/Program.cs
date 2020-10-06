using System;

namespace Sem_03_16
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

        public static void RandomArray(int[] Array)
        {
            Random rnd = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rnd.Next(-10, 11);
            }
        }

        public static int FindMinIndex(int[] array)
        {
            int min = 11, minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public static int FindMaxIndex(int[] array)
        {
            int max = -11, maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
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

            RandomArray(values);
            PrintArray(values);

            Console.WriteLine($"Index of minimal element = {FindMinIndex(values)}");
            Console.WriteLine($"The sum of indexes of minimum and maximum elements = {FindMinIndex(values) + FindMaxIndex(values)}");

        }
    }
}
