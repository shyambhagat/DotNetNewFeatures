namespace DotNetNewFeatures;

internal static class Demo22_ImprovedLambdaSyntax
{
    public static void RunDemo()
    {
        var square = (int x) => x * x;
        Console.WriteLine($"Square of 5: {square(5)}");
    }
}
