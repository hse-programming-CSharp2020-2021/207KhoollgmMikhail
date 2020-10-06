using System;

namespace Sem_04_03._1
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


            for (int i = 0; i < N; i++)
            {
                array[i] = new char[i+1];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = '*';
                }
                PrintIndexAndValues(array[i]);
            }

        }
    }
}
