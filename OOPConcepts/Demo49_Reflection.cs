namespace OOPConcepts;

internal static class Demo49_Reflection
{
    public static void RunDemo()
    {
        var type = typeof(Person);
        Console.WriteLine($"Class: {type.Name}");

        var properties = type.GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine($"Property: {property.Name}, Type: {property.PropertyType.Name}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
