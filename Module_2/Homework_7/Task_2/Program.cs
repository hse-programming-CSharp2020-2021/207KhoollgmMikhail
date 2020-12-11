using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string[] input = Abbreviation.ValidatedSplit(Console.ReadLine(), ';');

            if (input == null) 
            {
                Console.WriteLine("Строка содержит не только латинские буквы или пробелы");
                return;
            } 

            foreach(string str in input)
            {
                Console.WriteLine(Abbreviation.Abbrevation(str));
            }

        }
    }
}
