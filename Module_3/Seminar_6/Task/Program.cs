using System;

namespace Task
{
    struct Coords
    {
        public double X{ get; private set; }
        public double Y { get; private set; }

        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"x = {X}, y = {Y}";
        }
    }   

    class Circle
    {
        Coords center;
        double radius;

        double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0) throw new ArgumentException("Радиус не может быть меньше нуля");
                radius = value;
            }
        }

        public Circle(double x, double y, double r)
        {
            center = new Coords(x, y);
            Radius = r;
        }

        public override string ToString()
        {
            return $"Radius = {radius}, {center}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Circle(2, 1, 1));
        }
    }
}
