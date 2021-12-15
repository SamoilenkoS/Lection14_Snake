using System;
using System.Collections.Generic;
using System.Linq;

namespace Lection14
{
    public class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public override string ToString()
        {
            return $"Name:{Name};Age:{Age};Weight:{Weight};";
        }
    }

    class Program
    {
        delegate void Milestone(int value);
        static event Milestone NewMilestone;
        delegate int SomeMethod(int a, int b);
        static int Sum = 0;

        static void Print(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static double Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }

        static void E1()
        {
            Dog a = new Dog
            {
                Age = 3,
                Name = "Dog A",
                Weight = 50.5
            };
            Dog b = new Dog
            {
                Age = 2,
                Name = "Dog B",
                Weight = 5
            };
            Dog c = new Dog
            {
                Age = 1,
                //Name = "Dog C",
                Weight = 20.1
            };
            Dog[] dogs = new Dog[3];
            dogs[0] = a;
            dogs[1] = b;
            dogs[2] = c;
            //foreach (var dog in dogs.Where(dog => dog.Weight > 10 && dog.Age > 2))
            //{
            //    Console.WriteLine(dog);
            //}
            bool allDogsHaveName = dogs.All(dog => !string.IsNullOrEmpty(dog.Name));
            int dogsWithNameCount = dogs.Count(x => !string.IsNullOrEmpty(x.Name));
            double test = dogs.Max(x => x.Weight);
            Console.WriteLine(dogsWithNameCount);
            foreach (var dogName in dogs
                .Take(2)
                .Where(dog => dog.Weight > 3)
                .Select(dog => dog.Name))
            {
                Console.WriteLine(dogName);
            }
            //foreach (var item in dogs.Select(dog => (dog.Name, dog.Weight * 2)))
            //{
            //    Console.WriteLine(item);
            //}
        }

        static void Print()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 10 == 0)
                {
                    NewMilestone?.Invoke(i);
                }
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            NewMilestone += Program_NewMilestone;
            Print();
            Console.WriteLine(Sum);
        }

        private static void Program_NewMilestone(int value)
        {
            Sum += value;
        }
    }
}
