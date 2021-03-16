using System;
using System.Collections.Generic;

namespace Task_02
{
    class ElectronicQueue<T>
    {
        public Queue<T> queue;

        public ElectronicQueue()
        {
            queue = new Queue<T>(10);
        }
    }


    class Person
    {
        public string name, surname;
        int age;

        public Person(string name, string surname, int age)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
        }

        public override string ToString()
        {
            return $"{name} {surname}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElectronicQueue<Person> elecQueue = new ElectronicQueue<Person>();
            Person[] people = new Person[3]
            {
                new Person("Adam", "Smith", 34),
                new Person("Peter", "Griffin", 42),
                new Person("Tony", "Stark", 47)
            };

            foreach (var p in people)
            {
                elecQueue.queue.Enqueue(p);
                Console.WriteLine($"{p} has been added to queue");
            }

            Console.WriteLine(elecQueue.queue.Dequeue() + "has been removed from queue");
            Console.WriteLine(elecQueue.queue.Dequeue() + "has been removed from queue");
            Console.WriteLine(elecQueue.queue.Dequeue() + "has been removed from queue");

        }
    }
}
