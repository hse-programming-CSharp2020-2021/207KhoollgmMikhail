using System;

namespace Task_01
{
    class Birthday
    {
        string name;
        int year, month, day;

        public Birthday(string name, int y, int m, int d)
        {
            this.name = name;
            year = y; month = m; day = d;
        }

        public Birthday()
        {
            year = 1970;
            month = 1;
            day = 1;
        }

        DateTime Date
        {
            get { return new DateTime(year, month, day); }
        }
        public string Information
        {
            get
            {
                return name + ", дата рождения " + day + ":" + month + ":" + year;
            }
        }

        public string SecondFormat()
        {
            return day + "-" + month + "-" + year;
        }
        public int HowManyDays
        {
            get
            {
                int nowDOY = DateTime.Now.DayOfYear;

                int myDOY = Date.DayOfYear;
                int period = (myDOY >= nowDOY) ? (myDOY - nowDOY) : (365 - nowDOY + myDOY);
                return period;
            }

        }
        class Program
        {
            static void Main()
            {
                Birthday md = new Birthday("Чапаев", 1887, 2, 9);
                Console.WriteLine(md.Information);
                Console.WriteLine("До следующего дня рождения дней осталось: ");
                Console.WriteLine(md.HowManyDays);
                Console.WriteLine(md.SecondFormat());

                Birthday km = new Birthday("Маркс Карл", 1818, 5, 4);
                Console.WriteLine(km.Information);
                Console.WriteLine("До следующего дня рождения дней осталось: ");
                Console.WriteLine(km.HowManyDays);

                Birthday no = new Birthday();
                Console.WriteLine(no.Information);
                Console.WriteLine("До следующего дня рождения дней осталось: ");
                Console.WriteLine(no.HowManyDays);
                
            }
        }
    }
}
