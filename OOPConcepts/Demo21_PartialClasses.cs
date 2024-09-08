namespace OOPConcepts;

internal static class Demo21_PartialClasses
{
    public static void RunDemo()
    {
        var person = new Person("John Doe", 30);
        Console.WriteLine(person.GetInfo());
    }

    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public partial class Person
    {
        public string GetInfo() => $"Name: {Name}, Age: {Age}";
    }
}
