using System;

namespace Sem_04_03._2
{
    class Program
    {
        public static void PrintIndexAndValues(char[] myArr)
        {

            for (int j = 0; j < myArr.Length; j++)
            {
                Console.Write(myArr[j]);
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
            char[][] array = new char[N][];


            for (int i = 0; i < (N - 1) / 2 + 1; i++)
            {
                array[i] = new char[N / 2 + i + 1];
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j < N / 2 - i) array[i][j] = ' ';
                    else array[i][j] = '*';
                }
                PrintIndexAndValues(array[i]);
            }

        }
    }
}
