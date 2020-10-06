using System;

namespace Sem_03_20
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
                Array[i] = rnd.Next(10, 101);
            }
        }

        public static void ArrayItemDouble(ref int[] A, int X)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    Array.Resize(ref A, A.Length + 1);
                    for (int j = A.Length - 2; j > i; j--)
                    {
                        A[j + 1] = A[j];
                    }
                    A[i + 1] = A[i];
                    i++;
                }
            }
        }


        static void Main(string[] args)
        {
            int N, X;

            if (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            int[] values = new int[N];

            RandomArray(values);
            PrintArray(values);

            if (!int.TryParse(Console.ReadLine(), out X))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            ArrayItemDouble(ref values, X);

            PrintArray(values);

        }
    }
}
