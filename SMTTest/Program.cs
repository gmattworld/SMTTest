using System;
using System.Collections.Generic;
using System.Text;

namespace SMTTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = GetAnimals();
            if (animals == null || animals.Count < 1)
            {
                Console.WriteLine("No animal in Old MacDonald farm");
                Console.ReadKey();
                return;
            }

            foreach (var animal in animals)
            {
                PrintMessage(animal);
            }

            Console.ReadKey();
        }

        static void PrintMessage(Animal animal)
        {
            var poem = $@"
                Old MacDonald had a farm, E I E I O,
                And on his farm he had a {animal.Name}, E I E I O.
                With a {animal.Sound} {animal.Sound} here and a {animal.Sound} {animal.Sound} there,
                Here a {animal.Sound}, there a {animal.Sound}, ev'rywhere a {animal.Sound} {animal.Sound}.
                Old MacDonald had a farm, E I E I O.
            ";

            Console.WriteLine(poem);
            Console.WriteLine("==========================================================================================");
        }

        static List<Animal> GetAnimals()
        {
            var animals = new List<Animal>();

            animals.Add(new Animal
            {
                Name = "cow",
                Sound = "moo"
            });

            animals.Add(new Animal
            {
                Name = "dog",
                Sound = "Woof"
            });

            animals.Add(new Animal
            {
                Name = "cat",
                Sound = "meows"
            });

            animals.Add(new Animal
            {
                Name = "pig",
                Sound = "oink"
            });

            animals.Add(new Animal
            {
                Name = "peacock",
                Sound = "squawk"
            });

            animals.Add(new Animal
            {
                Name = "pigeon",
                Sound = "coo"
            });

            animals.Add(new Animal
            {
                Name = "bat",
                Sound = "screech"
            });

            animals.Add(new Animal
            {
                Name = "bee",
                Sound = "buzz"
            });

            animals.Add(new Animal
            {
                Name = "duck",
                Sound = "quack"
            });

            animals.Add(new Animal
            {
                Name = "frog",
                Sound = "croak"
            });

            return animals;
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
    }
}

