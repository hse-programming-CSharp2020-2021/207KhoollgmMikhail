using System;

namespace Sem_04_02
{
    class Program
    {
        public static void PrintIndexAndValues(int[] myArr)
        {

            for (int j = 0; j < myArr.Length; j++)
            {
                //Console.Write($"[{i}][{j}] = {myArr[i, j]} ");
                Console.Write($"{myArr[j]}\t");
            }
            Console.Write("\n");

        }


        static void Main(string[] args)
        {
            int N;

            if (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Неверное значение");
                return;
            }
            int[][] array = new int[N + 1][];

            int N1 = N;

            for (int i = 0; N1 > 0; i++)
            {
                array[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    array[i][j] = N1--;
                }
                PrintIndexAndValues(array[i]);
            }

        }
    }
}
