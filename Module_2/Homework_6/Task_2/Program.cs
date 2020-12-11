using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            GeomProgr geomProgrObj; // ссылка на объект типа GeomProgr
            int b, q;
            do
            {
                try
                {
                    Console.Write("Введите начальный член прогрессии: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Введите знаменатель прогрессии: ");
                    q = int.Parse(Console.ReadLine());
                    geomProgrObj = new GeomProgr(b, q); // создаем объект 2                    
                    do
                    {
                        try
                        {
                            Console.Write("Введите номер члена прогрессии: ");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{n}-ый элемент прогрессии: {geomProgrObj[n]}");
                            Console.WriteLine($"Сумма первых {n}-и элементов: {geomProgrObj.ProgrSum(n)}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Введены некорректные данные");
                            Console.WriteLine("Чтобы обновить прогрессию нажмите ESC");
                            continue;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Некорректное число");
                            Console.WriteLine("Чтобы обновить прогрессию нажмите ESC");
                            continue;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Чтобы обновить прогрессию нажмите ESC");
                            continue;
                        }
                        Console.WriteLine("Чтобы обновить прогрессию нажмите ESC");
                    } while (Console.ReadKey(true).Key != ConsoleKey.Escape);                   
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные данные");
                    Console.WriteLine("Чтобы завершить программу нажмите ESC");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Некорректное число");
                    Console.WriteLine("Чтобы завершить программу нажмите ESC");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Чтобы завершить программу нажмите ESC");
                    continue;
                }
                Console.WriteLine("Чтобы завершить программу нажмите ESC");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.WriteLine("Всего прогрессий создано: " + GeomProgr.objectNumber);
        }
    }

    public class GeomProgr
    {
        // поле класса - счетчик созданных объектов: 
        public static uint objectNumber = 0;
        double _b; // первый член прогрессии b!=0
        double _q; // знаменатель прогрессии q!=0
        public double B
        {
            get { return _b; }
            set
            {
                if (value < 0)
                    throw new FormatException();
                if (value == 0)
                    throw new Exception("Недопустимое значение первого члена прогрессии!");
                _b = value;
            }
        }
        public double Q
        {
            get { return _q; }
            set
            {
                if (value < 0)
                    throw new FormatException();
                if (value == 0)
                    throw new Exception("Недопустимое значение знаменателя прогрессии!");
                _q = value;
            }
        }

        public GeomProgr()
        {
            B = 1;
            Q = 1;
            objectNumber++;
        }
        public GeomProgr(double b, double q) : this()
        {
            if (b == 0 || q == 0)
            {
                objectNumber--;
                throw new Exception("Ошибка в аргументах конструктора!");
            }
            B = b;
            Q = q;
        }

        public double this[int n]
        {
            get
            {
                return B * Math.Pow(Q, n - 1);
            }
        }

        public double ProgrSum(int n)
        {
            return B * (Math.Pow(Q, n) - 1) / (Q - 1);
        }


    }

}
