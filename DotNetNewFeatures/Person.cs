namespace DotNetNewFeatures
{
    public class Person
    {
        public string Name { get; set; } = "Default Name";
        public int Age { get; set; } = 25;
        public string Occupation { get; set; } = "Unemployed";

        public string GetName() => Name;
        public int GetAge() => Age;

        public override string ToString() => $"Name: {Name}, Age: {Age}, Occupation: {Occupation}";

        public void PrintName(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            Console.WriteLine(name);
        }
    }

}
