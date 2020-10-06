using System;

namespace Sem_04_01._3
{
    // Недоработано!!!!!!!!!!
    
    
    
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

        public static void Loop(ref int[,] A, int i, int j, int s, int bound)
        {
            int N = A.GetLength(0);
            if ((N % 2 == 0) && (i == N / 2) && (j == N / 2 + 1)) return;
            if ((N % 2 != 0) && (i == N / 2 + 1) && (j == N / 2 + 1)) return;

            for (; j < N - bound; j++)
            {
                A[i, j] = s;
                s++;
            }
            j--;
            i++;
            for (; i < N - bound; i++)
            {
                A[i, j] = s;
                s++;
            }
            i--;
            j--;
            for (; j > bound - 1; j--)
            {
                A[i, j] = s;
                s++;
            }
            j++;
            i--;
            for (; i >bound; i--)
            {
                A[i, j] = s;
                s++;
            }
            j++;
            i++;
            bound++;
            Loop(ref A, i, j, s, bound);

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

            Loop(ref Matrix, 0, 0, 0, 0);


            PrintIndexAndValues(Matrix, N);

        }
    }
}
