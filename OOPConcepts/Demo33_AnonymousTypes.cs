namespace OOPConcepts;

internal static class Demo33_AnonymousTypes
{
    public static void RunDemo()
    {
        var person = new { Name = "John Doe", Age = 30 };
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
