using System;

namespace Task_11
{
    class GeometricProgression
    {
        double _start;
        double _increment;

        public GeometricProgression()
        {
            _start = 0;
            _increment = 0;
        }

        public GeometricProgression(double start, double increment)
        {
            if (start == 0) throw new Exception("Первый член прогрессии не может быть нулём");
            if (increment == 0) throw new Exception("Знаменатель прогрессии не может быть нулём");
            _start = start;
            _increment = increment;
        }

        public double this[int index]
        {
            get
            {
                if (index < 1) throw new IndexOutOfRangeException();
                return _start * Math.Pow(_increment, index - 1);
            }
        }

        public double GetSum(int n)
        {
            return (_start * (Math.Pow(_increment, n) - 1)) / (_increment - 1);
        }

        public override string ToString()
        {
            return $"b1 = {_start,5:F3}, q = {_increment,5:F3}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();

                int N = rnd.Next(5, 16);
                GeometricProgression[] arr = new GeometricProgression[N];

                for (int i = 0; i < N; i++)
                {
                    double b1 = rnd.NextDouble() * 10;
                    double q = 0.00001 + rnd.NextDouble() * 4.99999;
                    arr[i] = new GeometricProgression(b1, q);
                }

                GeometricProgression ind = new GeometricProgression(rnd.NextDouble() * 10, 0.00001 + rnd.NextDouble() * 4.99999);

                int step = rnd.Next(3, 16);
                Console.WriteLine($"Последовательности, у котрых {step,2}-ый элемент больше, чем {ind[step]:F3} :");

                for (int i = 0; i < N; i++)
                {
                    if (arr[i][step] > ind[step])
                        Console.WriteLine($"Последовательность №{i + 1,2} {arr[i]}");
                }

                Console.WriteLine($"\nСуммы первых {step} элементов каждой последовательности:");

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Последовательность №{i + 1,2} {arr[i]}, S(step) = {arr[i].GetSum(step):F3}");
                }

                Console.WriteLine("Нажмите ESC, чтобы выйти");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
