namespace DotNetNewFeatures;

internal static class Demo20_InlineTypeMembers
{
    public static void RunDemo()
    {
        var point = new Point { X = 10, Y = 20 };
        Console.WriteLine($"Point: ({point.X}, {point.Y})");
    }

    public class Point
    {
        public int X { get; init; }
        public int Y { get; init; }
        public static Point Origin => new Point { X = 0, Y = 0 };
    }
}
