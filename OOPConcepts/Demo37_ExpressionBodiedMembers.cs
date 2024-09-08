namespace OOPConcepts;

internal static class Demo37_ExpressionBodiedMembers
{
    public static void RunDemo()
    {
        var person = new Person("Jane Doe", 25);
        Console.WriteLine(person);
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) => (Name, Age) = (name, age);

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
