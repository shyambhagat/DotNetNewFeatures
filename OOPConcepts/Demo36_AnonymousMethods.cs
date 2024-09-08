namespace OOPConcepts;

internal static class Demo36_AnonymousMethods
{
    public static void RunDemo()
    {
        Func<int, int, int> add = delegate (int a, int b)
        {
            return a + b;
        };

        Console.WriteLine($"Sum: {add(3, 5)}");
    }
}
