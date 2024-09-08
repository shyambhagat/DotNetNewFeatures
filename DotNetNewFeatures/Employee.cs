namespace DotNetNewFeatures
{
    public class Employee
    {
        public required string Name { get; set; }
        public required int Age { get; set; }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
