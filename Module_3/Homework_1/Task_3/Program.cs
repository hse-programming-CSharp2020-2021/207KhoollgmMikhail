using System;

namespace Task_3
{
    class Program
    {
        delegate double delegateConvertTemperature(double temp);

        static void Main(string[] args)
        {
            TemperatureConverterImp first = new TemperatureConverterImp();
            delegateConvertTemperature[] tempConvertors = new delegateConvertTemperature[4];
            tempConvertors[0] = first.FromCtoF;
            tempConvertors[1] = StaticTempConverters.FromCtoK;
            tempConvertors[2] = StaticTempConverters.FromCtoR;
            tempConvertors[3] = StaticTempConverters.FromCtoRe;
            string[] scales = { "F", "K", "R", "Re" };
            double temp;
            do Console.Write("Введите температутуру в градусах Цельсия: ");
            while (!double.TryParse(Console.ReadLine(), out temp));

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{temp:F3} C = {tempConvertors[i](temp):F3} {scales[i]}");
            }
        }
    }

    class TemperatureConverterImp
    {
        public double FromFtoC(double f)
        {
            return 5.0 / 9 * (f - 32);
        }
        public double FromCtoF(double c)
        {
            return 9.0 / 5 * c + 32;
        }
    }

    static class StaticTempConverters
    {
        public static double FromCtoK(double c)
        {
            return c + 273.15;
        }
        public static double FromKtoC(double k)
        {
            return k - 273.15;
        }
        public static double FromCtoR(double c)
        {
            return 9.0 / 5 * (c + 273.15);
        }
        public static double FromRtoC(double r)
        {
            return 5.0 / 9 * (r - 491.67);
        }
        public static double FromCtoRe(double c)
        {
            return c * 4 / 5;
        }
        public static double FromRetoC(double re)
        {
            return re * 5 / 4;
        }
    }
}
