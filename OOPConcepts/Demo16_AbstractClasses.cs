namespace OOPConcepts;

internal static class Demo16_AbstractClasses
{
    public static void RunDemo()
    {
        var rectangle = new Rectangle(5, 10);
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
    }

    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
    }
}
