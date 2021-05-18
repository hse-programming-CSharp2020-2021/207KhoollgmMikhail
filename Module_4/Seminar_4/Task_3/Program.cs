using System;
using System.Collections;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var randColl = new RandomCollection(int.Parse(Console.ReadLine()));

            foreach (var rand in randColl)
                Console.WriteLine(rand);

        }
    }

    class RandomCollection : IEnumerable
    {
        int n;

        public RandomCollection(int n)
        {
            this.n = n;
        }
        public IEnumerator GetEnumerator()
        {
            return new RandEnumerator(n);
        }

        private class RandEnumerator : IEnumerator
        {
            Random rnd;
            int n;
            int count = 0;

            public RandEnumerator(int n)
            {
                this.n = n;
                rnd = new Random();
            }
            public object Current => rnd.Next();

            public bool MoveNext()
            {
                return count++ < n;
            }

            public void Reset()
            {
                count = 0;
            }
        }
    }


}
