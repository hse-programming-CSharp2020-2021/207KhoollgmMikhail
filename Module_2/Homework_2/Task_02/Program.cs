using System;

namespace Task_02
{
    class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y) { X = x; Y = y; }

        public Point() : this(0, 0) { } // конструктор умолчания
        public double Ro
        {
            get
            {
                return Math.Sqrt(Y * Y + X * X);
            }
        }

        public double Fi
        {
            get
            {
                if ((X > 0) && (Y >= 0)) return Math.Atan(Y / X);
                else if ((X > 0) && (Y < 0)) return Math.Atan(Y / X) + 2 * Math.PI;
                else if (X < 0) return Math.Atan(Y / X) + Math.PI;
                else if ((X == 0) && (Y > 0)) return Math.PI / 2;
                else if ((X == 0) && (Y < 0)) return 3 * Math.PI / 2;
                return 0;
            }
        }
        public string PointData
        {
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Point[] points = new Point[3];
            points[0] = new Point(3, 4);
            Console.WriteLine(points[0].PointData);
            points[1] = new Point(0, 3);
            Console.WriteLine(points[1].PointData);
            points[2] = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                points[2].X = x; points[2].Y = y;


                for (int j = 0; j < 3; j++)
                {
                    int minIndex = j;
                    for (int i = j + 1; i < 3; i++)
                    {
                        if (points[i].Ro < points[minIndex].Ro) minIndex = i;
                    }
                    Point temp = points[j];
                    points[j] = points[minIndex];
                    points[minIndex] = temp;
                    Console.WriteLine(points[j].PointData);
                }


            } while (x != 0 | y != 0);
        }

    }
}
