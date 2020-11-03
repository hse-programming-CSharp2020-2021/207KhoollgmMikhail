using System;

namespace Task_08
{
    class Program
    {
        public class Shedule
        {
            string[] week = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            public string this[int index]
            {
                get
                {
                    if (index < 1 || index > 7) return "Incorrect input";

                    return week[index - 1];
                }
            }

        }
        static void Main(string[] args)
        {
            Shedule first = new Shedule();
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}. {first[i]}");
            }
            Console.WriteLine(first[8]);
        }
    }
}
