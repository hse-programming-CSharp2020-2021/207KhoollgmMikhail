using System;

namespace Task_2
{
    class Program
    {
        public delegate int Cast(double value);


        static void Main(string[] args)
        {
            Cast cast1 = delegate (double value)
            {
                if ((int)value % 2 == 1) return (int)value + 1;
                else return (int)value;
            };
            Cast cast2 = delegate (double value)
            {
                return (int)Math.Log10(value) + 1;
            };
            Cast cast3 = cast1 + cast2;

            Cast cast4 = value => ((int)value % 2 == 1) ? (int)value + 1 : (int)value;
            Cast cast5 = value => (int)Math.Log10(value) + 1;

            double[] arr = new double[4] { 100.3, 123.6, 45, 23.9 };
            foreach(double p in arr)
            {
                Console.WriteLine(cast1(p) + " " + cast2(p));
            }

            Console.WriteLine();

            foreach (double p in arr)
            {
                Console.WriteLine(cast3(p));
            }

            Console.WriteLine();

            foreach (double p in arr)
            {
                Console.WriteLine(cast4(p) + " " + cast5(p));
            }


            
        }
    }
}
