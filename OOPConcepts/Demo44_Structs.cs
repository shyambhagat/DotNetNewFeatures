namespace OOPConcepts;

internal static class Demo44_Structs
{
    public static void RunDemo()
    {
        var point = new Point(5, 10);
        Console.WriteLine(point);
    }

    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"Point ({X}, {Y})";
    }
}
