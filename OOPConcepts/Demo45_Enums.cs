namespace OOPConcepts;

internal static class Demo45_Enums
{
    public static void RunDemo()
    {
        var level = LogLevel.Warning;
        Console.WriteLine($"Log Level: {level}");
    }

    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }
}
