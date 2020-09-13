using System;
using System.Collections.Generic;
using System.Text;

namespace Task_03
{
    class Program
    {
        public static void Sort(ref int x, ref int y, ref int z)
        {
            int max, min, mid;

            max = x > y ? (x > z ? x : z) : (y > z ? y : z);
            min = x < y ? (x < z ? x : z) : (y < z ? y : z);
            mid = x + y + z - max - min;
            x = max;
            y = mid;
            z = min;
        }
        
        
        static void Main(string[] args)
        {
            int a, b, c;
            string inpStr;
            
            inpStr = Console.ReadLine();
            int.TryParse(inpStr, out a);

            inpStr = Console.ReadLine();
            int.TryParse(inpStr, out b);

            inpStr = Console.ReadLine();
            int.TryParse(inpStr, out c);
            Sort(ref a, ref b, ref c);
            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}
