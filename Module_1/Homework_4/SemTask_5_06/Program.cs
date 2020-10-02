using System;

namespace SemTask_5_06
{
    class Program
    {
        public static void ShiftArray(ref int[] values)
        {
            for (int i = 0; (i < values.Length - 1) && (values[i + 1] != -100); i++)
            {
                if ((values[i] + values[i + 1]) % 3 == 0)
                {
                    values[i] *= values[i + 1];
                    int j;
                    for (j = i + 1; (j < values.Length - 1) && (values[j + 1] != -100); j++)
                    {
                        values[j] = values[j + 1];
                    }
                    values[j] = -100;
                    PrintIndexAndValues(values);
                }
            }
        }

        public static int Compress(ref int[] values)
        {
            int success=0;
            for (int i = values.Length - 1; true; i--)
            {
                if (values[i] == -100)
                {
                    Array.Resize(ref values, values.Length - 1);
                    success++;
                }
                else
                {
                    PrintIndexAndValues(values);
                    return success;
                }
            }
        }


        public static void PrintIndexAndValues(int[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write($"[{i}] = {myArr[i]}   ");
            }
            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            int N;

            if (!int.TryParse(Console.ReadLine(), out N) || N < 0)
            {
                Console.WriteLine("Неаерное значение");
                return;
            }

            int[] values = new int[N];

            Random rnd = new Random();
            for (int i = 0; i < N; i++) values[i] = rnd.Next(-10, 11);
            PrintIndexAndValues(values);
            ShiftArray(ref values);

            Console.WriteLine($"Успешно сжато {Compress(ref values)} элементов");
        }
    }
}
