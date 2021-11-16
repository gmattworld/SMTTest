using System;

namespace Solution2
{
    /// <summary>
    /// Main Class
    /// </summary>
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


    /// <summary>
    /// IAnimal interface
    /// </summary>
    public interface IAnimal
    {
        string Cry();
    }

    /// <summary>
    /// Base Animal class implementing IAnimal interface
    /// </summary>
    class Animal : IAnimal
    {
        public virtual string Cry()
        {
            return "cry";
        }
    }


    /// <summary>
    /// Cow class inheriting Animal Class and overriding Cry method
    /// </summary>
    class Cow : Animal
    {
        public override string Cry()
        {
            return "moo";
        }
    }


    /// <summary>
    /// Dog class inheriting Animal Class and overriding Cry method
    /// </summary>
    class Dog : Animal
    {
        public override string Cry()
        {
            return "Woof";
        }
    }


    /// <summary>
    /// Cat class inheriting Animal Class and overriding Cry method
    /// </summary>
    class Cat : Animal
    {
        public override string Cry()
        {
            return "meows";
        }
    }


    /// <summary>
    /// Pig class inheriting Animal Class and overriding Cry method
    /// </summary>
    class Pig : Animal
    {
        public override string Cry()
        {
            return "oink";
        }
    }


    /// <summary>
    /// Duck class inheriting Animal Class and overriding Cry method
    /// </summary>
    class Duck : Animal
    {
        public override string Cry()
        {
            return "quack";
        }
    }
}

