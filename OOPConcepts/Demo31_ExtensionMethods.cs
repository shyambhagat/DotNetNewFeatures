namespace OOPConcepts;

internal static class Demo31_ExtensionMethods
{
    public static void RunDemo()
    {
        string message = "Hello, World!";
        Console.WriteLine(message.Reverse());
    }
}

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}
