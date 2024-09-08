namespace OOPConcepts;

internal static class Demo08_Fields
{
    public static void RunDemo()
    {
        var person = new Person("Jane Doe", 25);
        Console.WriteLine(person);
    }

    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString() => $"Name: {name}, Age: {age}";
    }
}
