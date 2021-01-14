using System;

namespace Task_4
{
    class Program
    {
        delegate void Steps(); // делегат-тип
        static void Main(string[] args)
        {
            Robot rob = new Robot();    
           // 
          
            Console.WriteLine("Start:" + rob.Position());

            Console.WriteLine("Введите команды для робота: ");
            string way = Console.ReadLine();
            Steps trace = delegate { };
            foreach(char a in way)
            {
                switch (a)
                {
                    case 'R':
                        trace += rob.Right;
                        break;
                    case 'L':
                        trace += rob.Left;
                        break;
                    case 'F':
                        trace += rob.Forward;
                        break;
                    case 'B':
                        trace += rob.Backward;
                        break;
                }
            }

            trace();

            Console.WriteLine(rob.Position());     // сообщить координаты

        }
    }

    class Robot
    {
        // класс для представления робота
        int x, y; // положение робота на плоскости 

        public void Right() { x++; }      // направо
        public void Left() { x--; }      // налево
        public void Forward() { y++; }  // вперед
        public void Backward() { y--; }  // назад

        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x = {0}, y = {1}", x, y);
        }
    }
}
