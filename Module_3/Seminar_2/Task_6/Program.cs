using System;

namespace Task_6
{
    class Plant
    {
        double growth, photosensivity, frostresistance;

        public double Growth => growth;
        public double Photosensivity => photosensivity;
        public double Frostresistance => frostresistance;

        public Plant(double growth, double ph, double fr)
        {
            this.growth = growth;
            photosensivity = ph;
            frostresistance = fr;
        }

        public override string ToString()
        {
            return $"Рост: {growth:f3}, Светочувствительность: {photosensivity:f3}, " +
                $"Морозоустойчивость: {frostresistance:f3}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите число растений: ");
            int n;
            do { }
            while (!int.TryParse(Console.ReadLine(), out n));

            Plant[] plants = new Plant[n];
            for (int i = 0; i < plants.Length; i++)
            {
                plants[i] = new Plant(25 + rnd.NextDouble() * 75, rnd.NextDouble() * 100, rnd.NextDouble() * 80);
            }

            Array.ForEach(plants, (a) => Console.WriteLine(a));
            Array.Sort(plants, (a, b) => { return (a.Growth > b.Growth) ? -1 : 1; });
            Console.WriteLine();
            Array.ForEach(plants, (a) => Console.WriteLine(a));

            Array.Sort(plants, (a, b) => { return (a.Frostresistance > b.Frostresistance) ? 1 : -1; });
            Console.WriteLine();
            Array.ForEach(plants, (a) => Console.WriteLine(a));

            Array.Sort(plants, (a, b) => { return ((int)a.Photosensivity % 2 == 0 && (int)b.Photosensivity % 2 == 1) ? -1 : 1; });
            Console.WriteLine();
            Array.ForEach(plants, (a) => Console.WriteLine(a));
        }
    }
}
