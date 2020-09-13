using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpStr;

            int x,y;

            inpStr = Console.ReadLine();
            if (!int.TryParse(inpStr, out x)) return;

            inpStr = Console.ReadLine();
            if (!int.TryParse(inpStr, out y)) return;


            if (Math.Sqrt(x * x + y * y) < 10) Console.WriteLine("Точка внутри круга!");
            else Console.WriteLine("Точка вне круга!");

        }
    }
}
