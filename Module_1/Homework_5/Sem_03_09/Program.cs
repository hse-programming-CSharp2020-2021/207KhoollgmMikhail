using System;

namespace Sem_03_09
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

        public static void Swap(ref int a, ref int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;
        }


        public static void ArrayHill(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = 11, minIndex = 0, leftBound, rightBound;
                int N = array.Length;
                if (i % 2 == 0)
                {
                    leftBound = i / 2;
                    rightBound = N - i / 2;
                }
                else
                {
                    leftBound = i / 2 + 1;
                    rightBound = N - i / 2;
                }

                int j;

                for (j = leftBound; j < rightBound; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }

                if (i % 2 == 0) Swap(ref array[minIndex], ref array[leftBound]);
                else Swap(ref array[minIndex], ref array[rightBound - 1]);

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

            RandomArray(values);
            PrintArray(values);
            ArrayHill(values);
            PrintArray(values);

        }
    }
}
