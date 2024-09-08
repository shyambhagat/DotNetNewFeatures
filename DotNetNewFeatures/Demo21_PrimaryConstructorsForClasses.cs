namespace DotNetNewFeatures;

internal static class Demo21_PrimaryConstructorsForClasses
{
    public static void RunDemo()
    {
        var person = new Person("John Doe", 30);
        Console.WriteLine(person);
    }

    public class Person(string Name, int Age)
    {
        public string Name { get; } = Name;
        public int Age { get; } = Age;

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
