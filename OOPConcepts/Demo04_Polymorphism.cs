namespace OOPConcepts;

internal static class Demo04_Polymorphism
{
    public static void RunDemo()
    {
        var animals = new List<Animal>
        {
            new Dog("Buddy"),
            new Cat("Whiskers")
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound() => Console.WriteLine($"{Name} says: Woof!");
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound() => Console.WriteLine($"{Name} says: Meow!");
    }
}
