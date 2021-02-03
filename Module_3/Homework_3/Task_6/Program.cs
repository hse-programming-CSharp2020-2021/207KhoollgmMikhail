using System;

namespace Task_6
{
    public delegate void LineCompleteEvent();
    public delegate void ItemEvents(int[,] ar);


    public class Methods
    {
        public static event LineCompleteEvent lineComplete;
        public static event ItemEvents NewItemFilled;

        static double avg = 0;
        static int qnt = 0, sum = 0, max = 0;

        public static void ArrayFill(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    arr[i, j] = rnd.Next(100);
                    NewItemFilled?.Invoke(arr);
                }
        }

        public static void ArraySumCount(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    sum += arr[i, j];
            }
            Console.WriteLine(sum);
        }

        public static void ArrayPrint(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Console.Write(arr[i, j] + " ");
                lineComplete(); // событие!!
            }
        }

        public static void AverageElement(int[,] arr)
        {
            int x = arr[qnt / arr.GetLength(0), qnt % arr.GetLength(1)];
            sum += x;
            qnt++;
            avg = (double)sum / qnt;
            Console.WriteLine($"Среднее занчение: {avg:f3}");
        }

        public static void MaxElement(int[,] arr)
        {
            int x = arr[(qnt - 1) / arr.GetLength(0), (qnt - 1) % arr.GetLength(1)];
            if (x > max) max = x;
            Console.WriteLine($"Максимальное занчение: {max}");
        }
    }
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[15, 15];
            int x = 0;
            Methods.NewItemFilled += Methods.ArraySumCount;
            Methods.NewItemFilled += Methods.AverageElement;
            Methods.NewItemFilled += Methods.MaxElement;

            Methods.ArrayFill(arr);

        }
    }
}
