using System;

namespace Task_03_3
{
    public class Polygon
    {
        int numb, minOrMax = 0;
        double radius;

        public Polygon(int n = 3, double r = 1)
        {
            numb = n;
            radius = r;
        }

        public double Perimeter
        {
            get
            {
                double term = Math.Tan(Math.PI / numb);
                return 2 * numb * radius * term;
            }
        }

        public double Area
        {
            get
            {
                return Perimeter * radius / 2;
            }
        }

        public int MinOrMax
        {
            set
            {
                minOrMax = value;
            }
        }

        public void PolygonData()
        {
            Console.Write($"N={numb}; R={radius}; P={Perimeter,2:F3}; ");
            switch (minOrMax)
            {
                case -1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.WriteLine($"S={Area,4:F3}");
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Polygon polygon = new Polygon();
            Console.WriteLine("По умолчанию создан многоугольник: ");
            polygon.PolygonData();


            Polygon[] polygons = new Polygon[0];

            for (int i = 0; true; i++)
            {
                double rad;
                int number;

                do Console.Write($"Введите число сторон {i + 1}-ого многоугольника: ");
                while (!int.TryParse(Console.ReadLine(), out number) | ((number < 3) && (number != 0)));

                do Console.Write($"Введите радиус {i + 1}-ого многоугольника: ");
                while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);

                if ((number == 0) && (rad == 0)) break;

                Array.Resize(ref polygons, polygons.Length + 1);

                polygons[i] = new Polygon(number, rad);

                Console.WriteLine($"Сведения о {i + 1}-ом многоугольнике :");
                polygons[i].PolygonData();
                Console.WriteLine();

            }

            double[] squares = new double[polygons.Length];
            double max = 0, min = polygons[0].Area;
            int maxi = 0, mini = 0;
            for (int i = 0; i < polygons.Length; i++)
            {
                if (max < polygons[i].Area)
                {
                    max = polygons[i].Area;
                    maxi = i;
                }
                if (min > polygons[i].Area)
                {
                    min = polygons[i].Area;
                    mini = i;
                }
            }

            polygons[mini].MinOrMax = -1;
            polygons[maxi].MinOrMax = 1;

            // Вывод с выделением минимального и максимального значений площади
            for (int i = 0; i < polygons.Length; i++)
            {
                Console.WriteLine($"Сведения о {i + 1}-ом многоугольнике :");
                polygons[i].PolygonData();
                Console.WriteLine();
            }


        }
    }
}
