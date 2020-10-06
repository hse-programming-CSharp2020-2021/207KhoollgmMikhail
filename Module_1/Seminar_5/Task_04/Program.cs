using System;

namespace Task_04
{
    class Program
    {
        public static void ShiftArray(ref int[] values, int i)
        {
       
            int j;
            for (j = i; j < values.Length - 1; j++)
            {
                values[j] = values[j + 1];
            }
            
            PrintIndexAndValues(values);

            
        }

        public static void PrintIndexAndValues(int[] myArr)
        {

            for (int j = 0; j < myArr.Length; j++)
            {
                Console.Write($"[{j}] = {myArr[j]} ");
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
            int[] values = new int[N];
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                values[i] = rnd.Next(-9, 10);
            }

            PrintIndexAndValues(values);

            for (int i = 0; i < N; i++)
            {
                if (values[i] < 0)
                {
                    int x = values[i];
                    ShiftArray(ref values, i);
                    values[values.Length] = x;
                    PrintIndexAndValues(values);
                    i--;
                }
            }

            PrintIndexAndValues(values);

        }
    }
}
