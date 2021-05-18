using System;
using System.Linq;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var rnd = new Random();

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = rnd.Next(-10000, 10001);

            // 1
            var req1_1 = from x in array
                         select x.ToString()[^1];
            var req1_2 = array.Select(x => x.ToString()[^1]);

            foreach (var val in req1_1)
                Console.Write(val + ",");
            Console.WriteLine();

            foreach (var val in req1_2)
                Console.Write(val + ",");
            Console.WriteLine();

            // 2
            var req2_1 = from x in array
                         group x by x.ToString()[^1] into group1
                         select $"Key: {group1.Key}, values: {String.Join(',', group1)}";
            var req2_2 = array.GroupBy(x => x.ToString()[^1]).Select(group2 => $"Key: {group2.Key}, values: {String.Join(',', group2)}");

            foreach (var val in req2_1)
                Console.WriteLine(val);

            Console.WriteLine();

            foreach (var val in req2_2)
                Console.WriteLine(val);

            // 3
            var req3_1 = (from x in array
                          where (x % 2 == 0) && (x > 0)
                          select x).Count();

            var req3_2 = array.Where(x => ((x % 2 == 0) && (x > 0))).Count();

            Console.WriteLine(req3_1);

            Console.WriteLine(req3_2);

            // 4
            var req4_1 = (from x in array
                          where x % 2 == 0
                          select x).Aggregate((x, y) => x + y);

            var req4_2 = array.Where(x => (x % 2 == 0)).Aggregate((x, y) => x + y);

            Console.WriteLine(req4_1);

            Console.WriteLine(req4_2);

            // 5
            var req5_1 = from x in array
                         orderby Math.Abs(x).ToString()[0], x.ToString()[^1]
                         select x;

            var req5_2 = array.OrderBy(x => Math.Abs(x).ToString()[0]).ThenBy(x => x.ToString()[^1]);


            foreach (var val in req5_1)
                Console.Write(val + ",");
            Console.WriteLine();

            foreach (var val in req5_2)
                Console.Write(val + ",");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
