namespace DotNetNewFeatures
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Expression-bodied constructor
        public Customer() => (Name, Age) = ("Default Name", 0);

        // Expression-bodied destructor
        ~Customer() => Console.WriteLine($"Customer {Name} is being destroyed");

        // Expression-bodied property getter and setter
        public string Info => $"Name: {Name}, Age: {Age}";

        public override string ToString() => Info;
    }

}
