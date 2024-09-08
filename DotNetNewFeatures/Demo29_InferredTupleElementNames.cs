namespace DotNetNewFeatures;

internal static class Demo29_InferredTupleElementNames
{
    public static void RunDemo()
    {
        var name = "Jane Doe";
        var age = 28;
        var person = (name, age);

        Console.WriteLine($"Person: {person.name}, Age: {person.age}");
    }
}
