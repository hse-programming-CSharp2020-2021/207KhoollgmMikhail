using System;

namespace Task_3_02
{
    class Program
    {
        public static void Reverse(ref int value) // Метод для разворота числа в обратном порядке
        {
            string str1 = value.ToString();
            string str2 = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 += str1[i];
            }

            int.TryParse(str2, out value);

        }


        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Введите число: ");

            if (!int.TryParse(Console.ReadLine(), out value)){
                Console.WriteLine("Неверное значение");
                return;
            }

            Reverse(ref value);

            Console.WriteLine(value);

        }
    }
}
