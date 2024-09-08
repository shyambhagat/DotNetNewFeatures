namespace DotNetNewFeatures;

internal static class Demo27_DefaultLiterals
{
    public static void RunDemo()
    {
        Process(default);
    }

    private static void Process(int value = default)
    {
        Console.WriteLine($"Processing value: {value}");
    }
}
