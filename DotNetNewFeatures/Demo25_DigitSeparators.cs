namespace DotNetNewFeatures;

internal static class Demo25_DigitSeparators
{
    public static void RunDemo()
    {
        var person = new Person { Name = "Alice", Age = 30, Address = new Address { City = "Wonderland" } };

        var result = person switch
        {
            { Age: > 20, Address.City: "Wonderland" } => "Adult in Wonderland",
            _ => "Other"
        };

        Console.WriteLine(result);
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
    }
}
