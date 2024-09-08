namespace OOPConcepts;

internal static class Demo18_StaticMembers
{
    public static void RunDemo()
    {
        Console.WriteLine($"Count: {Counter.Count}");
        Counter.Increment();
        Console.WriteLine($"Count after increment: {Counter.Count}");
    }

    public static class Counter
    {
        public static int Count { get; private set; }

        public static void Increment() => Count++;
    }
}
