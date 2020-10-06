using System;

namespace Task_01
{
    class Program
    {
        public static void PrintIndexAndValues(int[,] myArr, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //Console.Write($"[{i}][{j}] = {myArr[i, j]} ");
                    Console.Write($"{myArr[i, j]}\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int N;

            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            int[,] Matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j) Matrix[i, j] = 0;
                    else if (i > j) Matrix[i, j] = -1;
                    else if (i < j) Matrix[i, j] = 1;
                }
            }

            PrintIndexAndValues(Matrix, N);

        }
    }
}
