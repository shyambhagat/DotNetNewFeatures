namespace OOPConcepts;

internal static class Demo15_AccessModifiers
{
    public static void RunDemo()
    {
        var person = new Person("John Doe", 30);
        Console.WriteLine(person.GetInfo());
    }

    public class Person
    {
        private string Name { get; set; }
        protected int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string GetInfo() => $"Name: {Name}, Age: {Age}";
    }
}
