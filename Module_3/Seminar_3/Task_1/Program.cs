using System;

namespace Task_1
{
    public delegate void SquareSizeChanged(double value);

    class Square
    {
        public event SquareSizeChanged OnSizeChanged;
        double ulx, uly, drx, dry;
        public double ulX
        {
            get { return ulx; }
            set
            {
                ulx = value;
                OnSizeChanged?.Invoke(value);
            }
        }
        public double ulY
        {
            get { return uly; }
            set
            {
                uly = value;
                OnSizeChanged?.Invoke(value);
            }
        }

        public double drX
        {
            get { return drx; }
            set
            {
                drx = value;
                OnSizeChanged?.Invoke(value);
            }
        }
        public double drY
        {
            get { return dry; }
            set
            {
                dry = value;
                OnSizeChanged?.Invoke(value);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.OnSizeChanged += SquareConsoleInfo;
            Console.Write("Введите коорлинату X верхнего левого угла: ");
            square.ulX = int.Parse(Console.ReadLine());
            Console.Write("Введите коорлинату Y верхнего левого угла: ");
            square.ulY = int.Parse(Console.ReadLine());
            Console.Write("Введите коорлинату X нижнего правого угла: ");
            square.drX = int.Parse(Console.ReadLine());
            Console.Write("Введите коорлинату Y нижнего правого угла: ");
            square.drY = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Введите коорлинату X нижнего правого угла: ");
                square.drX = int.Parse(Console.ReadLine());
                Console.Write("Введите коорлинату Y нижнего правого угла: ");
                square.drY = int.Parse(Console.ReadLine());
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static void SquareConsoleInfo(double value)
        {
            Console.WriteLine($"{value:f2}");
        }
    }
}