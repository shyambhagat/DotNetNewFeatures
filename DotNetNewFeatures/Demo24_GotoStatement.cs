namespace DotNetNewFeatures;

internal static class Demo24_GotoStatement
{
    public static void RunDemo()
    {
        int counter = 0;

    start:
        if (counter < 5)
        {
            Console.WriteLine($"Counter: {counter}");
            counter++;
            goto start;
        }
    }
}
