using System;

namespace Task_3_06
{
    class Program
    {
        public static int ClassNumber(int x) // Вычисление номера аудитории на этаже
        {
            return x - x / 100 * 100;
        }
        
        
        
        static void Main(string[] args)
        {
            int a1, a2, a3, min;

            Console.WriteLine("Введите номера трёх аудиторий: ");
            
            if (!(int.TryParse(Console.ReadLine(), out a1) && (int.TryParse(Console.ReadLine(), out a2)) && (int.TryParse(Console.ReadLine(), out a3))))
            {
                Console.WriteLine("Неверное значение");
                return;
            }
            
            min = (ClassNumber(a1) < ClassNumber(a2)) ? ((ClassNumber(a1) < ClassNumber(a3)) ? a1 : a3) : ((ClassNumber(a2) < ClassNumber(a3)) ? a2 : a3);

            Console.WriteLine(min);
        }
    }
}
