using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    class Program
    {

        static void Main()
        {

            Fibbonacci fi = new Fibbonacci();
            var triag = new TriangNums();

            var fibNumbs = fi.nextMemb(7).ToArray();
            var triagNumbs = triag.nextMemb(7).ToArray();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{fibNumbs[i]} + {triagNumbs[i]} = {fibNumbs[i] + triagNumbs[i]}");
            }



        } // end of Main()

    } // end of Program

    class Fibbonacci
    {
        int last = 1, prelast = 0;
        public IEnumerable<int> nextMemb(int n)
        {
            last = 1;
            prelast = 0;
            for (int i = 0; i < n; i++)
            {
                yield return last + prelast;
                int temp = prelast;
                prelast = last;
                last = last + temp;

            }
        }
    }

    class TriangNums
    {
        public IEnumerable<int> nextMemb(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return i * (i + 1) / 2;
            }
        }
    }
}
