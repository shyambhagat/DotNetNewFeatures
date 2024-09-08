namespace OOPConcepts;

internal static class Demo32_LINQ
{
    public static void RunDemo()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Even numbers:");
        evenNumbers.ForEach(Console.WriteLine);
    }
}
