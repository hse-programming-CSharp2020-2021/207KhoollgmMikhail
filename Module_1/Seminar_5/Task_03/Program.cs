using System;

namespace Task_03
{
    class Program
    {
        public static void PrintIndexAndValues(char[] myArr)
        {

            for (int j = 0; j < myArr.Length; j++)
            {
                Console.Write($"[{j}][ = {myArr[j]} ");
                //Console.Write(myArr[j]);
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


            for (int i = 0; i < N; i++)
            {
                array[i] = new char[N / 2 + i];
                for (int j = N / 2 - i; j < array[i].Length; j++)
                {
                    array[i][j] = '*';
                }
                PrintIndexAndValues(array[i]);
            }

        }
    }
}
