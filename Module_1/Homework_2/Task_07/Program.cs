using System;

namespace Task_07
{
    class Program
    {
        public static void Separation (double value, out int whole, out double fraction)
        {
            whole = (int)value;
            fraction = value - whole;
        }

        public static void Square(double value, ref double square, ref double root)
        {
            if (value >= 0) root = Math.Sqrt(value);
            square = value * value;
        }




        static void Main(string[] args)
        {
            double value, fraction, square = 0, root = -1;
            int whole;
            
            Console.WriteLine("Введите дробное число: ");

            if (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Неверное значение");
                return;
            }

            Separation(value, out whole, out fraction);
            Square(value, ref square, ref root);

            Console.WriteLine($"Целая часть числа:   {whole}");
            Console.WriteLine($"Дробная часть числа: {fraction:f3}");
            Console.WriteLine($"Квадрат числа:       {square:f3}");
            if (root==-1) Console.WriteLine("Невозможно извлечь корень");
            else Console.WriteLine($"Корень числа:        {root:f3}");
        }
    }
}
