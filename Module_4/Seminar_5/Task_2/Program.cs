using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int n = int.Parse(Console.ReadLine());

            var animals = new List<Animal>();
            for(int i = 0; i < n; i++)
            {
                if (rnd.Next(0, 2) == 0) 
                    animals.Add(new Mammal(rnd.Next().ToString(), rnd.Next(0, 2) == 0 ? true : false, rnd.Next(1, 21)));
                else
                    animals.Add(new Bird(rnd.Next().ToString(), rnd.Next(0, 2) == 0 ? true : false, rnd.Next(1, 101)));
            }

            var zoo = new Zoo(animals);

            foreach(Animal animal in zoo)
            {
                Console.WriteLine(animal);
                animal.DoSound();
            }

            var req1 = zoo.OfType<Bird>().Where(bird => bird.IsTakenCare);

            foreach (var br in req1)
                Console.WriteLine(br);
            Console.WriteLine();

            var req2 = zoo.OfType<Mammal>().Where(mammal => !mammal.IsTakenCare);

            foreach (var mm in req2)
                Console.WriteLine(mm);
        }
    }

    interface IVocal
    {
        void DoSound();
    }

    abstract class Animal : IVocal
    {
        private static int count = 1;
        public virtual void DoSound() { }

        public Animal()
        {
            ID = count++;
        }
        public int ID { get; protected set; }
        public string Name { get; protected set; }
        public bool IsTakenCare { get; protected set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name:{Name}, Is taken care: {IsTakenCare}";
        }

    }

    class Mammal : Animal
    {
        public int Paws { get; private set; }


        public Mammal(string name, bool isTakenCare, int paws)
        {
            if (paws < 1 || paws > 20) throw new ArgumentException();
            Name = name;
            IsTakenCare = isTakenCare;
            Paws = paws;
        }


        public override void DoSound()
        {
            Console.WriteLine("я млекопитающие, би-би-би");
        }

        public override string ToString()
        {
            return base.ToString() + $", Paws: {Paws}";
        }
    }

    class Bird : Animal
    {
        public int Speed { get; private set; }


        public Bird(string name, bool isTakenCare, int speed)
        {
            if (speed < 1 || speed > 100) throw new ArgumentException();
            Name = name;
            IsTakenCare = isTakenCare;
            Speed = speed;
        }


        public override void DoSound()
        {
            Console.WriteLine("я птичка, пип-пип-пип");
        }

        public override string ToString()
        {
            return base.ToString() + $", Speed: {Speed}";
        }
    }

    class Zoo : IEnumerable<Animal>
    {
        public List<Animal> animals;

        public Zoo(List<Animal> animals)
        {
            this.animals = animals;
        }

        public IEnumerator GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        IEnumerator<Animal> IEnumerable<Animal>.GetEnumerator()
        {
            return animals.GetEnumerator();
        }
    }

}
