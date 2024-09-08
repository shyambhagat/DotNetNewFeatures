namespace OOPConcepts;

internal static class Demo35_LambdaExpressions
{
    public static void RunDemo()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine($"Sum: {add(3, 5)}");
    }
}
