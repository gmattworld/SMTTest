using System;

namespace Solution2
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
    }

    class Animal
    {
        public virtual string Cry()
        {
            return "cry";
        }
    }

    class Cow : Animal
    {
        public override string Cry()
        {
            return "moo";
        }
    }

    class Dog : Animal
    {
        public override string Cry()
        {
            return "Woof";
        }
    }

    class Cat : Animal
    {
        public override string Cry()
        {
            return "meows";
        }
    }

    class Pig : Animal
    {
        public override string Cry()
        {
            return "oink";
        }
    }

    class Duck : Animal
    {
        public override string Cry()
        {
            return "quack";
        }
    }
}

