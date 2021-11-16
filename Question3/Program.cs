using System;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get animal name and sound from user
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

        /// <summary>
        /// Print Message to Consonle
        /// </summary>
        /// <param name="animal"></param>
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


        /// <summary>
        /// Get animal from user input
        /// </summary>
        /// <returns></returns>
        static List<Animal> GetAnimals()
        {
            var animals = new List<Animal>();
            string repeat = null;

            do
            {
                Console.Write("Enter animal name: ");
                var name = Console.ReadLine();

                Console.Write("Enter the animal onomatopoeia sound: ");
                var sound = Console.ReadLine();

                animals.Add(new Animal
                {
                    Name = name,
                    Sound = sound
                });

                Console.WriteLine("==============================================================");
                Console.Write("Do you want to enter another animal? (y/N): ");
                repeat = Console.ReadLine();

            } while (!string.IsNullOrEmpty(repeat) || repeat?.ToLower() == "y" || repeat?.ToLower() == "yes");

            return animals;
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
    }
}

