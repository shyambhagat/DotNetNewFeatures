namespace OOPConcepts;

internal static class Demo03_Inheritance
{
    public static void RunDemo()
    {
        var employee = new Employee("Jane Doe", 28, "Developer");
        Console.WriteLine(employee);
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

    public class Employee : Person
    {
        public string Position { get; set; }

        public Employee(string name, int age, string position)
            : base(name, age)
        {
            Position = position;
        }

        public override string ToString() => $"{base.ToString()}, Position: {Position}";
    }
}
