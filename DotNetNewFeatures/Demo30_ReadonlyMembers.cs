namespace DotNetNewFeatures;

internal static class Demo30_ReadonlyMembers
{
    public static void RunDemo()
    {
        var point = new Point(1, 2);
        Console.WriteLine(point);
    }

    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public readonly override string ToString() => $"({X}, {Y})";
    }
}
