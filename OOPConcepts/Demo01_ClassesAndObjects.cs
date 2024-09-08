namespace OOPConcepts;

internal static class Demo01_ClassesAndObjects
{
    public static void RunDemo()
    {
        var person = new Person("John Doe", 30);
        Console.WriteLine(person);
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
