using System;
using System.Collections.Generic;
using Figures;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.Display();
            Console.WriteLine("p.Area для Point = " + p.Area);
            p = new Circle(1, 2, 6);
            p.Display();
            Console.WriteLine("p.Area для Circle = " + p.Area);
            p = new Square(3, 5, 8);
            p.Display();
            Console.WriteLine("p.Area для Square = " + p.Area);

            Random rnd = new Random();
            Point[] figures = new Point[rnd.Next(0, 21)];

            FigArray(figures);

            int circlesQnt = 0, squareQnt = 0;
            double totalCircleLen = 0, totalCircleArea = 0;
            double totalSquarePerim = 0, totalSquareArea = 0;

            foreach (Point a in figures)
            {
                if(a.GetType().Name == "Circle")
                {
                    circlesQnt++;
                    totalCircleLen += a.Len;
                    totalCircleArea += a.Area;
                }
                else
                {
                    squareQnt++;
                    totalSquarePerim += a.Len;
                    totalSquareArea += a.Area;
                }
            }
            Console.WriteLine($"Кол-во объектов Circle = {circlesQnt}, средняя длина = {totalCircleLen / circlesQnt:F3}," +
                $" средняя площадь = {totalCircleArea / circlesQnt:F3}");

            Console.WriteLine($"Кол-во объектов Square = {squareQnt}, средняя длина = {totalSquarePerim / squareQnt:F3}," +
                $" средняя площадь = {totalSquareArea / squareQnt:F3}");

            Array.Sort(figures, new FigureComparer());

            foreach(Point a in figures)
            {
                a.Display();
            }

        }

        public static void FigArray(Point[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                double a = 10 + rnd.NextDouble() * 90;
                double b = 10 + rnd.NextDouble() * 90;
                double c = 10 + rnd.NextDouble() * 90;
                if (rnd.Next(0, 2) == 1) arr[i] = new Circle(a, b, c);
                else arr[i] = new Square(a, b, c);
            }
        }
    }


   
}
