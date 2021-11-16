using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cow", "dog", "cat", "pig", "duck" };

            if (animals == null || animals.Length < 1)
            {
                Console.WriteLine("No animal in Old MacDonald farm");
                Console.ReadKey();
                return;
            }

            foreach (var animal in animals)
            {
                IAnimal sound = null;
                switch (animal)
                {
                    case "cow":
                        sound = new Cow();
                        break;

                    case "dog":
                        sound = new Dog();
                        break;

                    case "cat":
                        sound = new Cat();
                        break;

                    case "pig":
                        sound = new Pig();
                        break;

                    case "duck":
                        sound = new Duck();
                        break;
                }

                if (sound != null)
                    PrintMessage(animal, sound.Cry());
            }

            Console.ReadKey();
        }

        static void PrintMessage(string name, string sound)
        {
            var poem = $@"
                Old MacDonald had a farm, E I E I O,
                And on his farm he had a {name}, E I E I O.
                With a {sound} {sound} here and a {sound} {sound} there,
                Here a {sound}, there a {sound}, ev'rywhere a {sound} {sound}.
                Old MacDonald had a farm, E I E I O.
            ";

            Console.WriteLine(poem);
            Console.WriteLine("==========================================================================================");
        }
    }

    class Animal : IAnimal
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

