using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main()
        {

            Evens ev = new Evens(20, 43);

            foreach (var t in ev.GetEnumerator())

                Console.Write(t + "  ");

            Console.WriteLine();

            Console.ReadKey();

        } // void Main
    }

    class Evens
    {
        int min, max;

        public Evens(int a, int b)
        {
            min = a;
            max = b;
        }

        public IEnumerable<int> GetEnumerator()
        {
            int i;
            if (min % 2 == 0) i = min;
            else i = min + 1;

            for (; i < max; i += 2)
                yield return i;
        }
    }
}
