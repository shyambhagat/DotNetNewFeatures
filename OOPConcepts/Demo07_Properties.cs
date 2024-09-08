namespace OOPConcepts;

internal static class Demo07_Properties
{
    public static void RunDemo()
    {
        var person = new Person { Name = "Jane Doe", Age = 25 };
        Console.WriteLine(person);
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
