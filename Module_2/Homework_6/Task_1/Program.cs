using System;

namespace Task_1
{
    public class Program
    {
        public static void Main()
        {
            Matrix mat;
            int rank; // Порядок матрицы
            do
            { // цикл повторения решений
                try
                {
                    rank = Methods.GetIntValue("Введите порядок матрицы: ");
                    mat = new Matrix();
                    mat.UnitMatr(rank);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Введена пустая строка");
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные данные");
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Некорректное число");
                    Console.WriteLine("Для завершения программы нажмите ESC");
                    continue;
                }

                mat.MatrPrint();
                Console.WriteLine("Для завершения программы нажмите ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }

    public static class Methods
    {
        public static int GetIntValue(string comment)
        {
            Console.Write(comment);
            return int.Parse(Console.ReadLine());
        }
    }


    public class Matrix
    {
        int[,] matrix;

        public void MatrPrint()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.Write("\n");
            }
        }
        public void UnitMatr(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException("Аргумент метода должен быть положительным!");

            matrix = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = (i == j ? 1 : 0);
        }
    }

}
