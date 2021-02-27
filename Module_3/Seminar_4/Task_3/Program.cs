using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger[] passengers = new Passenger[5]
            {
                new Passenger(){Name = "Mike", LastName = "Smith", Age = 34},
                new Passenger(){Name = "John", LastName = "Adams", Age = 73},
                new PassengerWithChildren(){Name = "Alice", LastName = "Adams", Age = 35, NumberOfChildren = 4, IsNewBorn = false},
                new PassengerWithChildren(){Name = "Loise", LastName = "Griffin", Age = 43, NumberOfChildren = 3, IsNewBorn = true},
                new Passenger(){Name = "Peter", LastName = "Griffin", Age = 43}
            };
            PassengerQueue queue = new PassengerQueue();
            foreach (var p in passengers)
            {
                queue.AddToQueue(p);
            }
            queue.StartServingQueue();
        }
    }

    public class Passenger
    {
        public bool IsOld { get { return Age > 65; } }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} {LastName}, Age: {Age}, Is old: {IsOld}";
        }
    }
    /// <summary>
    /// Пассажир с детьми
    /// </summary>
    public class PassengerWithChildren : Passenger
    {
        public bool IsNewBorn { set; get; }
        public int NumberOfChildren { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Number of children: {NumberOfChildren}, Is new born: {IsNewBorn}";
        }
    }
    /// <summary>
    /// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
    /// Пассажиры приоритетной очереди обслуживаются вне очереди
    /// </summary>
    public class PassengerQueue
    {
        // if passenger is ordinary we use ordinaryQueue
        Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
        // if passenger is old or with newborns we use priorityQueue
        Queue<Passenger> priorityQueue = new Queue<Passenger>();

        public void AddToQueue(Passenger newPassenger)
        {
            if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn) priorityQueue.Enqueue(newPassenger);
            else ordinaryQueue.Enqueue(newPassenger);
        }
        public void StartServingQueue()
        {
            Console.WriteLine("Priority queue: ");
            foreach (var p in priorityQueue) Console.WriteLine(p);

            Console.WriteLine("Ordinary queue: ");
            foreach (var p in ordinaryQueue) Console.WriteLine(p);

            Console.WriteLine();

            if (priorityQueue.Count <= 3)
            {
                foreach (var p in priorityQueue) Console.WriteLine(p);
                foreach (var p in ordinaryQueue) Console.WriteLine(p);
            }
            else
            {
                for (int i = 0; i < Math.Max(priorityQueue.Count, ordinaryQueue.Count); i++)
                {
                    if (priorityQueue.Count > 0) Console.WriteLine(priorityQueue.Dequeue());
                    if (ordinaryQueue.Count > 0) Console.WriteLine(ordinaryQueue.Dequeue());
                }
            }

        }
    }
}
