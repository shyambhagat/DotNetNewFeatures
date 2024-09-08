namespace OOPConcepts;

internal static class Demo14_Overriding
{
    public static void RunDemo()
    {
        var employee = new Employee("Jane Doe", 28, "Developer");
        Console.WriteLine(employee.GetInfo());
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

        public virtual string GetInfo() => $"Name: {Name}, Age: {Age}";
    }

    public class Employee : Person
    {
        public string Position { get; set; }

        public Employee(string name, int age, string position)
            : base(name, age)
        {
            Position = position;
        }

        public override string GetInfo() => $"{base.GetInfo()}, Position: {Position}";
    }
}
