namespace OOPConcepts;

internal static class Demo30_GenericMethods
{
    public static void RunDemo()
    {
        Display(123);
        Display("Hello");
    }

    public static void Display<T>(T item)
    {
        Console.WriteLine($"Item: {item}");
    }
}
