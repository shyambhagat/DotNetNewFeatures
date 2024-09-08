namespace OOPConcepts;

internal static class Demo34_Tuples
{
    public static void RunDemo()
    {
        var person = GetPerson();
        Console.WriteLine($"Name: {person.name}, Age: {person.age}");
    }

    private static (string name, int age) GetPerson()
    {
        return ("Jane Doe", 25);
    }
}
