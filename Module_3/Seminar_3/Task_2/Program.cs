using System;

namespace Task_2
{
    public delegate void LineCompleteEvent();

    public class Methods
    {
        
        public static event LineCompleteEvent lineComplete;

        public static void ArrayPrint(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Console.Write(arr[i, j] + " ");
                lineComplete(); // событие!!
            }
        }
    }
    class Program
    {
        static void Main()
        {
            int[,] arr = new int[15, 15];
            Random rnd = new Random();
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    arr[i, j] = rnd.Next(100);
            // в качестве обработчика - лямбда-выражение
            Methods.lineComplete += () => { Console.WriteLine(); };
            Methods.lineComplete += () => { Console.WriteLine("****"); };
            Methods.ArrayPrint(arr);
        }
    }
}
