using System;

namespace Task_4
{
    struct Rectangle : IComparable
    {
        public double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public int CompareTo(object obj)
        {
            Rectangle other = (Rectangle)obj;
            if (a * b > other.a * other.b) return 1;
            if (a * b == other.a * other.b) return 0;
            if (a * b < other.a * other.b) return -1;
            return 0;
        }
    }

    class Block3D : IComparable
    {
        Rectangle basis;
        double height;

        public Block3D(Rectangle basis, double height)
        {
            this.basis = basis;
            this.height = height;
        }

        public int CompareTo(object obj)
        {
            Block3D other = (Block3D)obj;
            return this.basis.CompareTo(other.basis);
        }

        public override string ToString()
        {
            return $"Основание = {basis.a*basis.b:f3}, высота = {height:f3}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Block3D[] blocks = new Block3D[10];
            Random rnd = new Random();

            for(int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new Block3D(new Rectangle(rnd.NextDouble() * 100, rnd.NextDouble() * 100), rnd.NextDouble() * 100);
            }

            Array.Sort(blocks);

            foreach (var b in blocks)
                Console.WriteLine(b);
        }
    }
}
